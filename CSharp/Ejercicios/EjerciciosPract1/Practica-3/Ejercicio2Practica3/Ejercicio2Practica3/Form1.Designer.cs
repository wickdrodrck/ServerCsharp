namespace Ejercicio2Practica3
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
            this.grfigura = new System.Windows.Forms.GroupBox();
            this.requilat = new System.Windows.Forms.RadioButton();
            this.circunferen = new System.Windows.Forms.RadioButton();
            this.rrectangulo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tlado = new System.Windows.Forms.TextBox();
            this.tradio = new System.Windows.Forms.TextBox();
            this.tancho = new System.Windows.Forms.TextBox();
            this.tlargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calcarea = new System.Windows.Forms.Button();
            this.calcperim = new System.Windows.Forms.Button();
            this.sal = new System.Windows.Forms.Button();
            this.listanorm = new System.Windows.Forms.ListBox();
            this.listaesta = new System.Windows.Forms.ListBox();
            this.grfigura.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grfigura
            // 
            this.grfigura.Controls.Add(this.requilat);
            this.grfigura.Controls.Add(this.circunferen);
            this.grfigura.Controls.Add(this.rrectangulo);
            this.grfigura.Location = new System.Drawing.Point(44, 36);
            this.grfigura.Name = "grfigura";
            this.grfigura.Size = new System.Drawing.Size(181, 145);
            this.grfigura.TabIndex = 0;
            this.grfigura.TabStop = false;
            this.grfigura.Text = "Tipo de figura";
            // 
            // requilat
            // 
            this.requilat.AutoSize = true;
            this.requilat.Location = new System.Drawing.Point(22, 106);
            this.requilat.Name = "requilat";
            this.requilat.Size = new System.Drawing.Size(118, 17);
            this.requilat.TabIndex = 2;
            this.requilat.TabStop = true;
            this.requilat.Text = "Triángulo equilátero";
            this.requilat.UseVisualStyleBackColor = true;
            this.requilat.CheckedChanged += new System.EventHandler(this.requilat_CheckedChanged);
            // 
            // circunferen
            // 
            this.circunferen.AutoSize = true;
            this.circunferen.Location = new System.Drawing.Point(22, 70);
            this.circunferen.Name = "circunferen";
            this.circunferen.Size = new System.Drawing.Size(93, 17);
            this.circunferen.TabIndex = 1;
            this.circunferen.TabStop = true;
            this.circunferen.Text = "Circunferencia";
            this.circunferen.UseVisualStyleBackColor = true;
            this.circunferen.CheckedChanged += new System.EventHandler(this.circunferen_CheckedChanged);
            this.circunferen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.circunferen_MouseClick);
            // 
            // rrectangulo
            // 
            this.rrectangulo.AutoSize = true;
            this.rrectangulo.Location = new System.Drawing.Point(22, 37);
            this.rrectangulo.Name = "rrectangulo";
            this.rrectangulo.Size = new System.Drawing.Size(80, 17);
            this.rrectangulo.TabIndex = 0;
            this.rrectangulo.TabStop = true;
            this.rrectangulo.Text = "Rectángulo";
            this.rrectangulo.UseVisualStyleBackColor = true;
            this.rrectangulo.CheckedChanged += new System.EventHandler(this.rrectangulo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tlado);
            this.groupBox2.Controls.Add(this.tradio);
            this.groupBox2.Controls.Add(this.tancho);
            this.groupBox2.Controls.Add(this.tlargo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(44, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la figura";
            // 
            // tlado
            // 
            this.tlado.Enabled = false;
            this.tlado.Location = new System.Drawing.Point(63, 123);
            this.tlado.Name = "tlado";
            this.tlado.Size = new System.Drawing.Size(53, 20);
            this.tlado.TabIndex = 7;
            // 
            // tradio
            // 
            this.tradio.Enabled = false;
            this.tradio.Location = new System.Drawing.Point(63, 90);
            this.tradio.Name = "tradio";
            this.tradio.Size = new System.Drawing.Size(53, 20);
            this.tradio.TabIndex = 6;
            // 
            // tancho
            // 
            this.tancho.Location = new System.Drawing.Point(63, 59);
            this.tancho.Name = "tancho";
            this.tancho.Size = new System.Drawing.Size(53, 20);
            this.tancho.TabIndex = 5;
            // 
            // tlargo
            // 
            this.tlargo.Location = new System.Drawing.Point(63, 28);
            this.tlargo.Name = "tlargo";
            this.tlargo.Size = new System.Drawing.Size(53, 20);
            this.tlargo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Radio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ancho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Largo";
            // 
            // calcarea
            // 
            this.calcarea.Location = new System.Drawing.Point(293, 70);
            this.calcarea.Name = "calcarea";
            this.calcarea.Size = new System.Drawing.Size(75, 53);
            this.calcarea.TabIndex = 2;
            this.calcarea.Text = "Calcular Área";
            this.calcarea.UseVisualStyleBackColor = true;
            this.calcarea.Click += new System.EventHandler(this.calcarea_Click);
            // 
            // calcperim
            // 
            this.calcperim.Location = new System.Drawing.Point(293, 178);
            this.calcperim.Name = "calcperim";
            this.calcperim.Size = new System.Drawing.Size(75, 51);
            this.calcperim.TabIndex = 3;
            this.calcperim.Text = "Calcular Perímetro";
            this.calcperim.UseVisualStyleBackColor = true;
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(293, 293);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(75, 55);
            this.sal.TabIndex = 4;
            this.sal.Text = "Salir";
            this.sal.UseVisualStyleBackColor = true;
            // 
            // listanorm
            // 
            this.listanorm.FormattingEnabled = true;
            this.listanorm.Location = new System.Drawing.Point(44, 421);
            this.listanorm.Name = "listanorm";
            this.listanorm.Size = new System.Drawing.Size(120, 199);
            this.listanorm.TabIndex = 5;
            // 
            // listaesta
            // 
            this.listaesta.FormattingEnabled = true;
            this.listaesta.Location = new System.Drawing.Point(248, 421);
            this.listaesta.Name = "listaesta";
            this.listaesta.Size = new System.Drawing.Size(120, 199);
            this.listaesta.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 646);
            this.Controls.Add(this.listaesta);
            this.Controls.Add(this.listanorm);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.calcperim);
            this.Controls.Add(this.calcarea);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grfigura);
            this.Name = "Form1";
            this.Text = "CalcularFormas";
            this.grfigura.ResumeLayout(false);
            this.grfigura.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grfigura;
        private System.Windows.Forms.RadioButton requilat;
        private System.Windows.Forms.RadioButton circunferen;
        private System.Windows.Forms.RadioButton rrectangulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button calcarea;
        private System.Windows.Forms.Button calcperim;
        private System.Windows.Forms.Button sal;
        private System.Windows.Forms.TextBox tlado;
        private System.Windows.Forms.TextBox tradio;
        private System.Windows.Forms.TextBox tancho;
        private System.Windows.Forms.TextBox tlargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listanorm;
        private System.Windows.Forms.ListBox listaesta;
    }
}

