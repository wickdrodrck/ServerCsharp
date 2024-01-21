namespace EjerciciosPractica1
{
    partial class Form1
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
            this.Salario = new System.Windows.Forms.TextBox();
            this.Horas = new System.Windows.Forms.TextBox();
            this.Salida = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Salario
            // 
            this.Salario.Location = new System.Drawing.Point(116, 75);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(299, 20);
            this.Salario.TabIndex = 0;
            // 
            // Horas
            // 
            this.Horas.Location = new System.Drawing.Point(116, 157);
            this.Horas.Name = "Horas";
            this.Horas.Size = new System.Drawing.Size(299, 20);
            this.Horas.TabIndex = 1;
            // 
            // Salida
            // 
            this.Salida.Location = new System.Drawing.Point(116, 231);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(299, 20);
            this.Salida.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(224, 318);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "Enviar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.Horas);
            this.Controls.Add(this.Salario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Salario;
        private System.Windows.Forms.TextBox Horas;
        private System.Windows.Forms.TextBox Salida;
        private System.Windows.Forms.Button btn;
    }
}