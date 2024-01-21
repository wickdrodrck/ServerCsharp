using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ultimaposi = txtbox1.Text.Length -1;
            bool valido = Char.IsDigit(txtbox1.Text, ultimaposi);
            try
            {
                Convert.ToInt32(txtbox1.Text);
            }
            catch(System.FormatException ex)
            {
                //label2.Text = "Error!";
                MessageBox.Show("Formato númerico incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime(2000, 4, 6);
            DateTime fechaHorahoy = DateTime.Now;
            DateTime Fecha = DateTime.Today;
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form2_LocationChanged(object sender, EventArgs e)
        {

        }

        private void Control(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                if(c.GetType().Name == "TextBox")
                c.BackColor = Color.Green;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtpasswd.PasswordChar = '\0';
        }
    }
}
