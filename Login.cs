using GUI_V_2;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Login : Form
    {
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
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
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
    }
}
