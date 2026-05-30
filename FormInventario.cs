using System;
using System.IO;
using System.Windows.Forms;
namespace papeleriaFinal
{
    public partial class FormInventario : Form
    {
        private LogicaInventario objetoLogica;

        public FormInventario()
        {
            InitializeComponent();
            objetoLogica = new LogicaInventario("Módulo de Inventario");
            ConfigurarGrid();
            CargarDatosDesdeArchivo();
        }

        private void ConfigurarGrid()
        {
            dgvInventario.Columns.Clear();
            dgvInventario.Columns.Add("ID", "ID Producto");
            dgvInventario.Columns.Add("Nombre", "Nombre");
            dgvInventario.Columns.Add("Cantidad", "Cantidad");
            dgvInventario.Columns.Add("Precio", "Precio");
        }

        private void CargarDatosDesdeArchivo()
        {
            string carpetaAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string ruta = Path.Combine(carpetaAppData, "SistemaPapeleria", "InventarioPapeleria.csv");

            if (File.Exists(ruta))
            {
                try
                {
                    string[] lineas = File.ReadAllLines(ruta);
                    for (int i = 1; i < lineas.Length; i++)
                    {
                        string[] datos = lineas[i].Split(',');
                        if (datos.Length == 4)
                        {
                            dgvInventario.Rows.Add(datos[0], datos[1], datos[2], "$" + datos[3]);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error al cargar: " + ex.Message); }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string idIngresado = txtIDproducto.Text.Trim();
                string nombreIngresado = txtbProducto.Text.Trim();

                if (string.IsNullOrEmpty(idIngresado) || string.IsNullOrEmpty(nombreIngresado))
                {
                    throw new Exception("El ID y el Nombre del producto no pueden estar vacíos.");
                }
                int cantidadNueva = int.Parse(txtbCantidadProducto.Text.Trim());
                string precioTexto = txtbPrecio.Text.Trim().Replace("$", "");
                double precioNuevo = double.Parse(precioTexto);
                if (cantidadNueva <= 0)
                {
                    throw new Exception("La cantidad a agregar debe ser un número mayor a cero.");
                }
                if (precioNuevo <= 0)
                {
                    throw new Exception("El precio del producto debe ser un número mayor a cero.");
                }
                string precioIngresado = precioNuevo.ToString("N2");
                bool productoEncontrado = false;

                foreach (DataGridViewRow fila in dgvInventario.Rows)
                {
                    if (fila.IsNewRow) continue;
                    if (fila.Cells["ID"].Value != null)
                    {
                        string idExistente = fila.Cells["ID"].Value.ToString();
                        string nombreExistente = fila.Cells["Nombre"].Value.ToString();

                        if (idExistente == idIngresado && !nombreExistente.Equals(nombreIngresado, StringComparison.OrdinalIgnoreCase))
                        {
                            throw new Exception($"No puedes usar ese ID. Ya pertenece a '{nombreExistente}'.");
                        }

                        if (nombreExistente.Equals(nombreIngresado, StringComparison.OrdinalIgnoreCase))
                        {
                            if (idExistente != idIngresado)
                            {
                                MessageBox.Show($"ID equivocado. Para '{nombreExistente}' el ID es '{idExistente}'");
                                return;
                            }
                            int stockActual = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                            fila.Cells["Cantidad"].Value = (stockActual + cantidadNueva).ToString();
                            fila.Cells["Precio"].Value = "$" + precioIngresado;

                            objetoLogica.ActualizarArchivoCompleto(dgvInventario);
                            MessageBox.Show("Stock actualizado con éxito.");
                            productoEncontrado = true;
                            break;
                        }
                    }
                }
                if (!productoEncontrado)
                {
                    dgvInventario.Rows.Add(idIngresado, nombreIngresado, cantidadNueva, "$" + precioIngresado);
                    objetoLogica.GuardarEnDisco(idIngresado, nombreIngresado, cantidadNueva.ToString(), precioIngresado);
                    MessageBox.Show("Producto nuevo guardado.");
                }
                btnLimpiar.PerformClick();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en las casillas de Cantidad y Precio.", "Error de Formato");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Validación"); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("¿Eliminar producto?", "Confirmar", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow fila in dgvInventario.SelectedRows)
                        {
                            if (!fila.IsNewRow) dgvInventario.Rows.Remove(fila);
                        }
                        objetoLogica.ActualizarArchivoCompleto(dgvInventario);
                        MessageBox.Show("Eliminado exitosamente.");
                    }
                    catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
                }
            }
            else { MessageBox.Show("Selecciona una fila completa."); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIDproducto.Clear();
            txtbProducto.Clear();
            txtbCantidadProducto.Clear();
            txtbPrecio.Clear();
            txtIDproducto.Focus();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            objetoLogica.ResaltarBoton(btnInicio, panelMenu);
            FormInicio inicio = new FormInicio();
            inicio.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            objetoLogica.ResaltarBoton(btnVentas, panelMenu);
            FormVenta ventas = new FormVenta();
            ventas.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            objetoLogica.ResaltarBoton(btnInventario, panelMenu);
        }

        private void txtbProducto_TextChanged(object sender, EventArgs e) { }
        private void txtbPrecio_TextChanged(object sender, EventArgs e) { }
        private void panelInventario_Paint(object sender, PaintEventArgs e) { }
        private void lblIdProducto_Click(object sender, EventArgs e) { }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private void txtIDproducto_TextChanged(object sender, EventArgs e) { }
        private void txtbCantidadProducto_TextChanged(object sender, EventArgs e) { }
    }
}