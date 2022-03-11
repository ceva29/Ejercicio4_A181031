using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region propiedades
        ServiceReference1.WebService1SoapClient ceva = new ServiceReference1.WebService1SoapClient();
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = ceva.areacuadrado(Convert.ToDecimal(textBox1.Text));
            label1.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ceva.areatriangulo(Convert.ToDecimal(textBox2.Text),Convert.ToDecimal(textBox3.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = ceva.areacirculo(Convert.ToDecimal(textBox4.Text)).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
