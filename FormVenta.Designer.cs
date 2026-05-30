namespace papeleriaFinal
{
    partial class FormVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            panelMenu = new Panel();
            btnInventario = new Button();
            btnInicio = new Button();
            btnVentas = new Button();
            panelVenta = new Panel();
            lblCambioTotal = new Label();
            txtBPagaCon = new TextBox();
            lblPagoCon = new Label();
            lblTotalaPagar = new Label();
            lblTotalPagar = new Label();
            lblCantidad = new Label();
            btnLimpiar = new Button();
            lblID = new Label();
            txtbCantidadVenta = new TextBox();
            btnCalcularVenta = new Button();
            txtbProductoVneta = new TextBox();
            panel3 = new Panel();
            dgvInventario = new DataGridView();
            panelMenu.SuspendLayout();
            panelVenta.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.GradientActiveCaption;
            panelMenu.Controls.Add(btnInventario);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(235, 671);
            panelMenu.TabIndex = 0;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = SystemColors.GradientActiveCaption;
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Location = new Point(0, 116);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(235, 57);
            btnInventario.TabIndex = 5;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.GradientActiveCaption;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Location = new Point(0, 58);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(235, 58);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.GradientActiveCaption;
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Location = new Point(0, 0);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(235, 58);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // panelVenta
            // 
            panelVenta.BackColor = Color.Gainsboro;
            panelVenta.BackgroundImageLayout = ImageLayout.Stretch;
            panelVenta.Controls.Add(lblCambioTotal);
            panelVenta.Controls.Add(txtBPagaCon);
            panelVenta.Controls.Add(lblPagoCon);
            panelVenta.Controls.Add(lblTotalaPagar);
            panelVenta.Controls.Add(lblTotalPagar);
            panelVenta.Controls.Add(lblCantidad);
            panelVenta.Controls.Add(btnLimpiar);
            panelVenta.Controls.Add(lblID);
            panelVenta.Controls.Add(txtbCantidadVenta);
            panelVenta.Controls.Add(btnCalcularVenta);
            panelVenta.Controls.Add(txtbProductoVneta);
            panelVenta.Dock = DockStyle.Top;
            panelVenta.Location = new Point(235, 0);
            panelVenta.Name = "panelVenta";
            panelVenta.Size = new Size(858, 229);
            panelVenta.TabIndex = 1;
            panelVenta.Paint += panelVenta_Paint;
            // 
            // lblCambioTotal
            // 
            lblCambioTotal.AutoSize = true;
            lblCambioTotal.Font = new Font("Segoe UI", 12F);
            lblCambioTotal.Location = new Point(489, 118);
            lblCambioTotal.Name = "lblCambioTotal";
            lblCambioTotal.Size = new Size(137, 28);
            lblCambioTotal.TabIndex = 10;
            lblCambioTotal.Text = "Cambio: $0.00";
            // 
            // txtBPagaCon
            // 
            txtBPagaCon.BackColor = Color.WhiteSmoke;
            txtBPagaCon.Font = new Font("Segoe UI", 12F);
            txtBPagaCon.Location = new Point(542, 63);
            txtBPagaCon.Name = "txtBPagaCon";
            txtBPagaCon.Size = new Size(142, 34);
            txtBPagaCon.TabIndex = 9;
            txtBPagaCon.TextChanged += txtBPagaCon_TextChanged;
            // 
            // lblPagoCon
            // 
            lblPagoCon.AutoSize = true;
            lblPagoCon.Font = new Font("Segoe UI", 12F);
            lblPagoCon.Location = new Point(430, 63);
            lblPagoCon.Name = "lblPagoCon";
            lblPagoCon.Size = new Size(97, 28);
            lblPagoCon.TabIndex = 8;
            lblPagoCon.Text = "Pagó con:";
            // 
            // lblTotalaPagar
            // 
            lblTotalaPagar.AutoSize = true;
            lblTotalaPagar.Font = new Font("Segoe UI", 12F);
            lblTotalaPagar.Location = new Point(563, 12);
            lblTotalaPagar.Name = "lblTotalaPagar";
            lblTotalaPagar.Size = new Size(60, 28);
            lblTotalaPagar.TabIndex = 7;
            lblTotalaPagar.Text = "$0.00";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Segoe UI", 12F);
            lblTotalPagar.Location = new Point(430, 12);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(129, 28);
            lblTotalPagar.TabIndex = 6;
            lblTotalPagar.Text = "Total a pagar:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F);
            lblCantidad.Location = new Point(25, 76);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(175, 28);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad a vender:";
            lblCantidad.Click += lblCantidad_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.WhiteSmoke;
            btnLimpiar.Location = new Point(299, 149);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(176, 55);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar formulario";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(25, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(154, 28);
            lblID.TabIndex = 0;
            lblID.Text = "ID del producto:";
            // 
            // txtbCantidadVenta
            // 
            txtbCantidadVenta.BackColor = Color.WhiteSmoke;
            txtbCantidadVenta.Font = new Font("Segoe UI", 12F);
            txtbCantidadVenta.Location = new Point(216, 76);
            txtbCantidadVenta.Name = "txtbCantidadVenta";
            txtbCantidadVenta.Size = new Size(142, 34);
            txtbCantidadVenta.TabIndex = 3;
            txtbCantidadVenta.TextChanged += txtbCantidadVenta_TextChanged;
            // 
            // btnCalcularVenta
            // 
            btnCalcularVenta.BackColor = Color.WhiteSmoke;
            btnCalcularVenta.Location = new Point(58, 149);
            btnCalcularVenta.Name = "btnCalcularVenta";
            btnCalcularVenta.Size = new Size(176, 55);
            btnCalcularVenta.TabIndex = 4;
            btnCalcularVenta.Text = " Calcular venta";
            btnCalcularVenta.UseVisualStyleBackColor = false;
            btnCalcularVenta.Click += btnCalcularVenta_Click;
            // 
            // txtbProductoVneta
            // 
            txtbProductoVneta.BackColor = Color.WhiteSmoke;
            txtbProductoVneta.Font = new Font("Segoe UI", 12F);
            txtbProductoVneta.Location = new Point(216, 6);
            txtbProductoVneta.Name = "txtbProductoVneta";
            txtbProductoVneta.Size = new Size(142, 34);
            txtbProductoVneta.TabIndex = 2;
            txtbProductoVneta.TextChanged += txtbProductoVneta_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvInventario);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(235, 229);
            panel3.Name = "panel3";
            panel3.Size = new Size(858, 442);
            panel3.TabIndex = 2;
            // 
            // dgvInventario
            // 
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.WhiteSmoke;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Dock = DockStyle.Fill;
            dgvInventario.GridColor = SystemColors.GradientInactiveCaption;
            dgvInventario.Location = new Point(0, 0);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(858, 442);
            dgvInventario.TabIndex = 0;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 671);
            Controls.Add(panel3);
            Controls.Add(panelVenta);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panelVenta.ResumeLayout(false);
            panelVenta.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelVenta;
        private Button btnInicio;
        private Button btnVentas;
        private Button btnInventario;
        private Panel panel3;
        private DataGridView dgvInventario;
        private Label lblCantidad;
        private Button btnLimpiar;
        private Label lblID;
        private Button btnCalcularVenta;
        private TextBox txtbProductoVneta;
        private TextBox txtbCantidadVenta;
        private Label lblCambioTotal;
        private TextBox txtBPagaCon;
        private Label lblPagoCon;
        private Label lblTotalaPagar;
        private Label lblTotalPagar;
    }
}