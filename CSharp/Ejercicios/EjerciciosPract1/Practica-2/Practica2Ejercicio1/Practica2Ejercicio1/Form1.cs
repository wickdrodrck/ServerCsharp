using Practica2Ejercicio1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2Ejercicio1
{
    public partial class Form1 : Form
    {
        List<Usuario> ArrayVisualizar;
        public Form1()
        {
            InitializeComponent();
            ArrayVisualizar = new List<Usuario> ();
        }
        int cont = 0;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void eda_TextChanged(object sender, EventArgs e)
        {

        }

        private void ape_TextChanged(object sender, EventArgs e)
        {

        }

        Visualizar viss = new Visualizar();
        private void intro_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(nom.Text) && !string.IsNullOrEmpty(ape.Text) && !string.IsNullOrEmpty(eda.Text) && !string.IsNullOrEmpty(dni.Text))
            {
                string nomb = nom.Text;
                string apel = ape.Text;
                int edad = int.Parse(eda.Text);
                string DNI = dni.Text;
                if(edad > 0 && edad < 70)
                {
                    if (DNI.Length == 9 && int.TryParse(DNI.Substring(0, 7), out _) && !int.TryParse(DNI.Substring(8), out _))
                    {

                        ArrayVisualizar.Add(new Usuario(nomb, apel,edad,DNI));    
                        MessageBox.Show("Usuario Introducido.");
                        nom.Clear();
                        ape.Clear();
                        eda.Clear();
                        dni.Clear();
                    } else
                    {
                        MessageBox.Show("DNI MAL");
                    }
                }
                else
                {
                    MessageBox.Show("Edad no es positiva o es mayor de 70");
                }
            }
            else
            {
                MessageBox.Show("Espacios en blanco.");
            }
        }

        private void visu_Click(object sender, EventArgs e)
        {
            
            if(cont+1 <= ArrayVisualizar.Count)
            {
                
                nom.Text = ArrayVisualizar[cont].Nomb;
                ape.Text = ArrayVisualizar[cont].Apel;
                eda.Text = ArrayVisualizar[cont].Edad.ToString();
                dni.Text = ArrayVisualizar[cont].DNI1;
                if (cont == 0)
                {
                    visu.Text = "Siguiente";
                }
                
                else if (cont == ArrayVisualizar.Count)
                {
                    visu.Text = "Visualizar";
                }
                
                salid.Text = "Posicion: " + (cont+1).ToString() + " Total: " + ArrayVisualizar.Count.ToString();
                cont += 1;

            }
            else
            {
                cont = 0;
                nom.Clear();
                ape.Clear();
                eda.Clear();
                dni.Clear();
                salid.Clear();
            }
            

        }
    }
}
