namespace papeleriaFinal
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            panelMenu = new Panel();
            btnInventario = new Button();
            btnVentas = new Button();
            btnInicio = new Button();
            panelInventario = new Panel();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            txtbPrecio = new TextBox();
            txtbCantidadProducto = new TextBox();
            txtIDproducto = new TextBox();
            txtbProducto = new TextBox();
            lblCantidadProducto = new Label();
            lblPrecioProducto = new Label();
            lblIdProducto = new Label();
            lblProducto = new Label();
            dgvInventario = new DataGridView();
            panelMenu.SuspendLayout();
            panelInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.GradientActiveCaption;
            panelMenu.Controls.Add(btnInventario);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Font = new Font("Segoe UI", 10.2F);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(241, 722);
            panelMenu.TabIndex = 0;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = SystemColors.GradientActiveCaption;
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 10.2F);
            btnInventario.Location = new Point(0, 124);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(241, 65);
            btnInventario.TabIndex = 2;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.GradientActiveCaption;
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10.2F);
            btnVentas.Location = new Point(0, 56);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(241, 68);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.GradientActiveCaption;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 10.2F);
            btnInicio.Location = new Point(0, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(241, 56);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelInventario
            // 
            panelInventario.BackColor = Color.Gainsboro;
            panelInventario.BackgroundImageLayout = ImageLayout.Stretch;
            panelInventario.Controls.Add(btnEliminar);
            panelInventario.Controls.Add(btnLimpiar);
            panelInventario.Controls.Add(btnRegistrar);
            panelInventario.Controls.Add(txtbPrecio);
            panelInventario.Controls.Add(txtbCantidadProducto);
            panelInventario.Controls.Add(txtIDproducto);
            panelInventario.Controls.Add(txtbProducto);
            panelInventario.Controls.Add(lblCantidadProducto);
            panelInventario.Controls.Add(lblPrecioProducto);
            panelInventario.Controls.Add(lblIdProducto);
            panelInventario.Controls.Add(lblProducto);
            panelInventario.Dock = DockStyle.Top;
            panelInventario.Location = new Point(241, 0);
            panelInventario.Name = "panelInventario";
            panelInventario.Size = new Size(913, 188);
            panelInventario.TabIndex = 3;
            panelInventario.Paint += panelInventario_Paint;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.WhiteSmoke;
            btnEliminar.Location = new Point(721, 66);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(189, 64);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Borrar producto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.WhiteSmoke;
            btnLimpiar.Location = new Point(467, 112);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(222, 61);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.WhiteSmoke;
            btnRegistrar.Location = new Point(467, 22);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(222, 60);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar producto";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtbPrecio
            // 
            txtbPrecio.BackColor = Color.WhiteSmoke;
            txtbPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtbPrecio.Font = new Font("Segoe UI", 10.2F);
            txtbPrecio.Location = new Point(203, 148);
            txtbPrecio.Name = "txtbPrecio";
            txtbPrecio.Size = new Size(204, 30);
            txtbPrecio.TabIndex = 7;
            txtbPrecio.TextChanged += txtbPrecio_TextChanged;
            // 
            // txtbCantidadProducto
            // 
            txtbCantidadProducto.BackColor = Color.WhiteSmoke;
            txtbCantidadProducto.BorderStyle = BorderStyle.FixedSingle;
            txtbCantidadProducto.Font = new Font("Segoe UI", 10.2F);
            txtbCantidadProducto.Location = new Point(203, 107);
            txtbCantidadProducto.Name = "txtbCantidadProducto";
            txtbCantidadProducto.Size = new Size(204, 30);
            txtbCantidadProducto.TabIndex = 6;
            txtbCantidadProducto.TextChanged += txtbCantidadProducto_TextChanged;
            // 
            // txtIDproducto
            // 
            txtIDproducto.BackColor = Color.WhiteSmoke;
            txtIDproducto.BorderStyle = BorderStyle.FixedSingle;
            txtIDproducto.Font = new Font("Segoe UI", 10.2F);
            txtIDproducto.Location = new Point(203, 63);
            txtIDproducto.Name = "txtIDproducto";
            txtIDproducto.Size = new Size(204, 30);
            txtIDproducto.TabIndex = 5;
            txtIDproducto.TextChanged += txtIDproducto_TextChanged;
            // 
            // txtbProducto
            // 
            txtbProducto.BackColor = Color.WhiteSmoke;
            txtbProducto.BorderStyle = BorderStyle.FixedSingle;
            txtbProducto.Font = new Font("Segoe UI", 10.2F);
            txtbProducto.Location = new Point(203, 22);
            txtbProducto.Name = "txtbProducto";
            txtbProducto.Size = new Size(204, 30);
            txtbProducto.TabIndex = 4;
            txtbProducto.TextChanged += txtbProducto_TextChanged;
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.Location = new Point(24, 112);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(173, 25);
            lblCantidadProducto.TabIndex = 11;
            lblCantidadProducto.Text = "Cantidad a agregar";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Font = new Font("Segoe UI", 10.2F);
            lblPrecioProducto.Location = new Point(24, 148);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(132, 23);
            lblPrecioProducto.TabIndex = 2;
            lblPrecioProducto.Text = "Precio producto";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Font = new Font("Segoe UI", 10.2F);
            lblIdProducto.Location = new Point(24, 66);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(102, 23);
            lblIdProducto.TabIndex = 1;
            lblIdProducto.Text = "ID producto";
            lblIdProducto.Click += lblIdProducto_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 10.2F);
            lblProducto.Location = new Point(24, 25);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(84, 23);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto:";
            // 
            // dgvInventario
            // 
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.WhiteSmoke;
            dgvInventario.ColumnHeadersHeight = 29;
            dgvInventario.Dock = DockStyle.Fill;
            dgvInventario.Location = new Point(241, 188);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(913, 534);
            dgvInventario.TabIndex = 0;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 722);
            Controls.Add(dgvInventario);
            Controls.Add(panelInventario);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panelInventario.ResumeLayout(false);
            panelInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnInventario;
        private Button btnVentas;
        private Button btnInicio;
        private Panel panel1;
        private Panel panelInventario;
        private Label lblCantidadProducto;
        private Label lblPrecioProducto;
        private Label lblIdProducto;
        private Label lblProducto;
        private TextBox txtbProducto;
        private TextBox txtbPrecio;
        private TextBox txtbCantidadProducto;
        private TextBox txtIDproducto;
        private DataGridView dgvInventario;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Button btnEliminar;
    }
}