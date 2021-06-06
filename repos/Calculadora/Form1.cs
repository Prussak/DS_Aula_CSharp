using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            int Numero1, Numero2, resultado;

            Numero1 = Convert.ToInt32(txtNumero1.Text);
            Numero2 = Convert.ToInt32(txtNumero2.Text);

            resultado = Numero1 + Numero2;

            lblResultado.Text = resultado.ToString();
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            int Numero1, Numero2, resultado;

            Numero1 = Convert.ToInt32(txtNumero1.Text);
            Numero2 = Convert.ToInt32(txtNumero2.Text);

            resultado = Numero1 - Numero2;

            lblResultado.Text = resultado.ToString();
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            int Numero1, Numero2, resultado;

            Numero1 = Convert.ToInt32(txtNumero1.Text);
            Numero2 = Convert.ToInt32(txtNumero2.Text);

            resultado = Numero1 * Numero2;

            lblResultado.Text = resultado.ToString();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            int Numero1, Numero2, resultado;

            Numero1 = Convert.ToInt32(txtNumero1.Text);
            Numero2 = Convert.ToInt32(txtNumero2.Text);

            resultado = Numero1 / Numero2;

            lblResultado.Text = resultado.ToString();
        }
    }
}
