using Practica2Ejercicio2.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2Ejercicio2
{
    public partial class Form1 : Form
    {
        List<Pais> lstpais;
        public Form1()
        {
            InitializeComponent();
            lstpais = new List<Pais>();

        }

        private void intrP_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(paisbox.Text) || !string.IsNullOrEmpty(salud.Text))
            {
                Pais pa = new Pais(paisbox.Text, salud.Text);
                lstpais.Add(pa);
                Paislst.Items.Add(pa.NombrePais);
            }
        }

        private void Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pais actu = lstpais[Paislst.SelectedIndex];
            paisbox.Text = actu.NombrePais;
            salud.Text = actu.Saludo;
        }

        private void busc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstpais.Count;i++)
            {
                if (lstpais[i].NombrePais[0] == letrbox.Text[0]) {
                    letrP.Items.Add(lstpais[i].NombrePais);
                }
            }
        }

        private void letrP_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0;i < lstpais.Count;i++)
            {
                if (letrP.Items[letrP.SelectedIndex].ToString() == lstpais[i].NombrePais) {
                    paisbox.Text = lstpais[i].NombrePais;
                    salud.Text = lstpais[i].Saludo;
                }
            }
        }
    }
}
