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
    public partial class ConversorMonedas : Form
    {
        public ConversorMonedas()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            int Dolar = int.Parse(Txt1.Text);
            Double Pesos=Dolar*21.50;
            string s = Pesos.ToString();
            txt2.Text = s;


                }

        private void Btn2_Click(object sender, EventArgs e)
        {
            int pesos = int.Parse(txt3.Text);
            Double Dolar = pesos / 21.50;
            string s = Dolar.ToString();
            txt4.Text = s;
        }
    }
}
