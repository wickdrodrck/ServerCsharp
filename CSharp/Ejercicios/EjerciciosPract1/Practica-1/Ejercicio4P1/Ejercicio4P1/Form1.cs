using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btt1_Click(object sender, EventArgs e)
        {
            if(faren.Text == null)
            {
                salida.Text = "Campo Farenheit vacío.";
            }
            else
            {
                
                int Farenheit = int.Parse(f.Text);

                int conver = (Farenheit - 32) * 5 / 9;

                g.Text = conver.ToString();
            }
            
            


        }

        private void btt2_Click(object sender, EventArgs e)
        {
            if (grados.Text=="")
            {
                salida.Text = "Campo grados vacío.";
            }
            else
            {
                int grads = int.Parse(g.Text);
                

                int conver = (grads * 9 / 5) + 32;

                f.Text = conver.ToString();
            }
        }
    }
}
