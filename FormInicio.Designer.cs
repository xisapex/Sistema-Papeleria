namespace papeleriaFinal
{
    partial class FormInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            panelMenu = new Panel();
            btnInventario = new Button();
            btnVentas = new Button();
            btnInicio = new Button();
            panelContenido = new Panel();
            dgvInventario = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelStockCritico = new Panel();
            lblNoStockCritico = new Label();
            lblStockCritico1 = new Label();
            panelTotalArticulos = new Panel();
            lblTotalArticulosTotal = new Label();
            lblTotalArticulos = new Label();
            panelValorInventario = new Panel();
            lblValorInventarioTotal = new Label();
            lblValorInventario = new Label();
            panelPedidosPendientes = new Panel();
            lblPedidosPendientesTotal = new Label();
            lblPedidosPendientes = new Label();
            txtbBarraBusqueda = new TextBox();
            lblStockCriticoTotal = new Label();
            lblStockCritico = new Label();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panelStockCritico.SuspendLayout();
            panelTotalArticulos.SuspendLayout();
            panelValorInventario.SuspendLayout();
            panelPedidosPendientes.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.GradientActiveCaption;
            panelMenu.Controls.Add(btnInventario);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(231, 677);
            panelMenu.TabIndex = 1;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Location = new Point(0, 115);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(231, 57);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Location = new Point(0, 57);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(231, 58);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Location = new Point(0, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(231, 57);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelContenido
            // 
            panelContenido.Controls.Add(dgvInventario);
            panelContenido.Controls.Add(tableLayoutPanel1);
            panelContenido.Controls.Add(txtbBarraBusqueda);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(231, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(898, 677);
            panelContenido.TabIndex = 1;
            // 
            // dgvInventario
            // 
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.WhiteSmoke;
            dgvInventario.ColumnHeadersHeight = 29;
            dgvInventario.Dock = DockStyle.Fill;
            dgvInventario.Location = new Point(0, 125);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(898, 552);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panelStockCritico, 0, 0);
            tableLayoutPanel1.Controls.Add(panelTotalArticulos, 1, 0);
            tableLayoutPanel1.Controls.Add(panelValorInventario, 2, 0);
            tableLayoutPanel1.Controls.Add(panelPedidosPendientes, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(898, 98);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelStockCritico
            // 
            panelStockCritico.Controls.Add(lblNoStockCritico);
            panelStockCritico.Controls.Add(lblStockCritico1);
            panelStockCritico.Dock = DockStyle.Fill;
            panelStockCritico.Location = new Point(3, 3);
            panelStockCritico.Name = "panelStockCritico";
            panelStockCritico.Size = new Size(218, 94);
            panelStockCritico.TabIndex = 0;
            panelStockCritico.Paint += panelStockCritico_Paint;
            // 
            // lblNoStockCritico
            // 
            lblNoStockCritico.AutoSize = true;
            lblNoStockCritico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoStockCritico.Location = new Point(95, 53);
            lblNoStockCritico.Name = "lblNoStockCritico";
            lblNoStockCritico.Size = new Size(23, 28);
            lblNoStockCritico.TabIndex = 3;
            lblNoStockCritico.Text = "1";
            lblNoStockCritico.Click += lblNoStockCritico_Click;
            // 
            // lblStockCritico1
            // 
            lblStockCritico1.AutoSize = true;
            lblStockCritico1.Location = new Point(64, 14);
            lblStockCritico1.Name = "lblStockCritico1";
            lblStockCritico1.Size = new Size(90, 20);
            lblStockCritico1.TabIndex = 3;
            lblStockCritico1.Text = "Stock critico";
            // 
            // panelTotalArticulos
            // 
            panelTotalArticulos.BackColor = Color.LightGreen;
            panelTotalArticulos.Controls.Add(lblTotalArticulosTotal);
            panelTotalArticulos.Controls.Add(lblTotalArticulos);
            panelTotalArticulos.Dock = DockStyle.Fill;
            panelTotalArticulos.Location = new Point(227, 3);
            panelTotalArticulos.Name = "panelTotalArticulos";
            panelTotalArticulos.Size = new Size(218, 94);
            panelTotalArticulos.TabIndex = 1;
            panelTotalArticulos.Paint += panelTotalArticulos_Paint;
            // 
            // lblTotalArticulosTotal
            // 
            lblTotalArticulosTotal.AutoSize = true;
            lblTotalArticulosTotal.Font = new Font("Segoe UI", 12F);
            lblTotalArticulosTotal.Location = new Point(113, 53);
            lblTotalArticulosTotal.Name = "lblTotalArticulosTotal";
            lblTotalArticulosTotal.Size = new Size(23, 28);
            lblTotalArticulosTotal.TabIndex = 2;
            lblTotalArticulosTotal.Text = "1";
            // 
            // lblTotalArticulos
            // 
            lblTotalArticulos.AutoSize = true;
            lblTotalArticulos.Location = new Point(70, 14);
            lblTotalArticulos.Name = "lblTotalArticulos";
            lblTotalArticulos.Size = new Size(102, 20);
            lblTotalArticulos.TabIndex = 0;
            lblTotalArticulos.Text = "Total articulos";
            // 
            // panelValorInventario
            // 
            panelValorInventario.BackColor = Color.LightGreen;
            panelValorInventario.Controls.Add(lblValorInventarioTotal);
            panelValorInventario.Controls.Add(lblValorInventario);
            panelValorInventario.Dock = DockStyle.Fill;
            panelValorInventario.Location = new Point(451, 3);
            panelValorInventario.Name = "panelValorInventario";
            panelValorInventario.Size = new Size(218, 94);
            panelValorInventario.TabIndex = 2;
            panelValorInventario.Paint += panelValorInventario_Paint;
            // 
            // lblValorInventarioTotal
            // 
            lblValorInventarioTotal.AutoSize = true;
            lblValorInventarioTotal.Font = new Font("Segoe UI", 12F);
            lblValorInventarioTotal.Location = new Point(101, 53);
            lblValorInventarioTotal.Name = "lblValorInventarioTotal";
            lblValorInventarioTotal.Size = new Size(23, 28);
            lblValorInventarioTotal.TabIndex = 2;
            lblValorInventarioTotal.Text = "0";
            // 
            // lblValorInventario
            // 
            lblValorInventario.AutoSize = true;
            lblValorInventario.Location = new Point(59, 14);
            lblValorInventario.Name = "lblValorInventario";
            lblValorInventario.Size = new Size(113, 20);
            lblValorInventario.TabIndex = 0;
            lblValorInventario.Text = "Valor inventario";
            // 
            // panelPedidosPendientes
            // 
            panelPedidosPendientes.BackColor = Color.LightGreen;
            panelPedidosPendientes.Controls.Add(lblPedidosPendientesTotal);
            panelPedidosPendientes.Controls.Add(lblPedidosPendientes);
            panelPedidosPendientes.Dock = DockStyle.Fill;
            panelPedidosPendientes.Location = new Point(675, 3);
            panelPedidosPendientes.Name = "panelPedidosPendientes";
            panelPedidosPendientes.Size = new Size(220, 94);
            panelPedidosPendientes.TabIndex = 3;
            // 
            // lblPedidosPendientesTotal
            // 
            lblPedidosPendientesTotal.AutoSize = true;
            lblPedidosPendientesTotal.Font = new Font("Segoe UI", 12F);
            lblPedidosPendientesTotal.Location = new Point(101, 53);
            lblPedidosPendientesTotal.Name = "lblPedidosPendientesTotal";
            lblPedidosPendientesTotal.Size = new Size(23, 28);
            lblPedidosPendientesTotal.TabIndex = 3;
            lblPedidosPendientesTotal.Text = "0";
            lblPedidosPendientesTotal.Click += lblPedidosPendientesTotal_Click;
            // 
            // lblPedidosPendientes
            // 
            lblPedidosPendientes.AutoSize = true;
            lblPedidosPendientes.Location = new Point(47, 14);
            lblPedidosPendientes.Name = "lblPedidosPendientes";
            lblPedidosPendientes.Size = new Size(112, 20);
            lblPedidosPendientes.TabIndex = 0;
            lblPedidosPendientes.Text = "Ganancia diaria";
            // 
            // txtbBarraBusqueda
            // 
            txtbBarraBusqueda.Dock = DockStyle.Top;
            txtbBarraBusqueda.Location = new Point(0, 0);
            txtbBarraBusqueda.Name = "txtbBarraBusqueda";
            txtbBarraBusqueda.Size = new Size(898, 27);
            txtbBarraBusqueda.TabIndex = 0;
            txtbBarraBusqueda.Tag = "Buscar Producto";
            // 
            // lblStockCriticoTotal
            // 
            lblStockCriticoTotal.AutoSize = true;
            lblStockCriticoTotal.Location = new Point(95, 53);
            lblStockCriticoTotal.Name = "lblStockCriticoTotal";
            lblStockCriticoTotal.Size = new Size(17, 20);
            lblStockCriticoTotal.TabIndex = 1;
            lblStockCriticoTotal.Text = "1";
            // 
            // lblStockCritico
            // 
            lblStockCritico.AutoSize = true;
            lblStockCritico.Location = new Point(57, 14);
            lblStockCritico.Name = "lblStockCritico";
            lblStockCritico.Size = new Size(95, 20);
            lblStockCritico.TabIndex = 0;
            lblStockCritico.Text = "Stock Critico.";
            // 
            // panel1
            // 
            panel1.Controls.Add(panelMenu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 677);
            panel1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 677);
            Controls.Add(panelContenido);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panelStockCritico.ResumeLayout(false);
            panelStockCritico.PerformLayout();
            panelTotalArticulos.ResumeLayout(false);
            panelTotalArticulos.PerformLayout();
            panelValorInventario.ResumeLayout(false);
            panelValorInventario.PerformLayout();
            panelPedidosPendientes.ResumeLayout(false);
            panelPedidosPendientes.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Panel panelContenido;
        private Button btnInventario;
        private Button btnVentas;
        private Button btnInicio;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtbBarraBusqueda;
        private Panel panelStockCritico;
        private DataGridView dgvInventario;
        private Panel panelTotalArticulos;
        private Panel panelValorInventario;
        private Panel panelPedidosPendientes;
        private Label lblStockCriticoTotal;
        private Label lblStockCritico;
        private Label lblTotalArticulos;
        private Label lblValorInventario;
        private Label lblPedidosPendientes;
        private Label lblTotalArticulosTotal;
        private Label lblValorInventarioTotal;
        private Label lblPedidosPendientesTotal;
        private Label lblStockCritico1;
        private Panel panel1;
        private Label lblNoStockCritico;
        private System.Windows.Forms.Timer timer1;
    }
}