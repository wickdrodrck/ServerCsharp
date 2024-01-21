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
    public partial class TiendaPrincip : Form
    {
        public TiendaPrincip()
        {
            InitializeComponent();
        }

        private void tiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
        }
    }
}
