using GUI_V_2;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Login : Form
    {
        Conexion con = new Conexion();
        int tema;

        public void Limpiar()
        {
            txbUsuario.Texts = "";
            txbContrasena.Texts = "";
        }

        public Login()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Cambiar el color de la selección (puedes personalizar este color)
            Color customColor = Color.Red;

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, customColor, ButtonBorderStyle.Dotted);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool VerificarCredenciales(string nombreUsuario, string contrasena)
        {
            bool esValido = false;
            string query = "SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @NombreUsuario AND Contrasena = @Contrasena";
            using (SqlCommand cmd = new SqlCommand(query, con.cadena()))
            {
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    esValido = true;
                }
            }
            return esValido;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txbUsuario.Texts;
            string contrasena = txbContrasena.Texts;

            //Ejecuta comando SELECT y guarda el resultado del ID en la variable id
            string getId = "SELECT UsuarioID FROM Usuario WHERE NombreUsuario = '" + usuario + "' AND Contrasena = '" + contrasena + "'";
            SqlCommand sc = new SqlCommand(getId, con.cadena());

            

            //Si el nombre y contrasena coinciden crea el nuevo form principal y asigna el id y el nombre de usuario para usarse en las forms inicio y punto de venta
            if (VerificarCredenciales(usuario, contrasena))
            {
                int id = (int)sc.ExecuteScalar();
                Principal principal = new Principal(id);
                principal.NombreUsuario = usuario;
                //principal.id = id;
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifica tus credenciales de inicio de sesion");
            }
            Limpiar();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            con.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.White;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {

            btnMinimize.BackColor = Color.Transparent;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
        }


        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con.Open();
        }
    }
}
