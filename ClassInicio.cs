using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace papeleriaFinal
{
    public class LogicaNavegacion : SistemaBase
    {
        private string rutaArchivo;
        private string rutaGanancias;

        public LogicaNavegacion(string nombre) : base(nombre)
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
            }
            catch { }

            VerificarYReiniciarFecha();
        }
        private void VerificarYReiniciarFecha()
        {
            try
            {
                string fechaHoy = DateTime.Now.ToString("ddMMyyyy");

                if (!File.Exists(rutaGanancias))
                {
                    File.WriteAllText(rutaGanancias, $"{fechaHoy}|0");
                }
                else
                {
                    string contenido = File.ReadAllText(rutaGanancias).Trim();
                    string[] partes = contenido.Split('|');
                    if (partes.Length == 2 && partes[0] != fechaHoy)
                    {
                        File.WriteAllText(rutaGanancias, $"{fechaHoy}|0");
                    }
                }
            }
            catch { }
        }
        public List<string[]> ObtenerInventario()
        {
            List<string[]> lista = new List<string[]>();
            if (File.Exists(rutaArchivo))
            {
                try
                {
                    string[] lineas = File.ReadAllLines(rutaArchivo);
                    for (int i = 1; i < lineas.Length; i++)
                    {
                        if (string.IsNullOrWhiteSpace(lineas[i])) continue;

                        string[] datos = lineas[i].Split(',');
                        if (datos.Length == 4) lista.Add(datos);
                    }
                }
                catch { }
            }
            return lista;
        }
        public double ObtenerGananciasDiarias()
        {
            VerificarYReiniciarFecha();

            if (File.Exists(rutaGanancias))
            {
                try
                {
                    string contenido = File.ReadAllText(rutaGanancias).Trim();
                    string[] partes = contenido.Split('|');

                    if (partes.Length >= 2 && double.TryParse(partes[1], out double ganancias))
                    {
                        return ganancias;
                    }
                }
                catch { }
            }
            return 0;
        }
    }
}