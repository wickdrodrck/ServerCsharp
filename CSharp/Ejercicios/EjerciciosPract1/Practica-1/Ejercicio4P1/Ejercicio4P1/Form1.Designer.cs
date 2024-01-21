namespace Ejercicio4P1
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
            this.g = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.TextBox();
            this.grados = new System.Windows.Forms.Label();
            this.faren = new System.Windows.Forms.Label();
            this.salida = new System.Windows.Forms.Label();
            this.btt1 = new System.Windows.Forms.Button();
            this.btt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // g
            // 
            this.g.Location = new System.Drawing.Point(140, 73);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(111, 20);
            this.g.TabIndex = 0;
            // 
            // f
            // 
            this.f.Location = new System.Drawing.Point(140, 121);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(111, 20);
            this.f.TabIndex = 1;
            // 
            // grados
            // 
            this.grados.AutoSize = true;
            this.grados.Location = new System.Drawing.Point(59, 79);
            this.grados.Name = "grados";
            this.grados.Size = new System.Drawing.Size(18, 13);
            this.grados.TabIndex = 2;
            this.grados.Text = "Cº";
            this.grados.Click += new System.EventHandler(this.label1_Click);
            // 
            // faren
            // 
            this.faren.AutoSize = true;
            this.faren.Location = new System.Drawing.Point(59, 128);
            this.faren.Name = "faren";
            this.faren.Size = new System.Drawing.Size(13, 13);
            this.faren.TabIndex = 3;
            this.faren.Text = "F";
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Location = new System.Drawing.Point(62, 190);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(10, 13);
            this.salida.TabIndex = 4;
            this.salida.Text = " ";
            // 
            // btt1
            // 
            this.btt1.Location = new System.Drawing.Point(49, 259);
            this.btt1.Name = "btt1";
            this.btt1.Size = new System.Drawing.Size(92, 28);
            this.btt1.TabIndex = 5;
            this.btt1.Text = "F a Cº";
            this.btt1.UseVisualStyleBackColor = true;
            this.btt1.Click += new System.EventHandler(this.btt1_Click);
            // 
            // btt2
            // 
            this.btt2.Location = new System.Drawing.Point(254, 259);
            this.btt2.Name = "btt2";
            this.btt2.Size = new System.Drawing.Size(92, 28);
            this.btt2.TabIndex = 6;
            this.btt2.Text = "Cº a F";
            this.btt2.UseVisualStyleBackColor = true;
            this.btt2.Click += new System.EventHandler(this.btt2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 330);
            this.Controls.Add(this.btt2);
            this.Controls.Add(this.btt1);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.faren);
            this.Controls.Add(this.grados);
            this.Controls.Add(this.f);
            this.Controls.Add(this.g);
            this.Name = "Form1";
            this.Text = "Temperatura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox g;
        private System.Windows.Forms.TextBox f;
        private System.Windows.Forms.Label grados;
        private System.Windows.Forms.Label faren;
        private System.Windows.Forms.Label salida;
        private System.Windows.Forms.Button btt1;
        private System.Windows.Forms.Button btt2;
    }
}

