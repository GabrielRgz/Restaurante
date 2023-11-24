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
        public int productoid;
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

        //Metodo para pasar datos del producto seleccionado al form de punto de venta
        private PuntoVenta getFormInstance()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is PuntoVenta puntoVenta)
                {
                    //retorna la instancia activa del form PuntoVenta
                    return puntoVenta;
                }
            }

            //Si no hay instancia activa, retorna null
            return null;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Verificar forms activos
            /*foreach (var item in Application.OpenForms)
            {
                MessageBox.Show(item.ToString());
            }*/

            //id = ejecutar query select id from Platillo where;
            PuntoVenta puntoVenta = getFormInstance();
            if (puntoVenta != null)
            {
                //Ejecutar metodo
                puntoVenta.AgregarProducto(productoid);
            }
            this.Close();
        }

        private void dataProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productoid = (int)dataProductos.SelectedCells[0].Value;
        }
    }
}
