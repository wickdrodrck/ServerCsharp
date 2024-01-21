namespace EjerciciosP1Csharp
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
            this.dni1 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.Label();
            this.btt1 = new System.Windows.Forms.Button();
            this.salida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dni1
            // 
            this.dni1.Location = new System.Drawing.Point(186, 79);
            this.dni1.Name = "dni1";
            this.dni1.Size = new System.Drawing.Size(145, 20);
            this.dni1.TabIndex = 0;
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(61, 82);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(91, 13);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "Introduce el DNI: ";
            // 
            // btt1
            // 
            this.btt1.Location = new System.Drawing.Point(301, 304);
            this.btt1.Name = "btt1";
            this.btt1.Size = new System.Drawing.Size(86, 33);
            this.btt1.TabIndex = 2;
            this.btt1.Text = "Enviar";
            this.btt1.UseVisualStyleBackColor = true;
            this.btt1.Click += new System.EventHandler(this.btt1_Click);
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Location = new System.Drawing.Point(61, 177);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(10, 13);
            this.salida.TabIndex = 3;
            this.salida.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 349);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.btt1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.dni1);
            this.Name = "Form1";
            this.Text = "DNI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dni1;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Button btt1;
        private System.Windows.Forms.Label salida;
    }
}

