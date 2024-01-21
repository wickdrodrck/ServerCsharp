namespace Ejercicio6P1
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
            this.acer = new System.Windows.Forms.TextBox();
            this.blan = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.TextBox();
            this.ptotal = new System.Windows.Forms.TextBox();
            this.env = new System.Windows.Forms.Button();
            this.limp = new System.Windows.Forms.Button();
            this.Acertadas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pexamen = new System.Windows.Forms.TextBox();
            this.salid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acer
            // 
            this.acer.Location = new System.Drawing.Point(183, 77);
            this.acer.Name = "acer";
            this.acer.Size = new System.Drawing.Size(100, 20);
            this.acer.TabIndex = 0;
            // 
            // blan
            // 
            this.blan.Location = new System.Drawing.Point(183, 120);
            this.blan.Name = "blan";
            this.blan.Size = new System.Drawing.Size(100, 20);
            this.blan.TabIndex = 1;
            // 
            // err
            // 
            this.err.Location = new System.Drawing.Point(183, 163);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(100, 20);
            this.err.TabIndex = 2;
            // 
            // ptotal
            // 
            this.ptotal.Location = new System.Drawing.Point(183, 248);
            this.ptotal.Name = "ptotal";
            this.ptotal.Size = new System.Drawing.Size(100, 20);
            this.ptotal.TabIndex = 3;
            // 
            // env
            // 
            this.env.Location = new System.Drawing.Point(196, 292);
            this.env.Name = "env";
            this.env.Size = new System.Drawing.Size(75, 23);
            this.env.TabIndex = 4;
            this.env.Text = "Enviar";
            this.env.UseVisualStyleBackColor = true;
            this.env.Click += new System.EventHandler(this.button1_Click);
            // 
            // limp
            // 
            this.limp.Location = new System.Drawing.Point(343, 370);
            this.limp.Name = "limp";
            this.limp.Size = new System.Drawing.Size(75, 23);
            this.limp.TabIndex = 5;
            this.limp.Text = "Limpiar";
            this.limp.UseVisualStyleBackColor = true;
            this.limp.Click += new System.EventHandler(this.limp_Click);
            // 
            // Acertadas
            // 
            this.Acertadas.AutoSize = true;
            this.Acertadas.Location = new System.Drawing.Point(81, 80);
            this.Acertadas.Name = "Acertadas";
            this.Acertadas.Size = new System.Drawing.Size(55, 13);
            this.Acertadas.TabIndex = 6;
            this.Acertadas.Text = "Acertadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Blanco";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Errores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Punt. Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preguntas examen";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pexamen
            // 
            this.pexamen.Location = new System.Drawing.Point(183, 207);
            this.pexamen.Name = "pexamen";
            this.pexamen.Size = new System.Drawing.Size(100, 20);
            this.pexamen.TabIndex = 10;
            this.pexamen.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // salid
            // 
            this.salid.AutoSize = true;
            this.salid.Location = new System.Drawing.Point(61, 375);
            this.salid.Name = "salid";
            this.salid.Size = new System.Drawing.Size(10, 13);
            this.salid.TabIndex = 12;
            this.salid.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.salid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pexamen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Acertadas);
            this.Controls.Add(this.limp);
            this.Controls.Add(this.env);
            this.Controls.Add(this.ptotal);
            this.Controls.Add(this.err);
            this.Controls.Add(this.blan);
            this.Controls.Add(this.acer);
            this.Name = "Form1";
            this.Text = "CalculoTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox acer;
        private System.Windows.Forms.TextBox blan;
        private System.Windows.Forms.TextBox err;
        private System.Windows.Forms.TextBox ptotal;
        private System.Windows.Forms.Button env;
        private System.Windows.Forms.Button limp;
        private System.Windows.Forms.Label Acertadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pexamen;
        private System.Windows.Forms.Label salid;
    }
}

