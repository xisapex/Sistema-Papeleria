using System;
using System.IO;
using System.Windows.Forms;

namespace papeleriaFinal
{
    public partial class FormVenta : Form
    {
        private LogicaVentas objetoVentas;
        private double totalCalculado = 0;

        public FormVenta()
        {
            InitializeComponent();
            objetoVentas = new LogicaVentas("Módulo de Ventas");

            ConfigurarGridVenta();
            CargarInventarioParaVenta();
        }

        private void ConfigurarGridVenta()
        {
            dgvInventario.Columns.Clear();
            dgvInventario.Columns.Add("ID", "ID");
            dgvInventario.Columns.Add("Nombre", "Producto");
            dgvInventario.Columns.Add("Cantidad", "Stock");
            dgvInventario.Columns.Add("Precio", "Precio Unitario");
        }

        private void CargarInventarioParaVenta()
        {
            string carpetaAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string ruta = Path.Combine(carpetaAppData, "SistemaPapeleria", "InventarioPapeleria.csv");

            if (File.Exists(ruta))
            {
                dgvInventario.Rows.Clear();
                string[] lineas = File.ReadAllLines(ruta);
                for (int i = 1; i < lineas.Length; i++)
                {
                    string[] datos = lineas[i].Split(',');
                    if (datos.Length == 4)
                        dgvInventario.Rows.Add(datos[0], datos[1], datos[2], "$ " + datos[3]);
                }
            }
        }

        private void btnCalcularVenta_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtbProductoVneta.Text.Trim();
                int cantidad = int.Parse(txtbCantidadVenta.Text.Trim());
                string pagoTexto = txtBPagaCon.Text.Trim();
                if (totalCalculado == 0)
                {
                    totalCalculado = objetoVentas.ObtenerTotalCuenta(id, cantidad, dgvInventario);
                    lblTotalaPagar.Text = "$ " + totalCalculado.ToString("N2");
                    txtBPagaCon.Clear();

                    MessageBox.Show($"Monto a cobrar: $ {totalCalculado}. Ingrese el dinero recibido en 'Pago Con' para calcular el cambio.", "Paso 1: Cuenta Calculada");
                    txtBPagaCon.Focus();
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(pagoTexto) || pagoTexto == "$0.00" || pagoTexto == "0")
                    {
                        throw new Exception("Por favor, ingresa con cuánto paga el cliente para finalizar la venta.");
                    }
                    string pagoLimpio = pagoTexto.Replace("$", "").Trim();
                    double cambio = objetoVentas.ConfirmarYFinalizarVenta(id, cantidad, totalCalculado, pagoLimpio, dgvInventario);
                    lblCambioTotal.Text = "Cambio: $ " + cambio.ToString("N2");
                    totalCalculado = 0;

                    // Recargamos el inventario visual para ver el stock actualizado tras vender
                    CargarInventarioParaVenta();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa valores numéricos válidos en las casillas correspondientes.", "Error de Formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Transacción");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbProductoVneta.Clear();
            txtbCantidadVenta.Clear();
            txtBPagaCon.Clear();
            lblTotalaPagar.Text = "$0.00";
            lblCambioTotal.Text = "Cambio: $0.00";
            totalCalculado = 0;
            txtbProductoVneta.Focus();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            objetoVentas.ResaltarBoton(btnInicio, panelMenu);
            FormInicio inicio = new FormInicio();
            inicio.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            objetoVentas.ResaltarBoton(btnInventario, panelMenu);
            FormInventario inventario = new FormInventario();
            inventario.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            objetoVentas.ResaltarBoton(btnVentas, panelMenu);
        }

        private void txtbProductoVneta_TextChanged(object sender, EventArgs e) { }
        private void panelVenta_Paint(object sender, PaintEventArgs e) { }
        private void txtBPagaCon_TextChanged(object sender, EventArgs e) { }
        private void lblCantidad_Click(object sender, EventArgs e) { }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private void txtbCantidadVenta_TextChanged(object sender, EventArgs e) { }
    }
}