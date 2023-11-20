using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Restaurante;
using System.Configuration;

namespace GUI_V_2
{
    public partial class Principal : Form
    {
        public string NombreUsuario { get; set; }
        public int id;
        int tema;

        public Principal()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 250)
            {
                panelMenu.Width = 80;
            }
            else
                panelMenu.Width = 250;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private Button currentbtn;

        private void ResaltarBoton(object sender, Color color)
        {
            if (sender != null)
            {
                DesactivarBoton();
                currentbtn = (Button)sender;
                currentbtn.BackColor = Color.FromArgb(33, 33, 33);
                currentbtn.ForeColor = color;
            }
        }

        private void DesactivarBoton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.Black;
                currentbtn.ForeColor = Color.Orange;
            }
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, btnprod.ForeColor);
            AbrirFormEnPanel(new Productos());
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            if (true)
            {
                Inicio inicio = new Inicio(tema);
                inicio.NombreUsuario = NombreUsuario;
                AbrirFormEnPanel(inicio);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null, e);
            tema = 1;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnRestaurar.Dock = DockStyle.Right;
            btnMaximizar.Visible = false;

        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;

        }
        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.White;
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.Transparent;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.White;

        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Transparent;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.White;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.Transparent;
        }


        private void btnRestaurar_MouseEnter(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.White;
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.Transparent;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); // Crea una instancia del formulario de inicio de sesión
            loginForm.Show(); // Muestra el formulario de inicio de sesión
            this.Hide(); // Oculta el formulario actual
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, btnVentas.ForeColor);
            AbrirFormEnPanel(new Ventas());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, btnVentas.ForeColor);
            AbrirFormEnPanel(new Clientes());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            PuntoVenta puntoVenta = new PuntoVenta();
            puntoVenta.idUsuario = id;
            ResaltarBoton(sender, btnVentas.ForeColor);
            AbrirFormEnPanel(puntoVenta);
        }

        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            btnCerrarSesion.BackColor = Color.FromArgb(33, 33, 33); // Blanco

        }

        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarSesion.BackColor = Color.Transparent;
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            if (tema == 1)
            {
                tema = 2;
            }
            else if (tema == 2)
            {
                tema = 1;
            }

            Temas.ElegirTema(tema);
            panelContenedor.BackColor = Temas.PanelContenedor;
            panelMenu.BackColor = Temas.PanelMenu;
            BarraTitulo.BackColor = Temas.PanelBarraTitulo;
        }

        private void btnEvaluacion_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, btnVentas.ForeColor);
            AbrirFormEnPanel(new Evaluacion());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, btnVentas.ForeColor);
            AbrirFormEnPanel(new Usuarios());
        }
    }
}
