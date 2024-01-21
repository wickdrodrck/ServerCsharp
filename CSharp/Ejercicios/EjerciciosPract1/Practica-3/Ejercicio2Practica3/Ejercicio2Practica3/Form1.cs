using Ejercicio2Practica3.Interfaz_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2Practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimpTextbox()
        {
            foreach(Control control in groupBox2.Controls)
            {
                if(control is TextBox)
                {
                    control.Text = String.Empty;
                }
            }
        }

        private void circunferen_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void rrectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rrectangulo.Checked == true)
            {
                LimpTextbox();
                tradio.Enabled = false;
                tlargo.Enabled = true;
                tlado.Enabled = false;
                tancho.Enabled = true;
            }
        }

        private void circunferen_CheckedChanged(object sender, EventArgs e)
        {
            if(circunferen.Checked == true)
            {
                LimpTextbox();
                tradio.Enabled = true;
                tlargo.Enabled = false;
                tlado.Enabled = false;
                tancho.Enabled = false;
            }
        }

        private void requilat_CheckedChanged(object sender, EventArgs e)
        {
            if (requilat.Checked == true)
            {
                LimpTextbox();
                tradio.Enabled = false;
                tlargo.Enabled = false;
                tlado.Enabled = true;
                tancho.Enabled = false;
            }
        }

        private void calcarea_Click(object sender, EventArgs e)
        {
            string tipo="";
            foreach(Control control in grfigura.Controls)
            {
                if(control is RadioButton && (control as RadioButton).Checked == true)
                {
                    tipo = (control as RadioButton).Text;
                }
            }

            if (tipo == "Rectángulo")
            {
                Rectangulo rect = new Rectangulo(double.Parse(tlargo.Text), double.Parse(tancho.Text));
                listanorm.Items.Add(rect);

                MessageBox.Show("El área es :" + rect.CalcularArea().ToString());
            } else if ( tipo == "Circunferencia")
            {
                Circunferencia circun = new Circunferencia(double.Parse(tradio.Text));
                listanorm.Items.Add(circun);
                MessageBox.Show("El área es :" + circun.CalcularArea().ToString());
            } else if ( tipo == "Triángulo equilátero")
            {
                TrianguloEquilatero trequi = new TrianguloEquilatero(double.Parse(tlado.Text));
                listanorm.Items.Add(trequi);
                MessageBox.Show("El área es :" + trequi.CalcularArea().ToString());
            }
        }
    }
}
