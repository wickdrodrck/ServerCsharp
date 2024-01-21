using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limp_Click(object sender, EventArgs e)
        {
            euro.Text = "";
            peseta.Text = "";
            salidaerr.Text = "";
        }

        private void cnvt_Click(object sender, EventArgs e)
        {

            double pesetas;
            double euros;

            if (string.IsNullOrEmpty(peseta.Text) && string.IsNullOrEmpty(euro.Text))
            {
                salidaerr.Text = "Error, campos vacíos.";
            } else
            {
                if (peseta.Text == "")
                {

                    euros = double.Parse(euro.Text);
                    peseta.Text = (euros * 166, 386).ToString();
                    eur.Text = "";
                }
                if (euro.Text == "")
                {
                    pesetas = double.Parse(peseta.Text);
                    euro.Text = (pesetas % 166, 386).ToString();
                    peset.Text = "";
                }
                
            }
        }
    }
}
