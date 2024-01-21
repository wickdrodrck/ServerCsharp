namespace Ejercicio7Practica1
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
            this.fact1 = new System.Windows.Forms.TextBox();
            this.fact2 = new System.Windows.Forms.TextBox();
            this.resul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sumaa = new System.Windows.Forms.RadioButton();
            this.rest = new System.Windows.Forms.RadioButton();
            this.div = new System.Windows.Forms.RadioButton();
            this.mult = new System.Windows.Forms.RadioButton();
            this.envv = new System.Windows.Forms.Button();
            this.salid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fact1
            // 
            this.fact1.Location = new System.Drawing.Point(69, 85);
            this.fact1.Multiline = true;
            this.fact1.Name = "fact1";
            this.fact1.Size = new System.Drawing.Size(100, 70);
            this.fact1.TabIndex = 0;
            // 
            // fact2
            // 
            this.fact2.Location = new System.Drawing.Point(69, 265);
            this.fact2.Multiline = true;
            this.fact2.Name = "fact2";
            this.fact2.Size = new System.Drawing.Size(100, 70);
            this.fact2.TabIndex = 1;
            // 
            // resul
            // 
            this.resul.Location = new System.Drawing.Point(594, 184);
            this.resul.Multiline = true;
            this.resul.Name = "resul";
            this.resul.Size = new System.Drawing.Size(100, 70);
            this.resul.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Factor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Factor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mult);
            this.groupBox1.Controls.Add(this.div);
            this.groupBox1.Controls.Add(this.rest);
            this.groupBox1.Controls.Add(this.sumaa);
            this.groupBox1.Location = new System.Drawing.Point(290, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones básicas";
            // 
            // sumaa
            // 
            this.sumaa.AutoSize = true;
            this.sumaa.Location = new System.Drawing.Point(42, 42);
            this.sumaa.Name = "sumaa";
            this.sumaa.Size = new System.Drawing.Size(55, 17);
            this.sumaa.TabIndex = 0;
            this.sumaa.TabStop = true;
            this.sumaa.Text = "Sumar";
            this.sumaa.UseVisualStyleBackColor = true;
            // 
            // rest
            // 
            this.rest.AutoSize = true;
            this.rest.Location = new System.Drawing.Point(42, 95);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(56, 17);
            this.rest.TabIndex = 1;
            this.rest.TabStop = true;
            this.rest.Text = "Restar";
            this.rest.UseVisualStyleBackColor = true;
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Location = new System.Drawing.Point(42, 148);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(54, 17);
            this.div.TabIndex = 2;
            this.div.TabStop = true;
            this.div.Text = "Dividir";
            this.div.UseVisualStyleBackColor = true;
            // 
            // mult
            // 
            this.mult.AutoSize = true;
            this.mult.Location = new System.Drawing.Point(42, 204);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(72, 17);
            this.mult.TabIndex = 3;
            this.mult.TabStop = true;
            this.mult.Text = "Multiplicar";
            this.mult.UseVisualStyleBackColor = true;
            // 
            // envv
            // 
            this.envv.Location = new System.Drawing.Point(332, 402);
            this.envv.Name = "envv";
            this.envv.Size = new System.Drawing.Size(107, 36);
            this.envv.TabIndex = 7;
            this.envv.Text = "Enviar";
            this.envv.UseVisualStyleBackColor = true;
            this.envv.Click += new System.EventHandler(this.envv_Click);
            // 
            // salid
            // 
            this.salid.AutoSize = true;
            this.salid.Location = new System.Drawing.Point(639, 392);
            this.salid.Name = "salid";
            this.salid.Size = new System.Drawing.Size(10, 13);
            this.salid.TabIndex = 8;
            this.salid.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salid);
            this.Controls.Add(this.envv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resul);
            this.Controls.Add(this.fact2);
            this.Controls.Add(this.fact1);
            this.Name = "Form1";
            this.Text = "Operaciones básicas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fact1;
        private System.Windows.Forms.TextBox fact2;
        private System.Windows.Forms.TextBox resul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton div;
        private System.Windows.Forms.RadioButton rest;
        private System.Windows.Forms.RadioButton sumaa;
        private System.Windows.Forms.RadioButton mult;
        private System.Windows.Forms.Button envv;
        private System.Windows.Forms.Label salid;
    }
}

