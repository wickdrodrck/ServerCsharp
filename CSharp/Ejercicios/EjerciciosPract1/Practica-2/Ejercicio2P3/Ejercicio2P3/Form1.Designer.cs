namespace Ejercicio2P3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttserv = new System.Windows.Forms.Button();
            this.bttnew = new System.Windows.Forms.Button();
            this.lstpedid = new System.Windows.Forms.ListBox();
            this.lstpend = new System.Windows.Forms.ListBox();
            this.grmasa = new System.Windows.Forms.GroupBox();
            this.rgrues = new System.Windows.Forms.RadioButton();
            this.rfina = new System.Windows.Forms.RadioButton();
            this.rnorm = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ensacombo = new System.Windows.Forms.ComboBox();
            this.grrefresc = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rmedi = new System.Windows.Forms.RadioButton();
            this.gringr = new System.Windows.Forms.GroupBox();
            this.ingr4 = new System.Windows.Forms.CheckBox();
            this.ingr2 = new System.Windows.Forms.CheckBox();
            this.ingr3 = new System.Windows.Forms.CheckBox();
            this.ingr1 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nmesas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grmasa.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grrefresc.SuspendLayout();
            this.gringr.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bttserv);
            this.groupBox1.Controls.Add(this.bttnew);
            this.groupBox1.Controls.Add(this.lstpedid);
            this.groupBox1.Controls.Add(this.lstpend);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pendientes servir";
            // 
            // bttserv
            // 
            this.bttserv.Location = new System.Drawing.Point(169, 251);
            this.bttserv.Name = "bttserv";
            this.bttserv.Size = new System.Drawing.Size(120, 35);
            this.bttserv.TabIndex = 3;
            this.bttserv.Text = "Servida";
            this.bttserv.UseVisualStyleBackColor = true;
            this.bttserv.Click += new System.EventHandler(this.bttserv_Click);
            // 
            // bttnew
            // 
            this.bttnew.Location = new System.Drawing.Point(22, 251);
            this.bttnew.Name = "bttnew";
            this.bttnew.Size = new System.Drawing.Size(120, 35);
            this.bttnew.TabIndex = 2;
            this.bttnew.Text = "Nueva";
            this.bttnew.UseVisualStyleBackColor = true;
            this.bttnew.Click += new System.EventHandler(this.bttnew_Click);
            // 
            // lstpedid
            // 
            this.lstpedid.DisplayMember = "Indexof";
            this.lstpedid.FormattingEnabled = true;
            this.lstpedid.Location = new System.Drawing.Point(169, 50);
            this.lstpedid.Name = "lstpedid";
            this.lstpedid.Size = new System.Drawing.Size(120, 186);
            this.lstpedid.TabIndex = 1;
            this.lstpedid.SelectedIndexChanged += new System.EventHandler(this.lstpedid_SelectedIndexChanged);
            // 
            // lstpend
            // 
            this.lstpend.DisplayMember = "numermesa";
            this.lstpend.FormattingEnabled = true;
            this.lstpend.Location = new System.Drawing.Point(22, 50);
            this.lstpend.Name = "lstpend";
            this.lstpend.Size = new System.Drawing.Size(120, 186);
            this.lstpend.TabIndex = 0;
            this.lstpend.SelectedIndexChanged += new System.EventHandler(this.lstpend_SelectedIndexChanged);
            // 
            // grmasa
            // 
            this.grmasa.Controls.Add(this.rgrues);
            this.grmasa.Controls.Add(this.rfina);
            this.grmasa.Controls.Add(this.rnorm);
            this.grmasa.Location = new System.Drawing.Point(352, 12);
            this.grmasa.Name = "grmasa";
            this.grmasa.Size = new System.Drawing.Size(190, 161);
            this.grmasa.TabIndex = 1;
            this.grmasa.TabStop = false;
            this.grmasa.Text = "Tipo de masa";
            // 
            // rgrues
            // 
            this.rgrues.AutoSize = true;
            this.rgrues.Location = new System.Drawing.Point(24, 110);
            this.rgrues.Name = "rgrues";
            this.rgrues.Size = new System.Drawing.Size(81, 17);
            this.rgrues.TabIndex = 2;
            this.rgrues.TabStop = true;
            this.rgrues.Text = "Extragruesa";
            this.rgrues.UseVisualStyleBackColor = true;
            // 
            // rfina
            // 
            this.rfina.AutoSize = true;
            this.rfina.Location = new System.Drawing.Point(24, 74);
            this.rfina.Name = "rfina";
            this.rfina.Size = new System.Drawing.Size(45, 17);
            this.rfina.TabIndex = 1;
            this.rfina.TabStop = true;
            this.rfina.Text = "Fina";
            this.rfina.UseVisualStyleBackColor = true;
            // 
            // rnorm
            // 
            this.rnorm.AutoSize = true;
            this.rnorm.Location = new System.Drawing.Point(24, 37);
            this.rnorm.Name = "rnorm";
            this.rnorm.Size = new System.Drawing.Size(58, 17);
            this.rnorm.TabIndex = 0;
            this.rnorm.TabStop = true;
            this.rnorm.Text = "Normal";
            this.rnorm.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ensacombo);
            this.groupBox3.Location = new System.Drawing.Point(580, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ensalada";
            // 
            // ensacombo
            // 
            this.ensacombo.FormattingEnabled = true;
            this.ensacombo.Items.AddRange(new object[] {
            "Tropical ",
            "Cesar ",
            "Mediterranea"});
            this.ensacombo.Location = new System.Drawing.Point(38, 25);
            this.ensacombo.Name = "ensacombo";
            this.ensacombo.Size = new System.Drawing.Size(121, 21);
            this.ensacombo.TabIndex = 6;
            // 
            // grrefresc
            // 
            this.grrefresc.Controls.Add(this.radioButton2);
            this.grrefresc.Controls.Add(this.rmedi);
            this.grrefresc.Location = new System.Drawing.Point(580, 86);
            this.grrefresc.Name = "grrefresc";
            this.grrefresc.Size = new System.Drawing.Size(190, 86);
            this.grrefresc.TabIndex = 3;
            this.grrefresc.TabStop = false;
            this.grrefresc.Text = "Refresco";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(113, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Grande";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rmedi
            // 
            this.rmedi.AutoSize = true;
            this.rmedi.Location = new System.Drawing.Point(23, 36);
            this.rmedi.Name = "rmedi";
            this.rmedi.Size = new System.Drawing.Size(66, 17);
            this.rmedi.TabIndex = 3;
            this.rmedi.TabStop = true;
            this.rmedi.Text = "Mediano";
            this.rmedi.UseVisualStyleBackColor = true;
            // 
            // gringr
            // 
            this.gringr.Controls.Add(this.ingr4);
            this.gringr.Controls.Add(this.ingr2);
            this.gringr.Controls.Add(this.ingr3);
            this.gringr.Controls.Add(this.ingr1);
            this.gringr.Location = new System.Drawing.Point(352, 198);
            this.gringr.Name = "gringr";
            this.gringr.Size = new System.Drawing.Size(418, 123);
            this.gringr.TabIndex = 4;
            this.gringr.TabStop = false;
            this.gringr.Text = "Ingredientes";
            // 
            // ingr4
            // 
            this.ingr4.AutoSize = true;
            this.ingr4.Location = new System.Drawing.Point(283, 83);
            this.ingr4.Name = "ingr4";
            this.ingr4.Size = new System.Drawing.Size(74, 17);
            this.ingr4.TabIndex = 3;
            this.ingr4.Text = "Pepperoni";
            this.ingr4.UseVisualStyleBackColor = true;
            // 
            // ingr2
            // 
            this.ingr2.AutoSize = true;
            this.ingr2.Location = new System.Drawing.Point(283, 33);
            this.ingr2.Name = "ingr2";
            this.ingr2.Size = new System.Drawing.Size(90, 17);
            this.ingr2.TabIndex = 2;
            this.ingr2.Text = "Champiñones";
            this.ingr2.UseVisualStyleBackColor = true;
            // 
            // ingr3
            // 
            this.ingr3.AutoSize = true;
            this.ingr3.Location = new System.Drawing.Point(41, 83);
            this.ingr3.Name = "ingr3";
            this.ingr3.Size = new System.Drawing.Size(47, 17);
            this.ingr3.TabIndex = 1;
            this.ingr3.Text = "Piña";
            this.ingr3.UseVisualStyleBackColor = true;
            // 
            // ingr1
            // 
            this.ingr1.AutoSize = true;
            this.ingr1.Location = new System.Drawing.Point(41, 32);
            this.ingr1.Name = "ingr1";
            this.ingr1.Size = new System.Drawing.Size(68, 17);
            this.ingr1.TabIndex = 0;
            this.ingr1.Text = "Anchoas";
            this.ingr1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nmesas);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(352, 327);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(418, 111);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mesa";
            // 
            // nmesas
            // 
            this.nmesas.Location = new System.Drawing.Point(217, 50);
            this.nmesas.Name = "nmesas";
            this.nmesas.Size = new System.Drawing.Size(100, 20);
            this.nmesas.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número de mesa: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.gringr);
            this.Controls.Add(this.grrefresc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grmasa);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizzeria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grmasa.ResumeLayout(false);
            this.grmasa.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.grrefresc.ResumeLayout(false);
            this.grrefresc.PerformLayout();
            this.gringr.ResumeLayout(false);
            this.gringr.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnew;
        private System.Windows.Forms.ListBox lstpedid;
        private System.Windows.Forms.ListBox lstpend;
        private System.Windows.Forms.GroupBox grmasa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grrefresc;
        private System.Windows.Forms.GroupBox gringr;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button bttserv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rgrues;
        private System.Windows.Forms.RadioButton rfina;
        private System.Windows.Forms.RadioButton rnorm;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rmedi;
        private System.Windows.Forms.TextBox nmesas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ingr4;
        private System.Windows.Forms.CheckBox ingr2;
        private System.Windows.Forms.CheckBox ingr3;
        private System.Windows.Forms.CheckBox ingr1;
        private System.Windows.Forms.ComboBox ensacombo;
    }
}

