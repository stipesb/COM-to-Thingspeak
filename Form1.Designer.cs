namespace COM_to_Thingspeak
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
            this.pretrazi = new System.Windows.Forms.Button();
            this.PORTOVI = new System.Windows.Forms.ComboBox();
            this.visina_senzor = new System.Windows.Forms.TextBox();
            this.Zapocni = new System.Windows.Forms.Button();
            this.Dolazni_podatci = new System.Windows.Forms.TextBox();
            this.visina_snijega_je = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pretrazi
            // 
            this.pretrazi.Location = new System.Drawing.Point(58, 24);
            this.pretrazi.Name = "pretrazi";
            this.pretrazi.Size = new System.Drawing.Size(75, 23);
            this.pretrazi.TabIndex = 0;
            this.pretrazi.Text = "pretrazi";
            this.pretrazi.UseVisualStyleBackColor = true;
            this.pretrazi.Click += new System.EventHandler(this.pretrazi_Click);
            // 
            // PORTOVI
            // 
            this.PORTOVI.AllowDrop = true;
            this.PORTOVI.FormattingEnabled = true;
            this.PORTOVI.Location = new System.Drawing.Point(183, 24);
            this.PORTOVI.Name = "PORTOVI";
            this.PORTOVI.Size = new System.Drawing.Size(121, 21);
            this.PORTOVI.TabIndex = 1;
            this.PORTOVI.SelectedIndexChanged += new System.EventHandler(this.PORTOVI_SelectedIndexChanged);
            // 
            // visina_senzor
            // 
            this.visina_senzor.Location = new System.Drawing.Point(183, 77);
            this.visina_senzor.Name = "visina_senzor";
            this.visina_senzor.Size = new System.Drawing.Size(100, 20);
            this.visina_senzor.TabIndex = 2;
            this.visina_senzor.TextChanged += new System.EventHandler(this.visina_senzor_TextChanged);
            // 
            // Zapocni
            // 
            this.Zapocni.Location = new System.Drawing.Point(183, 130);
            this.Zapocni.Name = "Zapocni";
            this.Zapocni.Size = new System.Drawing.Size(75, 23);
            this.Zapocni.TabIndex = 3;
            this.Zapocni.Text = "ZAPOČNI";
            this.Zapocni.UseVisualStyleBackColor = true;
            this.Zapocni.Click += new System.EventHandler(this.Zapocni_Click);
            // 
            // Dolazni_podatci
            // 
            this.Dolazni_podatci.Location = new System.Drawing.Point(183, 185);
            this.Dolazni_podatci.Name = "Dolazni_podatci";
            this.Dolazni_podatci.ReadOnly = true;
            this.Dolazni_podatci.Size = new System.Drawing.Size(100, 20);
            this.Dolazni_podatci.TabIndex = 4;
            this.Dolazni_podatci.TextChanged += new System.EventHandler(this.Dolazni_podatci_TextChanged);
            // 
            // visina_snijega_je
            // 
            this.visina_snijega_je.Location = new System.Drawing.Point(183, 239);
            this.visina_snijega_je.Name = "visina_snijega_je";
            this.visina_snijega_je.ReadOnly = true;
            this.visina_snijega_je.Size = new System.Drawing.Size(100, 20);
            this.visina_snijega_je.TabIndex = 5;
            this.visina_snijega_je.TextChanged += new System.EventHandler(this.visina_snijega_je_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "visina senzora od tla cm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "podatci na PORTu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Visina snijega je cm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visina_snijega_je);
            this.Controls.Add(this.Dolazni_podatci);
            this.Controls.Add(this.Zapocni);
            this.Controls.Add(this.visina_senzor);
            this.Controls.Add(this.PORTOVI);
            this.Controls.Add(this.pretrazi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pretrazi;
        private System.Windows.Forms.ComboBox PORTOVI;
        private System.Windows.Forms.TextBox visina_senzor;
        private System.Windows.Forms.Button Zapocni;
        private System.Windows.Forms.TextBox Dolazni_podatci;
        private System.Windows.Forms.TextBox visina_snijega_je;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

