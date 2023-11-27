namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtpasswd = new System.Windows.Forms.TextBox();
            this.verPsswd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce un número: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(168, 32);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(65, 20);
            this.txtbox1.TabIndex = 1;
            this.txtbox1.Text = "Form2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(168, 87);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(100, 20);
            this.txtbox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Introduce Fecha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(297, 82);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(62, 28);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(182, 245);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txtpasswd
            // 
            this.txtpasswd.Location = new System.Drawing.Point(168, 128);
            this.txtpasswd.Name = "txtpasswd";
            this.txtpasswd.PasswordChar = '*';
            this.txtpasswd.Size = new System.Drawing.Size(100, 20);
            this.txtpasswd.TabIndex = 8;
            // 
            // verPsswd
            // 
            this.verPsswd.Location = new System.Drawing.Point(276, 123);
            this.verPsswd.Name = "verPsswd";
            this.verPsswd.Size = new System.Drawing.Size(41, 28);
            this.verPsswd.TabIndex = 9;
            this.verPsswd.Text = "ojo";
            this.verPsswd.UseVisualStyleBackColor = true;
            this.verPsswd.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 425);
            this.Controls.Add(this.verPsswd);
            this.Controls.Add(this.txtpasswd);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Control);
            this.LocationChanged += new System.EventHandler(this.Form2_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtpasswd;
        private System.Windows.Forms.Button verPsswd;
    }
}