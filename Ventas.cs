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
    public partial class Ventas : Form
    {
        Conexion con = new Conexion();
        public void ObtenerDatos()
        {
            string consulta = "select * from Venta";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con.cadena());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataClientes.DataSource = dt;
        }

        public void Limpiar()
        {
            txbID.Texts = "";
            txbCliente.Texts = "";
            txbUsuario.Texts = "";
            txbFecha.Texts = "";
            txbEstado.Texts = "";
        }
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
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
            string agregar = $"insert into Venta(ClienteID, UsuarioID, FechaPedido, Estado) values({txbCliente.Texts}, {txbUsuario.Texts}, '{txbFecha.Texts}', '{txbEstado}')";
            SqlCommand sc = new SqlCommand(agregar, con.cadena());
            sc.ExecuteNonQuery();
            MessageBox.Show("Registro creado");
            ObtenerDatos();
            Limpiar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editar = $"update Venta set ClienteID='{txbCliente.Texts}', UsuarioID='{txbUsuario.Texts}', Fecha='{txbFecha.Texts}', Estado='{txbEstado.Texts}' where VentaID={txbID.Texts}";
            SqlCommand sc = new SqlCommand(editar, con.cadena());
            sc.ExecuteNonQuery();
            MessageBox.Show("Registro actualizado");
            ObtenerDatos();
            Limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string borrar = $"delete from Venta where VentaID={txbID.Texts}";
            SqlCommand sc = new SqlCommand(borrar, con.cadena());
            sc.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");
            ObtenerDatos();
            Limpiar();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            con.Open();
            ObtenerDatos();
        }

        private void dataClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Texts = dataClientes.SelectedCells[0].Value.ToString();
            txbCliente.Texts = dataClientes.SelectedCells[1].Value.ToString();
            txbUsuario.Texts = dataClientes.SelectedCells[2].Value.ToString();
            txbFecha.Texts = dataClientes.SelectedCells[3].Value.ToString();
            txbEstado.Texts = dataClientes.SelectedCells[4].Value.ToString();
        }
    }
}
