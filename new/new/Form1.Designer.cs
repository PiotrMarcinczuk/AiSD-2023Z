namespace @new
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Czas = new System.Windows.Forms.Label();
            this.timeValue = new System.Windows.Forms.Label();
            this.Generuj = new System.Windows.Forms.Button();
            this.SB = new System.Windows.Forms.Button();
            this.SS = new System.Windows.Forms.Button();
            this.SI = new System.Windows.Forms.Button();
            this.SM = new System.Windows.Forms.Button();
            this.SQ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 65);
            this.textBox1.MaxLength = 900000000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 244);
            this.textBox2.MaxLength = 900000000;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 20);
            this.textBox2.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(379, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(587, 64);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Czas
            // 
            this.Czas.AutoSize = true;
            this.Czas.Location = new System.Drawing.Point(524, 251);
            this.Czas.Name = "Czas";
            this.Czas.Size = new System.Drawing.Size(30, 13);
            this.Czas.TabIndex = 5;
            this.Czas.Text = "Czas";
            this.Czas.Click += new System.EventHandler(this.label2_Click);
            // 
            // timeValue
            // 
            this.timeValue.AutoSize = true;
            this.timeValue.Location = new System.Drawing.Point(587, 251);
            this.timeValue.Name = "timeValue";
            this.timeValue.Size = new System.Drawing.Size(0, 13);
            this.timeValue.TabIndex = 6;
            this.timeValue.Click += new System.EventHandler(this.timeValue_Click);
            // 
            // Generuj
            // 
            this.Generuj.Location = new System.Drawing.Point(590, 126);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(75, 23);
            this.Generuj.TabIndex = 7;
            this.Generuj.Text = "Generuj";
            this.Generuj.UseVisualStyleBackColor = true;
            this.Generuj.Click += new System.EventHandler(this.Generuj_Click);
            // 
            // SB
            // 
            this.SB.Location = new System.Drawing.Point(87, 363);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(75, 23);
            this.SB.TabIndex = 8;
            this.SB.Text = "SB";
            this.SB.UseVisualStyleBackColor = true;
            this.SB.Click += new System.EventHandler(this.button1_Click);
            // 
            // SS
            // 
            this.SS.Location = new System.Drawing.Point(226, 363);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(75, 23);
            this.SS.TabIndex = 9;
            this.SS.Text = "SS";
            this.SS.UseVisualStyleBackColor = true;
            this.SS.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SI
            // 
            this.SI.Location = new System.Drawing.Point(355, 363);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(75, 23);
            this.SI.TabIndex = 10;
            this.SI.Text = "SI";
            this.SI.UseVisualStyleBackColor = true;
            this.SI.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // SM
            // 
            this.SM.Location = new System.Drawing.Point(479, 363);
            this.SM.Name = "SM";
            this.SM.Size = new System.Drawing.Size(75, 23);
            this.SM.TabIndex = 11;
            this.SM.Text = "SM";
            this.SM.UseVisualStyleBackColor = true;
            this.SM.Click += new System.EventHandler(this.SM_Click);
            // 
            // SQ
            // 
            this.SQ.Location = new System.Drawing.Point(606, 363);
            this.SQ.Name = "SQ";
            this.SQ.Size = new System.Drawing.Size(75, 23);
            this.SQ.TabIndex = 12;
            this.SQ.Text = "SQ";
            this.SQ.UseVisualStyleBackColor = true;
            this.SQ.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SQ);
            this.Controls.Add(this.SM);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.SB);
            this.Controls.Add(this.Generuj);
            this.Controls.Add(this.timeValue);
            this.Controls.Add(this.Czas);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Czas;
        private System.Windows.Forms.Label timeValue;
        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.Button SB;
        private System.Windows.Forms.Button SS;
        private System.Windows.Forms.Button SI;
        private System.Windows.Forms.Button SM;
        private System.Windows.Forms.Button SQ;
    }
}

