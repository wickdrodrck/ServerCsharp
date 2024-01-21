using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int acerr = int.Parse(acer.Text);
            int erro = int.Parse(err.Text);
            int blanco = int.Parse(blan.Text);
            int total = acerr + erro + blanco;
            if (int.Parse(pexamen.Text) == total)
            {
                double puntua = acerr * 4 - erro * 1.5 - blanco * 0.5;
                ptotal.Text = puntua.ToString();
            }else
            {
                salid.Text = "Muchas respuestas e incorrectas preguntas";
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void limp_Click(object sender, EventArgs e)
        {
            acer.Clear();
            err.Clear();
            blan.Clear();
            ptotal.Clear();
            pexamen.Clear();
            salid.Text = " ";
        }
    }
}
