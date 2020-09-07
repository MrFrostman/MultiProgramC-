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
    public partial class PRIMOS : Form
    {
        public PRIMOS()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
     
            int numero = int.Parse(TxtNumero.Text);
            int a = 0;
 
            for (int i = 1; i < (numero + 1); i++)
            {
                if (numero % i == 0)
                {
                    a++;
                    string s = a.ToString();
                    TxtResult.AppendText(s + "\r\n");
                }
            }
            if (a != 2)
            {
          
            }
            else
            {
                string s = a.ToString();
                TxtResult.AppendText(s + "\r\n");
            }
        }
    }
}
