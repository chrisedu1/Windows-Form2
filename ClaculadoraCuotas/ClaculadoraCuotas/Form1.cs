using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaculadoraCuotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtInteres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAmortizacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text);
            double interes = double.Parse(txtInteres.Text) / 12 / 100;
            int meses = int.Parse(txtTiempo.Text);

            double cuotaMensual = (monto * interes * Math.Pow(1 + interes, meses)) / (Math.Pow(1 + interes, meses) - 1);


            MessageBox.Show("Su cuota mensual es de: " + cuotaMensual.ToString("C"));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
