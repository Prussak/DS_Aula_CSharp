using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void numero_TextChanged(object sender, EventArgs e)
		{
			
				int numero, resultado;


				numero = Convert.ToInt16(campoNumero.Text);

				for (int x = 0; x <= 10; x++)
				{
					resultado = numero * x;
				    listBox1.Items.Add(x + "X" + numero + "=" + resultado);
				}

				
				
			
		}
	}
}
