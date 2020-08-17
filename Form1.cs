using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01ADS
{
    public partial class Form1 : Form
    {
        double valor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = double.Parse(tbTexto.Text) + valor;
            tbResultado.Text = valor.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            valor = valor - double.Parse(tbTexto.Text);
            tbResultado.Text = valor.ToString();

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            valor = valor / double.Parse(tbTexto.Text);
            tbResultado.Text = valor.ToString();

        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            valor = valor * double.Parse(tbTexto.Text);
            tbResultado.Text = valor.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
