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
    public partial class Selec : Form
    {
        public int id;
        Conexion con = new Conexion();
        public void ObtenerDatos()
        {
            string consulta = "select * from Platillos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con.cadena());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataProductos.DataSource = dt;
        }

        public Selec()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
        private void PuntoVenta_Load(object sender, EventArgs e)
        {
            con.Open();
            ObtenerDatos();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            //id = ejecutar query select id from Platillo where;

        }
    }
}
