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
    public partial class TablaMulti : Form
    {
        public TablaMulti()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(TxtNumero.Text);
            for(int i = 1; i <= 10; i++)
            {
                TxtResultado.AppendText(numero + "*" + i + "=" + (numero * i) + "\r\n");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
