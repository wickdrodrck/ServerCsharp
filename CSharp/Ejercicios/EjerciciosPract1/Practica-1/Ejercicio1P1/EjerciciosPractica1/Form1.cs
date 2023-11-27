using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosPractica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salario = Convert.ToInt32(Salario.Text);
            int horas = Convert.ToInt32(Horas.Text);

            int salariototal = salario * horas;

            String stotal = salariototal.ToString();

            Salida.Text = stotal;
        }
    }
}
