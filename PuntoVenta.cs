﻿using System;
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
        Conexion con = new Conexion();
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
            string consulta = "select * from Platillo where id";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con.cadena());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
        }
    }
}
