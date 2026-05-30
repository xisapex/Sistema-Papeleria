using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace papeleriaFinal
{
    public partial class FormInicio : Form
    {
        private LogicaNavegacion logica;

        public FormInicio()
        {
            InitializeComponent();
            logica = new LogicaNavegacion("Menú Principal");
            ConfigurarGridInicio();
            CargarDashboard();
        }

        private void ConfigurarGridInicio()
        {
            dgvInventario.Columns.Clear();
            dgvInventario.Columns.Add("ID", "ID");
            dgvInventario.Columns.Add("Nombre", "Producto");
            dgvInventario.Columns.Add("Cant", "Stock");
            dgvInventario.Columns.Add("Precio", "Precio");
        }

        private void CargarDashboard()
        {
            try
            {
                var inventario = logica.ObtenerInventario();
                dgvInventario.Rows.Clear();

                int stockCriticoCount = 0;
                int totalArticulos = 0;
                double valorTotalInventario = 0;

                foreach (var producto in inventario)
                {
                    dgvInventario.Rows.Add(producto[0], producto[1], producto[2], "$" + producto[3]);
                    int cantidad = int.Parse(producto[2]);
                    double precio = double.Parse(producto[3]);

                    totalArticulos += cantidad;
                    valorTotalInventario += (cantidad * precio);

                    if (cantidad < 10)
                    {
                        stockCriticoCount++;
                    }
                }

                if (stockCriticoCount > 0)
                {
                    panelStockCritico.BackColor = Color.Red;
                    lblStockCritico1.ForeColor = Color.White;
                    lblNoStockCritico.ForeColor = Color.White;
                }
                else
                {
                    panelStockCritico.BackColor = Color.LightGreen;
                    lblStockCritico1.ForeColor = Color.Black;
                    lblNoStockCritico.ForeColor = Color.Black;
                }

                lblTotalArticulosTotal.Text = totalArticulos.ToString();
                lblValorInventarioTotal.Text = "$ " + valorTotalInventario.ToString("N2");
                lblStockCriticoTotal.Text = stockCriticoCount.ToString();

                lblStockCritico1.Text = "Stock Críticos";
                lblNoStockCritico.Text = stockCriticoCount.ToString();
                double gananciasHoy = logica.ObtenerGananciasDiarias();
                lblPedidosPendientesTotal.Text = "$ " + gananciasHoy.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Dashboard: " + ex.Message, "Error de Sistema");
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            logica.ResaltarBoton(btnInicio, panelMenu);
            CargarDashboard();
        }
        private void btnInventario_Click(object sender, EventArgs e)
        {
            try
            {
                logica.ResaltarBoton(btnInventario, panelMenu);
                FormInventario pantalla = new FormInventario();
                pantalla.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir Inventario: " + ex.Message);
            }
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                logica.ResaltarBoton(btnVentas, panelMenu);
                FormVenta pantalla = new FormVenta();
                pantalla.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir Ventas: " + ex.Message);
            }
        }
        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panelStockCritico_Paint(object sender, PaintEventArgs e) { }
        private void panelTotalArticulos_Paint(object sender, PaintEventArgs e) { }
        private void panelValorInventario_Paint(object sender, PaintEventArgs e) { }
        private void dgvInventario_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
        private void lblPedidosPendientesTotal_Click(object sender, EventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarDashboard();
        }
        private void lblNoStockCritico_Click(object sender, EventArgs e) { }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            CargarDashboard();
        }
    }
}