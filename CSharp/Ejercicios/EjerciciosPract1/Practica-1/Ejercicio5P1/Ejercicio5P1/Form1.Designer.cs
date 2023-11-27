namespace Ejercicio5P1
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
            this.euro = new System.Windows.Forms.TextBox();
            this.peseta = new System.Windows.Forms.TextBox();
            this.eur = new System.Windows.Forms.Label();
            this.peset = new System.Windows.Forms.Label();
            this.cnvt = new System.Windows.Forms.Button();
            this.limp = new System.Windows.Forms.Button();
            this.salidaerr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // euro
            // 
            this.euro.Location = new System.Drawing.Point(138, 79);
            this.euro.Name = "euro";
            this.euro.Size = new System.Drawing.Size(120, 20);
            this.euro.TabIndex = 0;
            // 
            // peseta
            // 
            this.peseta.Location = new System.Drawing.Point(138, 142);
            this.peseta.Name = "peseta";
            this.peseta.Size = new System.Drawing.Size(120, 20);
            this.peseta.TabIndex = 1;
            // 
            // eur
            // 
            this.eur.AutoSize = true;
            this.eur.Location = new System.Drawing.Point(58, 82);
            this.eur.Name = "eur";
            this.eur.Size = new System.Drawing.Size(37, 13);
            this.eur.TabIndex = 2;
            this.eur.Text = "Euros:";
            // 
            // peset
            // 
            this.peset.AutoSize = true;
            this.peset.Location = new System.Drawing.Point(47, 145);
            this.peset.Name = "peset";
            this.peset.Size = new System.Drawing.Size(48, 13);
            this.peset.TabIndex = 3;
            this.peset.Text = "Pesetas:";
            // 
            // cnvt
            // 
            this.cnvt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cnvt.Location = new System.Drawing.Point(296, 106);
            this.cnvt.Name = "cnvt";
            this.cnvt.Size = new System.Drawing.Size(90, 29);
            this.cnvt.TabIndex = 4;
            this.cnvt.Text = "Convertir";
            this.cnvt.UseVisualStyleBackColor = false;
            this.cnvt.Click += new System.EventHandler(this.cnvt_Click);
            // 
            // limp
            // 
            this.limp.Location = new System.Drawing.Point(165, 230);
            this.limp.Name = "limp";
            this.limp.Size = new System.Drawing.Size(74, 22);
            this.limp.TabIndex = 5;
            this.limp.Text = "Limpiar";
            this.limp.UseVisualStyleBackColor = true;
            this.limp.Click += new System.EventHandler(this.limp_Click);
            // 
            // salidaerr
            // 
            this.salidaerr.AutoSize = true;
            this.salidaerr.Location = new System.Drawing.Point(50, 193);
            this.salidaerr.Name = "salidaerr";
            this.salidaerr.Size = new System.Drawing.Size(10, 13);
            this.salidaerr.TabIndex = 6;
            this.salidaerr.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 264);
            this.Controls.Add(this.salidaerr);
            this.Controls.Add(this.limp);
            this.Controls.Add(this.cnvt);
            this.Controls.Add(this.peset);
            this.Controls.Add(this.eur);
            this.Controls.Add(this.peseta);
            this.Controls.Add(this.euro);
            this.Name = "Form1";
            this.Text = "Convertidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox euro;
        private System.Windows.Forms.TextBox peseta;
        private System.Windows.Forms.Label eur;
        private System.Windows.Forms.Label peset;
        private System.Windows.Forms.Button cnvt;
        private System.Windows.Forms.Button limp;
        private System.Windows.Forms.Label salidaerr;
    }
}

