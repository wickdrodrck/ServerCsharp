namespace Ejercicio1Práctica3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grqueso = new System.Windows.Forms.GroupBox();
            this.rimport = new System.Windows.Forms.RadioButton();
            this.rart = new System.Windows.Forms.RadioButton();
            this.rnorm = new System.Windows.Forms.RadioButton();
            this.grdatos = new System.Windows.Forms.GroupBox();
            this.dtcaducidad = new System.Windows.Forms.DateTimePicker();
            this.tpeso = new System.Windows.Forms.TextBox();
            this.tlote = new System.Windows.Forms.TextBox();
            this.tfabri = new System.Windows.Forms.TextBox();
            this.tmarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.grorign = new System.Windows.Forms.GroupBox();
            this.tproceden = new System.Windows.Forms.TextBox();
            this.tdeno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttacept = new System.Windows.Forms.Button();
            this.grqueso.SuspendLayout();
            this.grdatos.SuspendLayout();
            this.grorign.SuspendLayout();
            this.SuspendLayout();
            // 
            // grqueso
            // 
            this.grqueso.Controls.Add(this.rimport);
            this.grqueso.Controls.Add(this.rart);
            this.grqueso.Controls.Add(this.rnorm);
            this.grqueso.Location = new System.Drawing.Point(29, 24);
            this.grqueso.Name = "grqueso";
            this.grqueso.Size = new System.Drawing.Size(155, 151);
            this.grqueso.TabIndex = 0;
            this.grqueso.TabStop = false;
            this.grqueso.Text = "Tipo de queso";
            // 
            // rimport
            // 
            this.rimport.AutoSize = true;
            this.rimport.Location = new System.Drawing.Point(31, 106);
            this.rimport.Name = "rimport";
            this.rimport.Size = new System.Drawing.Size(80, 17);
            this.rimport.TabIndex = 2;
            this.rimport.TabStop = true;
            this.rimport.Text = "Importación";
            this.rimport.UseVisualStyleBackColor = true;
            // 
            // rart
            // 
            this.rart.AutoSize = true;
            this.rart.Location = new System.Drawing.Point(31, 71);
            this.rart.Name = "rart";
            this.rart.Size = new System.Drawing.Size(67, 17);
            this.rart.TabIndex = 1;
            this.rart.TabStop = true;
            this.rart.Text = "Artesano";
            this.rart.UseVisualStyleBackColor = true;
            // 
            // rnorm
            // 
            this.rnorm.AutoSize = true;
            this.rnorm.Location = new System.Drawing.Point(31, 37);
            this.rnorm.Name = "rnorm";
            this.rnorm.Size = new System.Drawing.Size(58, 17);
            this.rnorm.TabIndex = 0;
            this.rnorm.TabStop = true;
            this.rnorm.Text = "Normal";
            this.rnorm.UseVisualStyleBackColor = true;
            // 
            // grdatos
            // 
            this.grdatos.Controls.Add(this.dtcaducidad);
            this.grdatos.Controls.Add(this.tpeso);
            this.grdatos.Controls.Add(this.tlote);
            this.grdatos.Controls.Add(this.tfabri);
            this.grdatos.Controls.Add(this.tmarca);
            this.grdatos.Controls.Add(this.label5);
            this.grdatos.Controls.Add(this.label4);
            this.grdatos.Controls.Add(this.label3);
            this.grdatos.Controls.Add(this.label2);
            this.grdatos.Controls.Add(this.Marca);
            this.grdatos.Location = new System.Drawing.Point(221, 24);
            this.grdatos.Name = "grdatos";
            this.grdatos.Size = new System.Drawing.Size(368, 221);
            this.grdatos.TabIndex = 1;
            this.grdatos.TabStop = false;
            this.grdatos.Text = "Datos";
            // 
            // dtcaducidad
            // 
            this.dtcaducidad.Location = new System.Drawing.Point(103, 173);
            this.dtcaducidad.Name = "dtcaducidad";
            this.dtcaducidad.Size = new System.Drawing.Size(200, 20);
            this.dtcaducidad.TabIndex = 9;
            // 
            // tpeso
            // 
            this.tpeso.Location = new System.Drawing.Point(102, 135);
            this.tpeso.Name = "tpeso";
            this.tpeso.Size = new System.Drawing.Size(201, 20);
            this.tpeso.TabIndex = 8;
            // 
            // tlote
            // 
            this.tlote.Location = new System.Drawing.Point(102, 103);
            this.tlote.Name = "tlote";
            this.tlote.Size = new System.Drawing.Size(201, 20);
            this.tlote.TabIndex = 7;
            // 
            // tfabri
            // 
            this.tfabri.Location = new System.Drawing.Point(102, 70);
            this.tfabri.Name = "tfabri";
            this.tfabri.Size = new System.Drawing.Size(201, 20);
            this.tfabri.TabIndex = 6;
            // 
            // tmarca
            // 
            this.tmarca.Location = new System.Drawing.Point(102, 36);
            this.tmarca.Name = "tmarca";
            this.tmarca.Size = new System.Drawing.Size(201, 20);
            this.tmarca.TabIndex = 5;
            this.tmarca.TextChanged += new System.EventHandler(this.tmarca_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Caducidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabricante";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(16, 37);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(37, 13);
            this.Marca.TabIndex = 0;
            this.Marca.Text = "Marca";
            // 
            // grorign
            // 
            this.grorign.Controls.Add(this.tproceden);
            this.grorign.Controls.Add(this.tdeno);
            this.grorign.Controls.Add(this.label6);
            this.grorign.Controls.Add(this.label1);
            this.grorign.Location = new System.Drawing.Point(221, 260);
            this.grorign.Name = "grorign";
            this.grorign.Size = new System.Drawing.Size(368, 134);
            this.grorign.TabIndex = 2;
            this.grorign.TabStop = false;
            this.grorign.Text = " ";
            // 
            // tproceden
            // 
            this.tproceden.Location = new System.Drawing.Point(144, 86);
            this.tproceden.Name = "tproceden";
            this.tproceden.Size = new System.Drawing.Size(191, 20);
            this.tproceden.TabIndex = 11;
            // 
            // tdeno
            // 
            this.tdeno.Location = new System.Drawing.Point(144, 31);
            this.tdeno.Name = "tdeno";
            this.tdeno.Size = new System.Drawing.Size(191, 20);
            this.tdeno.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Procedencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denominación Origen";
            // 
            // bttacept
            // 
            this.bttacept.Location = new System.Drawing.Point(243, 414);
            this.bttacept.Name = "bttacept";
            this.bttacept.Size = new System.Drawing.Size(95, 30);
            this.bttacept.TabIndex = 3;
            this.bttacept.Text = "Aceptar";
            this.bttacept.UseVisualStyleBackColor = true;
            this.bttacept.Click += new System.EventHandler(this.bttacept_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 456);
            this.Controls.Add(this.bttacept);
            this.Controls.Add(this.grorign);
            this.Controls.Add(this.grdatos);
            this.Controls.Add(this.grqueso);
            this.Name = "Form1";
            this.Text = "Alta de quesos";
            this.grqueso.ResumeLayout(false);
            this.grqueso.PerformLayout();
            this.grdatos.ResumeLayout(false);
            this.grdatos.PerformLayout();
            this.grorign.ResumeLayout(false);
            this.grorign.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grqueso;
        private System.Windows.Forms.GroupBox grdatos;
        private System.Windows.Forms.GroupBox grorign;
        private System.Windows.Forms.RadioButton rimport;
        private System.Windows.Forms.RadioButton rart;
        private System.Windows.Forms.RadioButton rnorm;
        private System.Windows.Forms.TextBox tpeso;
        private System.Windows.Forms.TextBox tlote;
        private System.Windows.Forms.TextBox tfabri;
        private System.Windows.Forms.TextBox tmarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tproceden;
        private System.Windows.Forms.TextBox tdeno;
        private System.Windows.Forms.Button bttacept;
        private System.Windows.Forms.DateTimePicker dtcaducidad;
    }
}

