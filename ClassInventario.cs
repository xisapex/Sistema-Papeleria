using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace papeleriaFinal
{
    public interface IGestionable
    {
        void ActualizarArchivoCompleto(DataGridView dgv);
    }
    public abstract class SistemaBase
    {
        public string NombreModulo { get; set; }
        protected SistemaBase(string nombre)
        {
            this.NombreModulo = nombre;
        }
        public void ResaltarBoton(Button btn, Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is Button b)
                {
                    if (b.Name == btn.Name)
                    {
                        b.BackColor = Color.FromArgb(37, 36, 81);
                        b.ForeColor = Color.Cyan;
                    }
                    else
                    {
                        b.BackColor = Color.FromArgb(31, 30, 68);
                        b.ForeColor = Color.White;
                    }
                }
            }
        }
    }
    public class LogicaInventario : SistemaBase, IGestionable
    {
        private string rutaArchivo;

        public LogicaInventario(string nombre) : base(nombre)
        {
            try
            {
                string carpetaAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string carpetaApp = Path.Combine(carpetaAppData, "SistemaPapeleria");

                if (!Directory.Exists(carpetaApp))
                {
                    Directory.CreateDirectory(carpetaApp);
                }

                rutaArchivo = Path.Combine(carpetaApp, "InventarioPapeleria.csv");
                if (!File.Exists(rutaArchivo))
                {
                    File.WriteAllText(rutaArchivo, "ID,Nombre,Cantidad,Precio" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el archivo de inventario: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GuardarEnDisco(string id, string nom, string cant, string precio)
        {
            try
            {
                string linea = $"{id},{nom},{cant},{precio}";
                File.AppendAllLines(rutaArchivo, new[] { linea });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el producto: " + ex.Message, "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GuardarEnDisco(string[] datosProducto)
        {
            if (datosProducto.Length == 4)
            {
                try
                {
                    string linea = $"{datosProducto[0]},{datosProducto[1]},{datosProducto[2]},{datosProducto[3]}";
                    File.AppendAllLines(rutaArchivo, new[] { linea });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el producto: " + ex.Message, "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ActualizarArchivoCompleto(DataGridView dgv)
        {
            try
            {
                List<string> lineas = new List<string>();
                lineas.Add("ID,Nombre,Cantidad,Precio");

                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.IsNewRow) continue;

                    if (fila.Cells["ID"].Value != null)
                    {
                        string id = fila.Cells["ID"].Value.ToString();
                        string nom = fila.Cells["Nombre"].Value.ToString();
                        string cant = fila.Cells["Cantidad"].Value.ToString();
                        string precio = fila.Cells["Precio"].Value.ToString().Replace("$", "").Trim();

                        lineas.Add($"{id},{nom},{cant},{precio}");
                    }
                }
                File.WriteAllLines(rutaArchivo, lineas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el inventario: " + ex.Message, "Error de Escritura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}