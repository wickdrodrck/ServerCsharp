using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void envv_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(fact1.Text) || string.IsNullOrEmpty(fact2.Text))
            {
                MessageBox.Show("Error ningun factor seleccionado.");
            } else
            {
                double num1 = int.Parse(fact1.Text);
                double num2 = int.Parse(fact2.Text);

                if (sumaa.Checked)
                {
                    double suma = num1 + num2;
                    resul.Text = suma.ToString();
                }else if (rest.Checked)
                {
                    double resta = num1 - num2;
                    resul.Text = resta.ToString();
                }else if (mult.Checked)
                {
                    double multi = num1 * num2;
                    resul.Text = multi.ToString();
                }else if (div.Checked)
                {
                    double divis = num1 / num2;
                    resul.Text = divis.ToString();
                } else
                {
                    MessageBox.Show("Error no se selecciono nada.");
                }
            }
        }
    }
}
