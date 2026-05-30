using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace papeleriaFinal
{
    public class LogicaVentas : SistemaBase, IGestionable
    {
        private string rutaArchivo;
        private string rutaGanancias;

        public LogicaVentas(string nombre) : base(nombre)
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
                rutaGanancias = Path.Combine(carpetaApp, "GananciasDiarias.txt");

                string fechaHoy = DateTime.Now.ToString("ddMMyyyy");
                if (!File.Exists(rutaGanancias))
                {
                    File.WriteAllText(rutaGanancias, $"{fechaHoy}|0");
                }
            }
            catch { }
        }

        public double ObtenerTotalCuenta(string id, int cantidadVenta, DataGridView dgv)
        {
            bool encontrado = false;
            try
            {
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.IsNewRow) continue;

                    if (fila.Cells["ID"].Value != null && fila.Cells["ID"].Value.ToString() == id)
                    {
                        encontrado = true;
                        int stockActual = int.Parse(fila.Cells["Cantidad"].Value.ToString());

                        if (stockActual >= cantidadVenta)
                        {
                            double precio = double.Parse(fila.Cells["Precio"].Value.ToString().Replace("$", ""));
                            return precio * cantidadVenta;
                        }
                        else
                        {
                            throw new Exception("Stock insuficiente para realizar la venta.");
                        }
                    }
                }
                if (!encontrado) throw new Exception("El ID del producto no existe in el inventario.");
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public double ConfirmarYFinalizarVenta(string id, int cantidadVenta, double totalCuenta, string pagaConTexto, DataGridView dgv)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(pagaConTexto))
                {
                    throw new Exception("ingresa con cuánto pago el cliente.");
                }
                double pagaCon = double.Parse(pagaConTexto.Trim());

                if (pagaCon < totalCuenta)
                {
                    throw new Exception($"dinero insuficiente. Falta $ {totalCuenta - pagaCon}");
                }
                double cambio = pagaCon - totalCuenta;
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.IsNewRow) continue;

                    if (fila.Cells["ID"].Value != null && fila.Cells["ID"].Value.ToString() == id)
                    {
                        int stockActual = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                        fila.Cells["Cantidad"].Value = (stockActual - cantidadVenta).ToString();
                        break;
                    }
                }
                ActualizarArchivoCompleto(dgv);
                RegistrarGanancia(totalCuenta);

                MessageBox.Show($"¡Venta finalizada!\nTotal de la Venta: $ {totalCuenta}\nCambio: $ {cambio}", "Venta Finalizada");
                return cambio;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void RegistrarGanancia(double montoVenta)
        {
            try
            {
                string fechaHoy = DateTime.Now.ToString("ddMMyyyy");
                double gananciaAcumulada = 0;

                if (File.Exists(rutaGanancias))
                {
                    string contenido = File.ReadAllText(rutaGanancias).Trim();
                    string[] partes = contenido.Split('|');
                    if (partes.Length == 2 && partes[0] == fechaHoy)
                    {
                        double.TryParse(partes[1], out gananciaAcumulada);
                    }
                }
                gananciaAcumulada += montoVenta;
                File.WriteAllText(rutaGanancias, $"{fechaHoy}|{gananciaAcumulada}");
            }
            catch { }
        }

        public void RegistrarGanancia(double montoVenta, string tipoVenta)
        {
            try
            {
                string fechaHoy = DateTime.Now.ToString("ddMMyyyy");
                double gananciaAcumulada = 0;

                if (File.Exists(rutaGanancias))
                {
                    string contenido = File.ReadAllText(rutaGanancias).Trim();
                    string[] partes = contenido.Split('|');
                    if (partes.Length == 2 && partes[0] == fechaHoy)
                    {
                        double.TryParse(partes[1], out gananciaAcumulada);
                    }
                }
                gananciaAcumulada += montoVenta;
                File.WriteAllText(rutaGanancias, $"{fechaHoy}|{gananciaAcumulada}|{tipoVenta}");
            }
            catch { }
        }

        public void ActualizarArchivoCompleto(DataGridView dgv)
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
    }
}