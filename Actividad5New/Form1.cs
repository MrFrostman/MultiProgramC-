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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tablaDeMultiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaMulti newOpcion =new TablaMulti();
            newOpcion.Visible = true;

        }

        private void generadorDeNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneradorNumerico NewGenerator = new GeneradorNumerico();
            NewGenerator.Visible = true;
        }

        private void numerosInparesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumerosInP NewInpar = new NumerosInP();
            NewInpar.Visible = true;

        }

        private void numerosParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumerosPares NewNumP = new NumerosPares();
            NewNumP.Visible = true;
        }

        private void numerosPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRIMOS NewPrimo = new PRIMOS();
            NewPrimo.Visible = true;
        }

        private void conversionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void monedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConversorMonedas Divisas = new ConversorMonedas();
            Divisas.Visible = true;
        }

        private void gradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grados Conve = new Grados();
            Conve.Visible = true;

        }
    }
}
