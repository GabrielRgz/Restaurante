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
    public partial class Clientes : Form
    {
        Conexion con = new Conexion();
        public void ObtenerDatos()
        {
            string consulta = "select * from Cliente";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con.cadena());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataClientes.DataSource = dt;
        }

        public void Limpiar()
        {
            txbID.Texts = "";
            txbNombre.Texts = "";
            txbEmail.Texts = "";
            txbTelefono.Texts = "";
        }
        public Clientes()
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
            string agregar = $"insert into Cliente(Nombre, Apellido, Email, Telefono) values('{txbNombre.Texts}', '{txbApellido.Texts}', '{txbEmail.Texts}', {txbTelefono.Texts})";
            SqlCommand sc = new SqlCommand(agregar, con.cadena());
            sc.ExecuteNonQuery();
            MessageBox.Show("Registro creado");
            ObtenerDatos();
            Limpiar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editar = $"update Cliente set Nombre='{txbNombre.Texts}', Apellido='{txbApellido.Texts}', Email='{txbEmail.Texts}', Telefono={txbTelefono.Texts} where ClienteID={txbID.Texts}";
            SqlCommand sc = new SqlCommand(editar, con.cadena());
            sc.ExecuteNonQuery();
            MessageBox.Show("Registro actualizado");
            ObtenerDatos();
            Limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string borrar = $"delete from Cliente where  ClienteID={txbID.Texts}";
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
            txbNombre.Texts = dataClientes.SelectedCells[1].Value.ToString();
            txbEmail.Texts = dataClientes.SelectedCells[2].Value.ToString();
            txbTelefono.Texts = dataClientes.SelectedCells[3].Value.ToString();
        }
    }
}
