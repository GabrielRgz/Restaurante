using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Usuarios : Form
    {
        Conexion con = new Conexion();
        public void ObtenerDatos()
        {
            string consulta = "select * from Usuario";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con.cadena());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataClientes.DataSource = dt;
        }

        public void Limpiar()
        {
            txbID.Texts = "";
            txbRol.Texts = "";
            txbUsuario.Texts = "";
            txbContrasena.Texts = "";
            txbNombre.Texts = "";
            txbApellido.Texts = "";
        }
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.White;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Transparent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string agregar = $"insert into Usuario(Rol, NombreUsuario, Contrasena, Nombre, Apellido) values({txbRol.Texts}, '{txbUsuario.Texts}', '{txbContrasena.Texts}', '{txbNombre.Texts}', '{txbApellido.Texts}')";
            SqlCommand sc = new SqlCommand(agregar, con.cadena());
            sc.ExecuteNonQuery();
            MessageBox.Show("Registro creado");
            ObtenerDatos();
            Limpiar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editar = $"update Usuario set Rol={txbRol.Texts}, NombreUsuario='{txbUsuario.Texts}', Contrasena='{txbContrasena.Texts}', Nombre='{txbNombre.Texts}', Apellido='{txbApellido.Texts}' where UsuarioID={txbID.Texts}";
            SqlCommand sc = new SqlCommand(editar, con.cadena());
            sc.ExecuteNonQuery();
            MessageBox.Show("Registro actualizado");
            ObtenerDatos();
            Limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string borrar = $"delete from Usuario where UsuarioID={txbID.Texts}";
            SqlCommand sc = new SqlCommand(borrar, con.cadena());
            sc.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");
            ObtenerDatos();
            Limpiar();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            con.Open();
            ObtenerDatos();
        }

        private void dataClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Texts = dataClientes.SelectedCells[0].Value.ToString();
            txbRol.Texts = dataClientes.SelectedCells[1].Value.ToString();
            txbUsuario.Texts = dataClientes.SelectedCells[2].Value.ToString();
            txbContrasena.Texts = dataClientes.SelectedCells[3].Value.ToString();
            txbNombre.Texts = dataClientes.SelectedCells[4].Value.ToString();
            txbApellido.Texts = dataClientes.SelectedCells[5].Value.ToString();
        }
    }
}
