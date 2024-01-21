namespace Practica2Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.ape = new System.Windows.Forms.TextBox();
            this.eda = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.salid = new System.Windows.Forms.TextBox();
            this.intro = new System.Windows.Forms.Button();
            this.visu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(120, 73);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 4;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // ape
            // 
            this.ape.Location = new System.Drawing.Point(120, 123);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(100, 20);
            this.ape.TabIndex = 5;
            this.ape.TextChanged += new System.EventHandler(this.ape_TextChanged);
            // 
            // eda
            // 
            this.eda.Location = new System.Drawing.Point(120, 173);
            this.eda.Name = "eda";
            this.eda.Size = new System.Drawing.Size(100, 20);
            this.eda.TabIndex = 6;
            this.eda.TextChanged += new System.EventHandler(this.eda_TextChanged);
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(120, 225);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 7;
            this.dni.TextChanged += new System.EventHandler(this.dni_TextChanged);
            // 
            // salid
            // 
            this.salid.Location = new System.Drawing.Point(102, 367);
            this.salid.Name = "salid";
            this.salid.Size = new System.Drawing.Size(137, 20);
            this.salid.TabIndex = 8;
            this.salid.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // intro
            // 
            this.intro.Location = new System.Drawing.Point(49, 293);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(75, 23);
            this.intro.TabIndex = 9;
            this.intro.Text = "Introducir";
            this.intro.UseVisualStyleBackColor = true;
            this.intro.Click += new System.EventHandler(this.intro_Click);
            // 
            // visu
            // 
            this.visu.Location = new System.Drawing.Point(209, 293);
            this.visu.Name = "visu";
            this.visu.Size = new System.Drawing.Size(75, 23);
            this.visu.TabIndex = 10;
            this.visu.Text = "Visualizar";
            this.visu.UseVisualStyleBackColor = true;
            this.visu.Click += new System.EventHandler(this.visu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 434);
            this.Controls.Add(this.visu);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.salid);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.eda);
            this.Controls.Add(this.ape);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox ape;
        private System.Windows.Forms.TextBox eda;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox salid;
        private System.Windows.Forms.Button intro;
        private System.Windows.Forms.Button visu;
    }
}

