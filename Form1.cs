﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, farh1;
            v1 = double.Parse(Valor.Text);
            farh1 = v1 * (9.0 / 5.0) + 32;
            Resultado.Text = farh1.ToString();
            label2.Text = "FHARENHEIT";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;
            v1 = double.Parse(Valor.Text);
            cent1 = (v1-32) * (9.0 / 5.0);
            Resultado.Text = cent1.ToString();
            label2.Text = "Centigrados";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Valor.Text = "";
            Resultado.Text = "";
        }
    }
}
