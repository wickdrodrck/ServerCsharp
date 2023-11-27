using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosP1Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btt1_Click(object sender, EventArgs e)
        {
            string dni = dni1.Text;
            int numdni = int.Parse(dni.Substring(0, 8));
            char letra = dni[8];
            string vali1 = "TRWAGMVFPDXBNJZSQUHLCKE";

            if (vali1[numdni%23] == letra)
            {
                salida.Text = "Es válido.";
            }
            else
            {
                salida.Text = "No es válido.";
            }

        }
    }
}
