namespace Ejercicio2P1
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
            this.ganar1 = new System.Windows.Forms.TextBox();
            this.empate1 = new System.Windows.Forms.TextBox();
            this.groupeq1 = new System.Windows.Forms.GroupBox();
            this.eti1 = new System.Windows.Forms.Label();
            this.eti2 = new System.Windows.Forms.Label();
            this.groupeq2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ganar2 = new System.Windows.Forms.TextBox();
            this.empate2 = new System.Windows.Forms.TextBox();
            this.btt1 = new System.Windows.Forms.Button();
            this.equi1 = new System.Windows.Forms.Label();
            this.equi2 = new System.Windows.Forms.Label();
            this.pnt1 = new System.Windows.Forms.TextBox();
            this.pnt2 = new System.Windows.Forms.TextBox();
            this.groupeq1.SuspendLayout();
            this.groupeq2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ganar1
            // 
            this.ganar1.Location = new System.Drawing.Point(140, 39);
            this.ganar1.Name = "ganar1";
            this.ganar1.Size = new System.Drawing.Size(100, 20);
            this.ganar1.TabIndex = 0;
            // 
            // empate1
            // 
            this.empate1.Location = new System.Drawing.Point(140, 80);
            this.empate1.Name = "empate1";
            this.empate1.Size = new System.Drawing.Size(100, 20);
            this.empate1.TabIndex = 1;
            // 
            // groupeq1
            // 
            this.groupeq1.Controls.Add(this.eti2);
            this.groupeq1.Controls.Add(this.eti1);
            this.groupeq1.Controls.Add(this.ganar1);
            this.groupeq1.Controls.Add(this.empate1);
            this.groupeq1.Location = new System.Drawing.Point(66, 51);
            this.groupeq1.Name = "groupeq1";
            this.groupeq1.Size = new System.Drawing.Size(262, 169);
            this.groupeq1.TabIndex = 2;
            this.groupeq1.TabStop = false;
            this.groupeq1.Text = "Equipo1";
            this.groupeq1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // eti1
            // 
            this.eti1.AutoSize = true;
            this.eti1.Location = new System.Drawing.Point(21, 42);
            this.eti1.Name = "eti1";
            this.eti1.Size = new System.Drawing.Size(92, 13);
            this.eti1.TabIndex = 2;
            this.eti1.Text = "Partidos ganados:";
            this.eti1.Click += new System.EventHandler(this.label2_Click);
            // 
            // eti2
            // 
            this.eti2.AutoSize = true;
            this.eti2.Location = new System.Drawing.Point(21, 83);
            this.eti2.Name = "eti2";
            this.eti2.Size = new System.Drawing.Size(103, 13);
            this.eti2.TabIndex = 3;
            this.eti2.Text = "Partidos empatados:";
            // 
            // groupeq2
            // 
            this.groupeq2.Controls.Add(this.label1);
            this.groupeq2.Controls.Add(this.label2);
            this.groupeq2.Controls.Add(this.ganar2);
            this.groupeq2.Controls.Add(this.empate2);
            this.groupeq2.Location = new System.Drawing.Point(470, 51);
            this.groupeq2.Name = "groupeq2";
            this.groupeq2.Size = new System.Drawing.Size(262, 169);
            this.groupeq2.TabIndex = 4;
            this.groupeq2.TabStop = false;
            this.groupeq2.Text = "Equipo2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Partidos empatados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Partidos ganados:";
            // 
            // ganar2
            // 
            this.ganar2.Location = new System.Drawing.Point(140, 39);
            this.ganar2.Name = "ganar2";
            this.ganar2.Size = new System.Drawing.Size(100, 20);
            this.ganar2.TabIndex = 0;
            // 
            // empate2
            // 
            this.empate2.Location = new System.Drawing.Point(140, 80);
            this.empate2.Name = "empate2";
            this.empate2.Size = new System.Drawing.Size(100, 20);
            this.empate2.TabIndex = 1;
            // 
            // btt1
            // 
            this.btt1.Location = new System.Drawing.Point(675, 393);
            this.btt1.Name = "btt1";
            this.btt1.Size = new System.Drawing.Size(95, 36);
            this.btt1.TabIndex = 5;
            this.btt1.Text = "Enviar";
            this.btt1.UseVisualStyleBackColor = true;
            this.btt1.Click += new System.EventHandler(this.btt1_Click);
            // 
            // equi1
            // 
            this.equi1.AutoSize = true;
            this.equi1.Location = new System.Drawing.Point(66, 310);
            this.equi1.Name = "equi1";
            this.equi1.Size = new System.Drawing.Size(10, 13);
            this.equi1.TabIndex = 6;
            this.equi1.Text = " ";
            this.equi1.Click += new System.EventHandler(this.equi1_Click);
            // 
            // equi2
            // 
            this.equi2.AutoSize = true;
            this.equi2.Location = new System.Drawing.Point(66, 350);
            this.equi2.Name = "equi2";
            this.equi2.Size = new System.Drawing.Size(10, 13);
            this.equi2.TabIndex = 7;
            this.equi2.Text = " ";
            // 
            // pnt1
            // 
            this.pnt1.Location = new System.Drawing.Point(354, 307);
            this.pnt1.Name = "pnt1";
            this.pnt1.Size = new System.Drawing.Size(100, 20);
            this.pnt1.TabIndex = 8;
            // 
            // pnt2
            // 
            this.pnt2.Location = new System.Drawing.Point(354, 350);
            this.pnt2.Name = "pnt2";
            this.pnt2.Size = new System.Drawing.Size(100, 20);
            this.pnt2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnt2);
            this.Controls.Add(this.pnt1);
            this.Controls.Add(this.equi2);
            this.Controls.Add(this.equi1);
            this.Controls.Add(this.btt1);
            this.Controls.Add(this.groupeq2);
            this.Controls.Add(this.groupeq1);
            this.Name = "Form1";
            this.Text = "Torneo";
            this.groupeq1.ResumeLayout(false);
            this.groupeq1.PerformLayout();
            this.groupeq2.ResumeLayout(false);
            this.groupeq2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ganar1;
        private System.Windows.Forms.TextBox empate1;
        private System.Windows.Forms.GroupBox groupeq1;
        private System.Windows.Forms.Label eti2;
        private System.Windows.Forms.Label eti1;
        private System.Windows.Forms.GroupBox groupeq2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ganar2;
        private System.Windows.Forms.TextBox empate2;
        private System.Windows.Forms.Button btt1;
        private System.Windows.Forms.Label equi1;
        private System.Windows.Forms.Label equi2;
        private System.Windows.Forms.TextBox pnt1;
        private System.Windows.Forms.TextBox pnt2;
    }
}

