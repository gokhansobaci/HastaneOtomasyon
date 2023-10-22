namespace HastaneOtomasyon
{
    partial class TestForm
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
            this.sayac_label = new System.Windows.Forms.Label();
            this.eksi_button = new System.Windows.Forms.Button();
            this.arti_button = new System.Windows.Forms.Button();
            this.metin_kutusu = new System.Windows.Forms.TextBox();
            this.metin_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etiket:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sayac_label
            // 
            this.sayac_label.Location = new System.Drawing.Point(45, 38);
            this.sayac_label.Name = "sayac_label";
            this.sayac_label.Size = new System.Drawing.Size(25, 23);
            this.sayac_label.TabIndex = 1;
            this.sayac_label.Text = "000";
            this.sayac_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // eksi_button
            // 
            this.eksi_button.Location = new System.Drawing.Point(16, 38);
            this.eksi_button.Name = "eksi_button";
            this.eksi_button.Size = new System.Drawing.Size(23, 23);
            this.eksi_button.TabIndex = 2;
            this.eksi_button.Text = "-";
            this.eksi_button.UseVisualStyleBackColor = true;
            this.eksi_button.Click += new System.EventHandler(this.eksi_button_Click);
            // 
            // arti_button
            // 
            this.arti_button.Location = new System.Drawing.Point(76, 38);
            this.arti_button.Name = "arti_button";
            this.arti_button.Size = new System.Drawing.Size(23, 23);
            this.arti_button.TabIndex = 3;
            this.arti_button.Text = "+";
            this.arti_button.UseVisualStyleBackColor = true;
            this.arti_button.Click += new System.EventHandler(this.arti_button_Click);
            // 
            // metin_kutusu
            // 
            this.metin_kutusu.Location = new System.Drawing.Point(16, 68);
            this.metin_kutusu.Name = "metin_kutusu";
            this.metin_kutusu.Size = new System.Drawing.Size(100, 20);
            this.metin_kutusu.TabIndex = 4;
            this.metin_kutusu.TextChanged += new System.EventHandler(this.metin_kutusu_TextChanged);
            // 
            // metin_label
            // 
            this.metin_label.AutoSize = true;
            this.metin_label.Location = new System.Drawing.Point(123, 68);
            this.metin_label.Name = "metin_label";
            this.metin_label.Size = new System.Drawing.Size(0, 13);
            this.metin_label.TabIndex = 5;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metin_label);
            this.Controls.Add(this.metin_kutusu);
            this.Controls.Add(this.arti_button);
            this.Controls.Add(this.eksi_button);
            this.Controls.Add(this.sayac_label);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Otomasyon Sistemi v0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sayac_label;
        private System.Windows.Forms.Button eksi_button;
        private System.Windows.Forms.Button arti_button;
        private System.Windows.Forms.TextBox metin_kutusu;
        private System.Windows.Forms.Label metin_label;
    }
}

