﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Agrego un comentario para ejemplo

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text;
            lblSaludo.Text = "HOLA " + texto; 
        }
    }
}
