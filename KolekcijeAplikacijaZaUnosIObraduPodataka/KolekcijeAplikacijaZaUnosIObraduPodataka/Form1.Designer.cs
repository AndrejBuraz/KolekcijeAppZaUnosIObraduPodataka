namespace KolekcijeAplikacijaZaUnosIObraduPodataka
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
            this.textBoxIspis = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.buttonUnos = new System.Windows.Forms.Button();
            this.buttonObradi = new System.Windows.Forms.Button();
            this.buttonIspis = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxIspis
            // 
            this.textBoxIspis.Location = new System.Drawing.Point(491, 63);
            this.textBoxIspis.Multiline = true;
            this.textBoxIspis.Name = "textBoxIspis";
            this.textBoxIspis.Size = new System.Drawing.Size(606, 374);
            this.textBoxIspis.TabIndex = 0;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(50, 63);
            this.textBoxMarka.Multiline = true;
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(215, 42);
            this.textBoxMarka.TabIndex = 1;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(50, 163);
            this.textBoxModel.Multiline = true;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(215, 42);
            this.textBoxModel.TabIndex = 2;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(51, 516);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(214, 60);
            this.buttonUnos.TabIndex = 3;
            this.buttonUnos.Text = "UNOS";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click);
            // 
            // buttonObradi
            // 
            this.buttonObradi.Location = new System.Drawing.Point(491, 516);
            this.buttonObradi.Name = "buttonObradi";
            this.buttonObradi.Size = new System.Drawing.Size(214, 60);
            this.buttonObradi.TabIndex = 4;
            this.buttonObradi.Text = "OBRADI";
            this.buttonObradi.UseVisualStyleBackColor = true;
            this.buttonObradi.Click += new System.EventHandler(this.buttonObradi_Click);
            // 
            // buttonIspis
            // 
            this.buttonIspis.Location = new System.Drawing.Point(881, 516);
            this.buttonIspis.Name = "buttonIspis";
            this.buttonIspis.Size = new System.Drawing.Size(216, 60);
            this.buttonIspis.TabIndex = 5;
            this.buttonIspis.Text = "ISPIS";
            this.buttonIspis.UseVisualStyleBackColor = true;
            this.buttonIspis.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Avion",
            "Automobil",
            "Brod"});
            this.comboBox1.Location = new System.Drawing.Point(51, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 652);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonIspis);
            this.Controls.Add(this.buttonObradi);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.textBoxIspis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIspis;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.Button buttonObradi;
        private System.Windows.Forms.Button buttonIspis;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

