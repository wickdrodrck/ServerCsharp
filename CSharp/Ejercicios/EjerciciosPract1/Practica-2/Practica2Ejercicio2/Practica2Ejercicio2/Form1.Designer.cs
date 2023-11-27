namespace Practica2Ejercicio2
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
            this.Paislst = new System.Windows.Forms.ListBox();
            this.letrP = new System.Windows.Forms.ListBox();
            this.paisbox = new System.Windows.Forms.TextBox();
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.gr2 = new System.Windows.Forms.GroupBox();
            this.salud = new System.Windows.Forms.TextBox();
            this.letrbox = new System.Windows.Forms.TextBox();
            this.busc = new System.Windows.Forms.Button();
            this.intrP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gr1.SuspendLayout();
            this.gr2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paislst
            // 
            this.Paislst.FormattingEnabled = true;
            this.Paislst.Location = new System.Drawing.Point(31, 44);
            this.Paislst.Name = "Paislst";
            this.Paislst.Size = new System.Drawing.Size(120, 277);
            this.Paislst.TabIndex = 0;
            this.Paislst.SelectedIndexChanged += new System.EventHandler(this.Pais_SelectedIndexChanged);
            // 
            // letrP
            // 
            this.letrP.FormattingEnabled = true;
            this.letrP.Location = new System.Drawing.Point(506, 44);
            this.letrP.Name = "letrP";
            this.letrP.Size = new System.Drawing.Size(120, 277);
            this.letrP.TabIndex = 1;
            this.letrP.SelectedIndexChanged += new System.EventHandler(this.letrP_SelectedIndexChanged);
            // 
            // paisbox
            // 
            this.paisbox.Location = new System.Drawing.Point(79, 19);
            this.paisbox.Name = "paisbox";
            this.paisbox.Size = new System.Drawing.Size(100, 20);
            this.paisbox.TabIndex = 2;
            // 
            // gr1
            // 
            this.gr1.Controls.Add(this.label2);
            this.gr1.Controls.Add(this.label1);
            this.gr1.Controls.Add(this.salud);
            this.gr1.Controls.Add(this.paisbox);
            this.gr1.Location = new System.Drawing.Point(232, 61);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(200, 100);
            this.gr1.TabIndex = 3;
            this.gr1.TabStop = false;
            this.gr1.Text = "País";
            // 
            // gr2
            // 
            this.gr2.Controls.Add(this.label3);
            this.gr2.Controls.Add(this.busc);
            this.gr2.Controls.Add(this.letrbox);
            this.gr2.Location = new System.Drawing.Point(232, 249);
            this.gr2.Name = "gr2";
            this.gr2.Size = new System.Drawing.Size(200, 100);
            this.gr2.TabIndex = 4;
            this.gr2.TabStop = false;
            this.gr2.Text = "Buscar";
            // 
            // salud
            // 
            this.salud.Location = new System.Drawing.Point(94, 60);
            this.salud.Name = "salud";
            this.salud.Size = new System.Drawing.Size(84, 20);
            this.salud.TabIndex = 3;
            // 
            // letrbox
            // 
            this.letrbox.Location = new System.Drawing.Point(61, 42);
            this.letrbox.Name = "letrbox";
            this.letrbox.Size = new System.Drawing.Size(35, 20);
            this.letrbox.TabIndex = 4;
            // 
            // busc
            // 
            this.busc.Location = new System.Drawing.Point(122, 32);
            this.busc.Name = "busc";
            this.busc.Size = new System.Drawing.Size(57, 40);
            this.busc.TabIndex = 5;
            this.busc.Text = "Buscar";
            this.busc.UseVisualStyleBackColor = true;
            this.busc.Click += new System.EventHandler(this.busc_Click);
            // 
            // intrP
            // 
            this.intrP.Location = new System.Drawing.Point(31, 352);
            this.intrP.Name = "intrP";
            this.intrP.Size = new System.Drawing.Size(120, 40);
            this.intrP.TabIndex = 6;
            this.intrP.Text = "Introducir País";
            this.intrP.UseVisualStyleBackColor = true;
            this.intrP.Click += new System.EventHandler(this.intrP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "País:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saludo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Letra:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 416);
            this.Controls.Add(this.intrP);
            this.Controls.Add(this.gr2);
            this.Controls.Add(this.gr1);
            this.Controls.Add(this.letrP);
            this.Controls.Add(this.Paislst);
            this.Name = "Form1";
            this.Text = "Bienvenida Internacional";
            this.gr1.ResumeLayout(false);
            this.gr1.PerformLayout();
            this.gr2.ResumeLayout(false);
            this.gr2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Paislst;
        private System.Windows.Forms.ListBox letrP;
        private System.Windows.Forms.TextBox paisbox;
        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.TextBox salud;
        private System.Windows.Forms.GroupBox gr2;
        private System.Windows.Forms.Button busc;
        private System.Windows.Forms.TextBox letrbox;
        private System.Windows.Forms.Button intrP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

