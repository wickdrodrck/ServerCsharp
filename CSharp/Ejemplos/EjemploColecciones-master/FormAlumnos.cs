using EjemploColecciones.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploColecciones
{
    public partial class FormAlumnos : Form
    {

        List<Alumno> miClase;
        int posicion;
        //

        public FormAlumnos()
        {
            InitializeComponent();
            miClase = new List<Alumno>();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno(cajaNombre.Text, cajaDNI.Text, Convert.ToInt32(cajaEdad.Text));
            miClase.Add(al);
            lstListado.Items.Add(al.Nombre);
            CleanBox(grpDatos);
            cajaNombre.Focus();
        }

        private void CleanBox(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c.GetType().Name == "TextBox")
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void lstListado_Click(object sender, EventArgs e)
        {
            posicion = lstListado.SelectedIndex;
            cajaNombre.Text = miClase[posicion].Nombre;
            cajaDNI.Text = miClase[posicion].Dni;
            cajaEdad.Text = Convert.ToString(miClase[posicion].Edad);
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if(botonEditar.Text == "Editar")
            {
                cajaDNI.Enabled = false;
                botonNuevo.Enabled = false;
                botonEliminar.Enabled = false;
                botonEditar.Text = "Aceptar";
            }
            else
            {
                miClase[posicion].Nombre = cajaNombre.Text;
                miClase[posicion].Edad = Convert.ToInt32(cajaEdad.Text);
                lstListado.Items[posicion] = cajaNombre.Text;
                cajaDNI.Enabled = true;
                botonNuevo.Enabled = true;
                botonEliminar.Enabled = true;
                botonEditar.Text = "Editar";
                CleanBox(grpDatos);
            }
            
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            lstBusqueda.Items.Clear();
            String cadenaBuscada = cajaBusqueda.Text;
            if (rbDNI.Checked)
            {
                

                for(int i = 0; i < miClase.Count; i++)
                {
                    if (miClase[i].Dni == cadenaBuscada)
                    {
                        lstListado.SelectedIndex = i;
                    }
                }

            }
            else if (rbNombre.Checked) { 

                for (int i = 0; i < miClase.Count; i++)
                {
                    if (miClase[i].Nombre.Split(' ')[0] == cadenaBuscada)
                    {
                        lstBusqueda.Items.Add(miClase[i].Nombre);
                    }
                }

            

            }else if (rbNombreApellidos.Checked)

                for (int i = 0; i < miClase.Count; i++)
                {
                    if (miClase[i].Nombre == cadenaBuscada)
                    {
                        lstListado.SelectedIndex = i;
                    }
                }


            {

            }
        }

        private void lstListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

            for(int i = 0;i < lstListado.Items.Count; i++)
            {
                if (lstListado.Items[i].ToString() == lstBusqueda.Items[lstBusqueda.SelectedIndex].ToString()) { 
                    lstListado.SelectedIndex=i;
                }
            }
           
        }
    }
}
