using EJEMPLOPOO.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJEMPLOPOO
{
    public partial class FormAlquiler : Form
    {
        Vehiculo[] lista = new Vehiculo[5];
        int numVe = 0;
        String TIPO = null;
        bool electrico;
        public FormAlquiler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Datos_Vehiculo_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radiomoto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMoto.Checked)
            {
                TIPO = "Moto";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttnuevo_Click(object sender, EventArgs e)
        {
            switch (TIPO)
            {
                case "Coche":
                    lista[this.numVe] = new Coche(txtmatricula.Text, Convert.ToDouble(txtkilometraje.Text), Convert.ToDouble(txtautonomia.Text), txtmarca.Text, txtmodelo.Text, electrico);
                    listavehicul.Items.Add(lista[this.numVe]);
                        break;
                case "Moto":
                    break;
                case "Patinete":
                    lista[this.numVe] = new Patinete(txtmatricula.Text, Convert.ToDouble(txtkilometraje.Text), Convert.ToDouble(txtautonomia.Text), txtmarca.Text, Convert.ToInt32(txtnruedas.Text));
                    listavehicul.Items.Add(lista[this.numVe]);
                    break;
            }
            numVe += 1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radiocoche_CheckedChanged(object sender, EventArgs e)
        {
            if (radiocoche.Checked)
            {
                TIPO = "Coche";
            }
        }

        private void radioPatinete_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPatinete.Checked)
            {
                TIPO = "Patinete";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
                if (checkBox1.Checked)
                {
                    electrico = true;
                } else
                {
                    electrico = false;
                }
        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {

        }
    }
}
