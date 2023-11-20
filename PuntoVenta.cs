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
    public partial class PuntoVenta : Form
    {
        Selec selecfrm;
        public int idUsuario;
        Conexion con = new Conexion();
        List<int> ids = new List<int>();

        public void ObtenerDatos()
        {
            string consulta = "select * from Venta";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con.cadena());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
        }

        public PuntoVenta()
        {
            InitializeComponent();
            selecfrm = new Selec();
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
            txbId.Texts = idUsuario.ToString();

            string getId = "SELECT ClienteID FROM Cliente";
            try
            {
                using (SqlCommand command = new SqlCommand(getId, con.cadena()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Asegúrate de que el valor no sea nulo antes de intentar convertirlo
                            if (!reader.IsDBNull(0))
                            {
                                int clienteID = reader.GetInt32(0);
                                ids.Add(clienteID);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txbCliente.DataSource = ids;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            selecfrm.Show();
            int idProd = selecfrm.id;

            List<int> ids = new List<int>();
            ids.Add(idProd);
            string consulta = "select * from Platillos where PlatilloID=" + idProd;
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con.cadena());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataProductos.DataSource = dt;
        }
    }
}
