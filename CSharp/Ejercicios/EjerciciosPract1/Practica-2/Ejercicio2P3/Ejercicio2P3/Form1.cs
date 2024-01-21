using Ejercicio2P3.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2P3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private bool MesaExiste(int nmesa)
        {
            for(int i = 0;i<lstpend.Items.Count;i++) { 
                if(nmesa == (lstpend.Items[i] as Mesa).Numermesa)
                {
                    return true;
                }
            }
            return false;
        }
        private void bttnew_Click(object sender, EventArgs e)
        {
            Pedido ped;
            string tipomasa = "";
            string ensalada;
            string refresc = "";
            string[] ingr = { };
            int nmesa = int.Parse(nmesas.Text);
            
            int cont = 0;
            if (!string.IsNullOrEmpty(nmesas.Text) && !MesaExiste(nmesa))
            {
                foreach (Control control in grmasa.Controls)
                {
                    if (control is RadioButton)
                    {
                        if ((control as RadioButton).Checked)
                        {
                            tipomasa = control.Text;
                            cont++;
                        }
                    }
                }
                if (cont == 0)
                {
                    MessageBox.Show("Campo Tipo Masa vacío");
                }
                else
                {
                    cont = 0;
                    if (ensacombo.Text != null)
                    {
                        ensalada = ensacombo.Text;
                    }
                    else
                    {
                        ensalada = "";
                    }

                    foreach (Control control in grrefresc.Controls)
                    {
                        if (control is RadioButton)
                        {
                            if ((control as RadioButton).Checked)
                            {
                                refresc = control.Text;
                                cont++;
                            }
                        }
                    }
                    if (cont == 0)
                    {
                        MessageBox.Show("Campo Tipo Masa vacío");
                    }
                    else
                    {
                        cont = 0;
                        foreach (Control control in gringr.Controls)
                        {
                            if (control is CheckBox)
                            {
                                if ((control as CheckBox).Checked)
                                {
                                    ingr.Append(control.Text);
                                }
                            }
                        }

                        ped = new Pedido(tipomasa, ensalada, refresc, ingr);
                        Mesa mes = new Mesa(nmesa, ped);
                        lstpend.Items.Add(mes);
                    }
                }
            }
            else
            {
                MessageBox.Show("Numero de mesa vacío // Número de mesa repetido");
            }

                }

        private void bttserv_Click(object sender, EventArgs e)
        {
            if (lstpend.SelectedIndex != -1)
            {
                lstpend.Items.RemoveAt(lstpend.SelectedIndex);
                lstpend.Refresh();
                MessageBox.Show("Pedido eliminado");
            }
            else
            {
                MessageBox.Show("Pedido no seleccionado");
            }
        }

        private void lstpedid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pedido mess = (Pedido)lstpedid.Items[lstpedid.SelectedIndex];
            string tipomasa = mess.Tipomasa;
            string ensalada = mess.Ensalada;
            string refresc = mess.Refresc;
            string[] ingr = mess.Ingr;

            nmesas.Text = (lstpend.Items[lstpend.SelectedIndex] as Mesa).Numermesa.ToString();

            ensacombo.Text = ensalada;

            foreach (Control control in grmasa.Controls)
            {
                if (control is RadioButton)
                {
                    if ((control as RadioButton).Text == tipomasa)
                    {
                        (control as RadioButton).Checked = true;
                    }
                }
            }

            foreach (Control control in grrefresc.Controls)
            {
                if (control is RadioButton)
                {
                    if ((control as RadioButton).Text == refresc)
                    {
                        (control as RadioButton).Checked = true;
                    }
                }
            }

            foreach (Control control in gringr.Controls)
            {
                if(control is CheckBox) { 
                    if(ingr.Contains((control as CheckBox).Text))
                    {
                        (control as CheckBox).Checked = true;
                    }
                }
            }


        }

        private void lstpend_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstpedid.Items.Clear();
            lstpedid.Items.Add((lstpend.Items[lstpend.SelectedIndex] as Mesa).Pedidom);
        }
    }
        }

