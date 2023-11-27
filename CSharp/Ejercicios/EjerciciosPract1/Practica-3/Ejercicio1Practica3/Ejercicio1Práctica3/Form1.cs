using Ejercicio1Práctica3.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Práctica3
{
    
    public partial class Form1 : Form
    {
        Tienda tiendagen = new Tienda { };
        Almacen almacen = new Almacen { };
        public Form1()
        {
            InitializeComponent();
        }

        private void bttacept_Click(object sender, EventArgs e)
        {
            string tipoqueso;
            bool tipoquesocheck=false;
            if (string.IsNullOrEmpty(tmarca.Text) || string.IsNullOrEmpty(dtcaducidad.Text) || string.IsNullOrEmpty(tfabri.Text) || string.IsNullOrEmpty(tpeso.Text) || string.IsNullOrEmpty(tlote.Text))
            {
                MessageBox.Show("Cajas de texto vacías.");
            }else
            {
                foreach (Control control in grqueso.Controls)
                {
                    if (control is RadioButton)
                    {
                        if ((control as RadioButton).Checked == true)
                        {
                            tipoqueso = control.Text;
                            tipoquesocheck = true;
                        }

                    }
                }
                if (tipoquesocheck)
                {
                    if (tiendagen.Tiendaquesos.Length < 50)
                    {
                        tiendagen.Tiendaquesos.Append(new Queso(tmarca.Text, tfabri.Text, tlote.Text, double.Parse(tpeso.Text), dtcaducidad.Value));
                    }
                    else
                    {
                        almacen.Almacenquesos.Append(new Queso(tmarca.Text, tfabri.Text, tlote.Text, double.Parse(tpeso.Text), dtcaducidad.Value));
                    }
                }
                else
                {
                    MessageBox.Show("No se eligió tipo de queso");
                }

            }

        }

        private void tmarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
