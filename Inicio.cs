﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Inicio : Form
    {
        int tema;
        public Inicio()
        {
            InitializeComponent();
        }

        public Inicio(int tema)
        {
            this.tema = tema;
            InitializeComponent();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Temas.ElegirTema(tema);
            this.BackColor = Temas.PanelContenedor;
        }
    }
}
