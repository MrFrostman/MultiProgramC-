using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad5New
{
    public partial class GeneradorNumerico : Form
    {
        public GeneradorNumerico()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            Random Generador = new Random();
            int numero = int.Parse(TxtNumero.Text);

            for (int i = 0; i < numero; i++)
            {
                int Numeros = Generador.Next(1, 100);
                string s = Numeros.ToString();
                TxtResult.AppendText(s+"\r\n");
            }
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
