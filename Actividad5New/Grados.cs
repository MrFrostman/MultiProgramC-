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
    public partial class Grados : Form
    {
        public Grados()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            int Farenheit = int.Parse(Txt1.Text);
            int Celsius = int.Parse(Txt1.Text);
            Double Conve1 = (5 * (Farenheit - 32)) / 9;//Conversion de farenheitn a  celsius
            Double Conve2 = (Celsius*1.8)+32 ;
            string s = Conve1.ToString();
            string s2 = Conve2.ToString();
            txt2.Text = s;
            txt4.Text = s2;
        }
    }
}
