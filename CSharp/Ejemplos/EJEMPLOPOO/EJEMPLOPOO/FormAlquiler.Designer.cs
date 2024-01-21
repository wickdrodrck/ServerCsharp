namespace EJEMPLOPOO
{
    partial class FormAlquiler
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtkilometraje = new System.Windows.Forms.TextBox();
            this.txtautonomia = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.Datos_Vehiculo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMoto = new System.Windows.Forms.RadioButton();
            this.radioPatinete = new System.Windows.Forms.RadioButton();
            this.radiocoche = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttnuevo = new System.Windows.Forms.Button();
            this.listavehicul = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtnruedas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Datos_Vehiculo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matrícula";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kilometraje";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autonomía";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marca";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Modelo";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(110, 32);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 20);
            this.txtmatricula.TabIndex = 7;
            // 
            // txtkilometraje
            // 
            this.txtkilometraje.Location = new System.Drawing.Point(110, 80);
            this.txtkilometraje.Name = "txtkilometraje";
            this.txtkilometraje.Size = new System.Drawing.Size(100, 20);
            this.txtkilometraje.TabIndex = 8;
            this.txtkilometraje.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtautonomia
            // 
            this.txtautonomia.Location = new System.Drawing.Point(110, 136);
            this.txtautonomia.Name = "txtautonomia";
            this.txtautonomia.Size = new System.Drawing.Size(100, 20);
            this.txtautonomia.TabIndex = 9;
            this.txtautonomia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(110, 195);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 20);
            this.txtmarca.TabIndex = 10;
            this.txtmarca.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(85, 42);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(100, 20);
            this.txtmodelo.TabIndex = 11;
            // 
            // Datos_Vehiculo
            // 
            this.Datos_Vehiculo.Controls.Add(this.txtmatricula);
            this.Datos_Vehiculo.Controls.Add(this.txtkilometraje);
            this.Datos_Vehiculo.Controls.Add(this.txtautonomia);
            this.Datos_Vehiculo.Controls.Add(this.txtmarca);
            this.Datos_Vehiculo.Controls.Add(this.label2);
            this.Datos_Vehiculo.Controls.Add(this.label5);
            this.Datos_Vehiculo.Controls.Add(this.label3);
            this.Datos_Vehiculo.Controls.Add(this.label4);
            this.Datos_Vehiculo.Location = new System.Drawing.Point(24, 27);
            this.Datos_Vehiculo.Name = "Datos_Vehiculo";
            this.Datos_Vehiculo.Size = new System.Drawing.Size(265, 246);
            this.Datos_Vehiculo.TabIndex = 13;
            this.Datos_Vehiculo.TabStop = false;
            this.Datos_Vehiculo.Text = "Datos vehiculo";
            this.Datos_Vehiculo.Enter += new System.EventHandler(this.Datos_Vehiculo_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMoto);
            this.groupBox1.Controls.Add(this.radioPatinete);
            this.groupBox1.Controls.Add(this.radiocoche);
            this.groupBox1.Location = new System.Drawing.Point(378, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Vehiculo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioMoto
            // 
            this.radioMoto.AutoSize = true;
            this.radioMoto.Location = new System.Drawing.Point(19, 75);
            this.radioMoto.Name = "radioMoto";
            this.radioMoto.Size = new System.Drawing.Size(49, 17);
            this.radioMoto.TabIndex = 2;
            this.radioMoto.TabStop = true;
            this.radioMoto.Text = "Moto";
            this.radioMoto.UseVisualStyleBackColor = true;
            this.radioMoto.CheckedChanged += new System.EventHandler(this.radiomoto_CheckedChanged);
            // 
            // radioPatinete
            // 
            this.radioPatinete.AutoSize = true;
            this.radioPatinete.Location = new System.Drawing.Point(19, 52);
            this.radioPatinete.Name = "radioPatinete";
            this.radioPatinete.Size = new System.Drawing.Size(64, 17);
            this.radioPatinete.TabIndex = 1;
            this.radioPatinete.TabStop = true;
            this.radioPatinete.Text = "Patinete";
            this.radioPatinete.UseVisualStyleBackColor = true;
            this.radioPatinete.CheckedChanged += new System.EventHandler(this.radioPatinete_CheckedChanged);
            // 
            // radiocoche
            // 
            this.radiocoche.AutoSize = true;
            this.radiocoche.Location = new System.Drawing.Point(19, 29);
            this.radiocoche.Name = "radiocoche";
            this.radiocoche.Size = new System.Drawing.Size(56, 17);
            this.radiocoche.TabIndex = 0;
            this.radiocoche.TabStop = true;
            this.radiocoche.Text = "Coche";
            this.radiocoche.UseVisualStyleBackColor = true;
            this.radiocoche.CheckedChanged += new System.EventHandler(this.radiocoche_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtmodelo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(24, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 121);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coche";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(85, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Eléctrico";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttnuevo
            // 
            this.buttnuevo.Location = new System.Drawing.Point(386, 415);
            this.buttnuevo.Name = "buttnuevo";
            this.buttnuevo.Size = new System.Drawing.Size(75, 23);
            this.buttnuevo.TabIndex = 16;
            this.buttnuevo.Text = "Enviar";
            this.buttnuevo.UseVisualStyleBackColor = true;
            this.buttnuevo.Click += new System.EventHandler(this.buttnuevo_Click);
            // 
            // listavehicul
            // 
            this.listavehicul.DisplayMember = "Matricula";
            this.listavehicul.FormattingEnabled = true;
            this.listavehicul.Location = new System.Drawing.Point(662, 32);
            this.listavehicul.Name = "listavehicul";
            this.listavehicul.Size = new System.Drawing.Size(150, 316);
            this.listavehicul.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtnruedas);
            this.groupBox3.Location = new System.Drawing.Point(378, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patinete";
            // 
            // txtnruedas
            // 
            this.txtnruedas.Location = new System.Drawing.Point(83, 40);
            this.txtnruedas.Name = "txtnruedas";
            this.txtnruedas.Size = new System.Drawing.Size(100, 20);
            this.txtnruedas.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "N º Ruedas";
            // 
            // FormAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listavehicul);
            this.Controls.Add(this.buttnuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Datos_Vehiculo);
            this.Name = "FormAlquiler";
            this.Text = "OOP";
            this.Load += new System.EventHandler(this.FormAlquiler_Load);
            this.Datos_Vehiculo.ResumeLayout(false);
            this.Datos_Vehiculo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtkilometraje;
        private System.Windows.Forms.TextBox txtautonomia;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.GroupBox Datos_Vehiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMoto;
        private System.Windows.Forms.RadioButton radioPatinete;
        private System.Windows.Forms.RadioButton radiocoche;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttnuevo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listavehicul;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnruedas;
    }
}

