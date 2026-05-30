namespace papeleriaFinal
{
    partial class FormInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            pbLogo1 = new PictureBox();
            lblCorreo = new Label();
            lblContraseña = new Label();
            txtbCorreo = new TextBox();
            txtbContraseña = new TextBox();
            btnInicioSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo1).BeginInit();
            SuspendLayout();
            // 
            // pbLogo1
            // 
            pbLogo1.BackgroundImage = Properties.Resources.Gemini_Generated_Image_ottff5ottff5ottf;
            pbLogo1.BackgroundImageLayout = ImageLayout.Stretch;
            pbLogo1.Location = new Point(139, 71);
            pbLogo1.Name = "pbLogo1";
            pbLogo1.Size = new Size(224, 124);
            pbLogo1.TabIndex = 0;
            pbLogo1.TabStop = false;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10.8F);
            lblCorreo.Location = new Point(49, 228);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(161, 25);
            lblCorreo.TabIndex = 1;
            lblCorreo.Text = "Correo Electronico:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10.8F);
            lblContraseña.Location = new Point(49, 340);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(105, 25);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtbCorreo
            // 
            txtbCorreo.Font = new Font("Segoe UI", 10.8F);
            txtbCorreo.Location = new Point(211, 225);
            txtbCorreo.Name = "txtbCorreo";
            txtbCorreo.Size = new Size(274, 31);
            txtbCorreo.TabIndex = 3;
            txtbCorreo.TextChanged += txtbCorreo_TextChanged;
            // 
            // txtbContraseña
            // 
            txtbContraseña.Font = new Font("Segoe UI", 10.8F);
            txtbContraseña.Location = new Point(211, 340);
            txtbContraseña.Name = "txtbContraseña";
            txtbContraseña.Size = new Size(274, 31);
            txtbContraseña.TabIndex = 4;
            txtbContraseña.UseSystemPasswordChar = true;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.Font = new Font("Segoe UI", 10.8F);
            btnInicioSesion.Location = new Point(139, 440);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(224, 65);
            btnInicioSesion.TabIndex = 5;
            btnInicioSesion.Text = "Iniciar Sesion";
            btnInicioSesion.UseVisualStyleBackColor = true;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f9a93034973d27784f42f45b1d56c2cd;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(513, 594);
            Controls.Add(btnInicioSesion);
            Controls.Add(txtbContraseña);
            Controls.Add(txtbCorreo);
            Controls.Add(lblContraseña);
            Controls.Add(lblCorreo);
            Controls.Add(pbLogo1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inicio de sesion";
            Load += txtbCorreo_TextChanged;
            ((System.ComponentModel.ISupportInitialize)pbLogo1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo1;
        private Label lblCorreo;
        private Label lblContraseña;
        private TextBox txtbCorreo;
        private TextBox txtbContraseña;
        private Button btnInicioSesion;
    }
}
