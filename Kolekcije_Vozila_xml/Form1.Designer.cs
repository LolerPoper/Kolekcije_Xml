namespace Kolekcije_Vozila_xml
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
            this.TxtMod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIspis = new System.Windows.Forms.TextBox();
            this.BtnUnos = new System.Windows.Forms.Button();
            this.BtnObrada = new System.Windows.Forms.Button();
            this.BtnIspis = new System.Windows.Forms.Button();
            this.CmbGod = new System.Windows.Forms.ComboBox();
            this.CmbKot = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxtMod
            // 
            this.TxtMod.Location = new System.Drawing.Point(13, 31);
            this.TxtMod.Name = "TxtMod";
            this.TxtMod.Size = new System.Drawing.Size(100, 20);
            this.TxtMod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Godina Proizvodnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broj Kotača";
            // 
            // TxtIspis
            // 
            this.TxtIspis.Location = new System.Drawing.Point(140, 31);
            this.TxtIspis.Multiline = true;
            this.TxtIspis.Name = "TxtIspis";
            this.TxtIspis.ReadOnly = true;
            this.TxtIspis.Size = new System.Drawing.Size(648, 305);
            this.TxtIspis.TabIndex = 7;
            // 
            // BtnUnos
            // 
            this.BtnUnos.Location = new System.Drawing.Point(13, 382);
            this.BtnUnos.Name = "BtnUnos";
            this.BtnUnos.Size = new System.Drawing.Size(75, 23);
            this.BtnUnos.TabIndex = 8;
            this.BtnUnos.Text = "Unos";
            this.BtnUnos.UseVisualStyleBackColor = true;
            this.BtnUnos.Click += new System.EventHandler(this.BtnUnos_Click);
            // 
            // BtnObrada
            // 
            this.BtnObrada.Location = new System.Drawing.Point(94, 382);
            this.BtnObrada.Name = "BtnObrada";
            this.BtnObrada.Size = new System.Drawing.Size(75, 23);
            this.BtnObrada.TabIndex = 9;
            this.BtnObrada.Text = "Obrada";
            this.BtnObrada.UseVisualStyleBackColor = true;
            this.BtnObrada.Click += new System.EventHandler(this.BtnObrada_Click);
            // 
            // BtnIspis
            // 
            this.BtnIspis.Location = new System.Drawing.Point(175, 382);
            this.BtnIspis.Name = "BtnIspis";
            this.BtnIspis.Size = new System.Drawing.Size(75, 23);
            this.BtnIspis.TabIndex = 10;
            this.BtnIspis.Text = "Ispis";
            this.BtnIspis.UseVisualStyleBackColor = true;
            // 
            // CmbGod
            // 
            this.CmbGod.FormattingEnabled = true;
            this.CmbGod.Location = new System.Drawing.Point(12, 92);
            this.CmbGod.Name = "CmbGod";
            this.CmbGod.Size = new System.Drawing.Size(101, 21);
            this.CmbGod.TabIndex = 11;
            // 
            // CmbKot
            // 
            this.CmbKot.FormattingEnabled = true;
            this.CmbKot.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "12",
            "16"});
            this.CmbKot.Location = new System.Drawing.Point(12, 157);
            this.CmbKot.Name = "CmbKot";
            this.CmbKot.Size = new System.Drawing.Size(100, 21);
            this.CmbKot.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbKot);
            this.Controls.Add(this.CmbGod);
            this.Controls.Add(this.BtnIspis);
            this.Controls.Add(this.BtnObrada);
            this.Controls.Add(this.BtnUnos);
            this.Controls.Add(this.TxtIspis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIspis;
        private System.Windows.Forms.Button BtnUnos;
        private System.Windows.Forms.Button BtnObrada;
        private System.Windows.Forms.Button BtnIspis;
        private System.Windows.Forms.ComboBox CmbGod;
        private System.Windows.Forms.ComboBox CmbKot;
    }
}

