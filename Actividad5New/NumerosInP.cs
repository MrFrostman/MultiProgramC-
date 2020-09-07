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
    public partial class NumerosInP : Form
    {
        public NumerosInP()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(TxtNumero.Text);
            int cont = 0;
            while (numero >= cont)
            {

                if ((cont % 2) == 0)
                {
               
                }
                else
                {
                    string s = cont.ToString();
                    TxtResult.AppendText(s + "\r\n");
                }
                cont++;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
