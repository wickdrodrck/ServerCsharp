using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2P1
{
    public partial class Form1 : Form
    {
        int NumPartidos = 5;
        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void equi1_Click(object sender, EventArgs e)
        {

        }

        private void btt1_Click(object sender, EventArgs e)
        {
            int victo1 = int.Parse(ganar1.Text);
            int empat1 = int.Parse(empate1.Text);
            int victo2 = int.Parse(ganar2.Text);
            int empat2 = int.Parse(empate2.Text);

            if ((victo1 + empat1) <= NumPartidos && (victo2+empat2)<=NumPartidos)
            {
                int pntt1 = (victo1 * 2) + empat1;
                int pntt2 = (victo2 * 2) + empat2;
                string punt1 = pntt1.ToString();
                string punt2 = pntt2.ToString();

                equi1.Text = "El equipo 1 tiene: " + pntt1 +" puntos.";
                equi2.Text = "El equipo 2 tiene: " + pntt2 +" puntos.";
            }
            else
            {
                pnt1.Text = "Error";
            }
        }
    }
}
