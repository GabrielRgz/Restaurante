using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
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
        List<int> clientesId = new List<int>();
        List<int> productos = new List<int>();
        DataTable dtPuntoVenta = new DataTable();

        public void AgregarProducto(int productoId)
        {
            productos.Add(productoId);
            string consulta = "select PlatilloID, Nombre, Precio from Platillos where PlatilloID = " + productoId;
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con.cadena());
            adaptador.Fill(dtPuntoVenta);
            dataProductos.DataSource = dtPuntoVenta;
            calcularImporte();
        }

        public void calcularImporte()
        {
            decimal importeTotal = 0;
            for (int i = 0; i < dataProductos.RowCount - 1; i++)
            {
                importeTotal += (decimal)dataProductos.Rows[i].Cells[2].Value;
            }
            txbImporte.Texts = importeTotal.ToString();
        }

        public PuntoVenta()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private int getVentaID()
        {
            //Verificar si hay datos en la tabla Venta
            string cantidadDatos = "SELECT COUNT(VentaID) FROM Venta";
            SqlCommand cantidadCmd = new SqlCommand(cantidadDatos, con.cadena());
            //Obtener el ID del ultimo renglon de la tabla
            string ventaID = "select top 1 VentaID from Venta order by VentaID DESC";
            SqlCommand command = new SqlCommand(ventaID, con.cadena());
            if ((int)cantidadCmd.ExecuteScalar() == 0)
            {
                return 1;
            }
            else
            {
                return (int)command.ExecuteScalar();
            }

        }

        private void PuntoVenta_Load(object sender, EventArgs e)
        {
            con.Open();
            txbId.Texts = idUsuario.ToString();
            txbVenta.Texts = (getVentaID() + 1).ToString();

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
                                clientesId.Add(clienteID);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txbCliente.DataSource = clientesId;
            con.Close();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            selecfrm = new Selec();
            selecfrm.Show();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string vender = "INSERT INTO Venta(ClienteID, UsuarioID, FechaPedido, ImporteTotal) VALUES (@ClienteID, @UsuarioID, @FechaPedido, @ImporteTotal)";

            using (SqlCommand command = new SqlCommand(vender, con.cadena()))
            {
                command.Parameters.AddWithValue("@ClienteID", Convert.ToInt32(txbCliente.Texts));
                command.Parameters.AddWithValue("@UsuarioID", Convert.ToInt32(txbId.Texts));
                command.Parameters.AddWithValue("@FechaPedido", dtFecha.Text);
                command.Parameters.AddWithValue("@ImporteTotal", Convert.ToDecimal(txbImporte.Texts));
                command.ExecuteNonQuery();
            }

            foreach (var producto in productos)
            {
                string agregaProd = $"insert into DetalleVenta(VentaID, PlatilloID, Cantidad) values({getVentaID()}, {producto}, 1)";
                SqlCommand insertar = new SqlCommand(agregaProd, con.cadena());
                insertar.ExecuteNonQuery();
            }
            con.Close();

            // GENERAR TICKET
            printDocument1 = new PrintDocument();
            PrintDialog prt = new PrintDialog();
            prt.ShowDialog();
            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = prt.PrinterSettings.PrinterName;
            printDocument1.DocumentName = "FacturaMojo";
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDocument1.Print();
            txbImporte.Texts = "";

            //Limpiar datagridview
            MessageBox.Show("Venta exitosa");
            dataProductos.DataSource = null;
            dtPuntoVenta = new DataTable();
        }

        private string getClienteNombre()
        {
            con.Open();
            string nombreCliente = "Nombre";
            string apellidoCliente = "Apellido";
            string cliente = "select " + nombreCliente + " from Cliente where ClienteID = " + txbCliente.Texts;
            SqlCommand command = new SqlCommand(cliente, con.cadena());
            nombreCliente = (string)command.ExecuteScalar();

            cliente = "select " + apellidoCliente + " from Cliente where ClienteID = " + txbCliente.Texts;
            command = new SqlCommand(cliente, con.cadena());
            apellidoCliente = (string)command.ExecuteScalar();

            con.Close();
            return nombreCliente + " " + apellidoCliente;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            int ancho = 300;
            int y = 20;


            e.Graphics.DrawString("--- MojoDojo Eats ---", font, Brushes.Black, new RectangleF(0, y, ancho, 20), formato);
            e.Graphics.DrawString("Fecha/hora: " + dtFecha.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), formato);
            e.Graphics.DrawString("Factura No. " + txbVenta.Texts, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), formato);
            e.Graphics.DrawString("Cliente: " + getClienteNombre(), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), formato);
            e.Graphics.DrawString("---- Productos ---- ", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20), formato);

            foreach (DataRow row in dtPuntoVenta.Rows)
            {
                e.Graphics.DrawString(row[1].ToString() + " - " + row[2].ToString(), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), formato);
            }

            e.Graphics.DrawString("----- Total: $" + txbImporte.Texts + " -----", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20), formato);
            e.Graphics.DrawString("Gracias por su visita!", font, Brushes.Black, new RectangleF(0, y += 35, ancho, 20), formato);
        }

        private void txbCliente_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txbNombreCliente.Texts = getClienteNombre();
        }
    }
}
