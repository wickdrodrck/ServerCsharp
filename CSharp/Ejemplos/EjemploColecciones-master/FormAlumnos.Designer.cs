namespace EjemploColecciones
{
    partial class FormAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.cajaEdad = new System.Windows.Forms.TextBox();
            this.etiquetaEdad = new System.Windows.Forms.Label();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.cajaDNI = new System.Windows.Forms.TextBox();
            this.etiquetaDNI = new System.Windows.Forms.Label();
            this.cajaNombre = new System.Windows.Forms.TextBox();
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.grpImagen = new System.Windows.Forms.GroupBox();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBusqueda = new System.Windows.Forms.ListBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.cajaBusqueda = new System.Windows.Forms.TextBox();
            this.rbNombreApellidos = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.grpDatos.SuspendLayout();
            this.grpListado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.botonEliminar);
            this.grpDatos.Controls.Add(this.cajaEdad);
            this.grpDatos.Controls.Add(this.etiquetaEdad);
            this.grpDatos.Controls.Add(this.botonEditar);
            this.grpDatos.Controls.Add(this.botonNuevo);
            this.grpDatos.Controls.Add(this.cajaDNI);
            this.grpDatos.Controls.Add(this.etiquetaDNI);
            this.grpDatos.Controls.Add(this.cajaNombre);
            this.grpDatos.Controls.Add(this.etiquetaNombre);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(284, 220);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos Alumno";
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(193, 169);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 6;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // cajaEdad
            // 
            this.cajaEdad.Location = new System.Drawing.Point(94, 111);
            this.cajaEdad.Name = "cajaEdad";
            this.cajaEdad.Size = new System.Drawing.Size(174, 20);
            this.cajaEdad.TabIndex = 2;
            // 
            // etiquetaEdad
            // 
            this.etiquetaEdad.AutoSize = true;
            this.etiquetaEdad.Location = new System.Drawing.Point(7, 118);
            this.etiquetaEdad.Name = "etiquetaEdad";
            this.etiquetaEdad.Size = new System.Drawing.Size(32, 13);
            this.etiquetaEdad.TabIndex = 1;
            this.etiquetaEdad.Text = "Edad";
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(103, 169);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 23);
            this.botonEditar.TabIndex = 5;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(10, 169);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 23);
            this.botonNuevo.TabIndex = 4;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // cajaDNI
            // 
            this.cajaDNI.Location = new System.Drawing.Point(94, 68);
            this.cajaDNI.Name = "cajaDNI";
            this.cajaDNI.Size = new System.Drawing.Size(174, 20);
            this.cajaDNI.TabIndex = 3;
            // 
            // etiquetaDNI
            // 
            this.etiquetaDNI.AutoSize = true;
            this.etiquetaDNI.Location = new System.Drawing.Point(7, 71);
            this.etiquetaDNI.Name = "etiquetaDNI";
            this.etiquetaDNI.Size = new System.Drawing.Size(26, 13);
            this.etiquetaDNI.TabIndex = 2;
            this.etiquetaDNI.Text = "DNI";
            // 
            // cajaNombre
            // 
            this.cajaNombre.Location = new System.Drawing.Point(94, 29);
            this.cajaNombre.Name = "cajaNombre";
            this.cajaNombre.Size = new System.Drawing.Size(174, 20);
            this.cajaNombre.TabIndex = 1;
            // 
            // etiquetaNombre
            // 
            this.etiquetaNombre.AutoSize = true;
            this.etiquetaNombre.Location = new System.Drawing.Point(7, 32);
            this.etiquetaNombre.Name = "etiquetaNombre";
            this.etiquetaNombre.Size = new System.Drawing.Size(44, 13);
            this.etiquetaNombre.TabIndex = 0;
            this.etiquetaNombre.Text = "Nombre";
            // 
            // grpImagen
            // 
            this.grpImagen.Location = new System.Drawing.Point(355, 22);
            this.grpImagen.Name = "grpImagen";
            this.grpImagen.Size = new System.Drawing.Size(200, 210);
            this.grpImagen.TabIndex = 1;
            this.grpImagen.TabStop = false;
            this.grpImagen.Text = "Imagen";
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.lstListado);
            this.grpListado.Location = new System.Drawing.Point(640, 22);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(200, 210);
            this.grpListado.TabIndex = 2;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listado";
            // 
            // lstListado
            // 
            this.lstListado.DisplayMember = "Nombre";
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(6, 24);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(188, 173);
            this.lstListado.TabIndex = 0;
            this.lstListado.Click += new System.EventHandler(this.lstListado_Click);
            this.lstListado.SelectedIndexChanged += new System.EventHandler(this.lstListado_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBusqueda);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.cajaBusqueda);
            this.groupBox1.Controls.Add(this.rbNombreApellidos);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbDNI);
            this.groupBox1.Location = new System.Drawing.Point(22, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 258);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // lstBusqueda
            // 
            this.lstBusqueda.FormattingEnabled = true;
            this.lstBusqueda.Location = new System.Drawing.Point(477, 23);
            this.lstBusqueda.Name = "lstBusqueda";
            this.lstBusqueda.Size = new System.Drawing.Size(357, 225);
            this.lstBusqueda.TabIndex = 5;
            this.lstBusqueda.SelectedIndexChanged += new System.EventHandler(this.lstBusqueda_SelectedIndexChanged);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(280, 155);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 4;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // cajaBusqueda
            // 
            this.cajaBusqueda.Location = new System.Drawing.Point(244, 104);
            this.cajaBusqueda.Name = "cajaBusqueda";
            this.cajaBusqueda.Size = new System.Drawing.Size(147, 20);
            this.cajaBusqueda.TabIndex = 3;
            // 
            // rbNombreApellidos
            // 
            this.rbNombreApellidos.AutoSize = true;
            this.rbNombreApellidos.Location = new System.Drawing.Point(36, 161);
            this.rbNombreApellidos.Name = "rbNombreApellidos";
            this.rbNombreApellidos.Size = new System.Drawing.Size(115, 17);
            this.rbNombreApellidos.TabIndex = 2;
            this.rbNombreApellidos.TabStop = true;
            this.rbNombreApellidos.Text = "Nombre y Apellidos";
            this.rbNombreApellidos.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(36, 104);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(62, 17);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(36, 50);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(44, 17);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.grpImagen);
            this.Controls.Add(this.grpDatos);
            this.Name = "FormAlumnos";
            this.Text = "Ejemplo Colecciones";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpListado.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label etiquetaEdad;
        private System.Windows.Forms.TextBox cajaEdad;
        private System.Windows.Forms.TextBox cajaNombre;
        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.Label etiquetaDNI;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.TextBox cajaDNI;
        private System.Windows.Forms.GroupBox grpImagen;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBusqueda;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox cajaBusqueda;
        private System.Windows.Forms.RadioButton rbNombreApellidos;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbDNI;
    }
}