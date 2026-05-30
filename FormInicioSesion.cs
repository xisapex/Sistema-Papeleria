using System;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Auth.Providers;
namespace papeleriaFinal
{
    public partial class FormInicioSesion : Form
    {
        private const string ApiKey = "AIzaSyBm1vcDbPLRuMbqu44tLWux1jaZzJgeqno";
        private const string AuthDomain = "cejaburronica.firebaseapp.com";
        public FormInicioSesion()
        {
            InitializeComponent();
        }
        private async void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbCorreo.Text) || string.IsNullOrWhiteSpace(txtbContraseña.Text))
            {
                MessageBox.Show("Por favor, ingresa tu correo y contraseña.", "⚠Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var config = new FirebaseAuthConfig
            {
                ApiKey = ApiKey,
                AuthDomain = AuthDomain,
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }
            };
            var client = new FirebaseAuthClient(config);
            try
            {
                btnInicioSesion.Enabled = false;
                var auth = await client.SignInWithEmailAndPasswordAsync(txtbCorreo.Text, txtbContraseña.Text);
                MessageBox.Show("Bienvenido a la papelería familiar", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormInicio inventario = new FormInicio();
                inventario.Show();
                this.Hide();
            }
            catch (FirebaseAuthException)
            {
                MessageBox.Show("Correo o contraseña equivocados", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnInicioSesion.Enabled = true;
            }
        }
        private void txtbCorreo_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}