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
    public partial class Productos : Form
    {
        Conexion con = new Conexion();

        public void ObtenerDatos()
        {
            string consulta = "select * from Platillos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con.cadena());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataProductos.DataSource = dt;
        }

        public void Limpiar()
        {
            txbID.Texts = "";
            txbNombre.Texts = "";
            txbDescripcion.Texts = "";
            txbPrecio.Texts = "";
            txbCategoria.Texts = "";
        }

        public Productos()
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

        private void Productos_Load(object sender, EventArgs e)
        {
            con.Open();
            ObtenerDatos();
        }

        private void dataProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Texts = dataProductos.SelectedCells[0].Value.ToString();
            txbNombre.Texts = dataProductos.SelectedCells[1].Value.ToString();
            txbDescripcion.Texts = dataProductos.SelectedCells[2].Value.ToString();
            txbPrecio.Texts = dataProductos.SelectedCells[3].Value.ToString();
            txbCategoria.Texts = dataProductos.SelectedCells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string agregar = $"insert into Platillos(Nombre, Descripcion, Precio, Categoria) values('{txbNombre.Texts}', '{txbDescripcion.Texts}', {txbPrecio.Texts}, '{txbCategoria.Texts}')";
            SqlCommand sc = new SqlCommand(agregar, con.cadena());
            sc.ExecuteNonQuery();
            MessageBox.Show("Registro creado");
            ObtenerDatos();
            Limpiar();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string editar = $"update Platillos set Nombre='{txbNombre.Texts}', Descripcion='{txbDescripcion.Texts}', Precio={txbPrecio.Texts}, Categoria='{txbCategoria.Texts}' where PlatilloID={txbID.Texts}";
            SqlCommand sc = new SqlCommand(editar, con.cadena());
            sc.ExecuteNonQuery();
            MessageBox.Show("Registro actualizado");
            ObtenerDatos();
            Limpiar();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string borrar = $"delete from Platillos where  PlatilloID={txbID.Texts}";
            SqlCommand sc = new SqlCommand(borrar, con.cadena());
            sc.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");
            ObtenerDatos();
            Limpiar();
        }
    }
}
