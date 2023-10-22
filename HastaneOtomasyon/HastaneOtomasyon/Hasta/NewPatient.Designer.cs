namespace HastaneOtomasyon.Hasta
{
    partial class NewPatient
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
            this.lbl_tckn = new System.Windows.Forms.Label();
            this.tb_tckn = new System.Windows.Forms.MaskedTextBox();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.dt_dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_district = new System.Windows.Forms.ComboBox();
            this.cb_neightbourhood = new System.Windows.Forms.ComboBox();
            this.cb_streetalley = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_bloodtype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_phone1 = new System.Windows.Forms.MaskedTextBox();
            this.tb_phone2 = new System.Windows.Forms.MaskedTextBox();
            this.tb_phone3 = new System.Windows.Forms.MaskedTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tckn
            // 
            this.lbl_tckn.AutoSize = true;
            this.lbl_tckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tckn.Location = new System.Drawing.Point(12, 15);
            this.lbl_tckn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tckn.Name = "lbl_tckn";
            this.lbl_tckn.Size = new System.Drawing.Size(92, 17);
            this.lbl_tckn.TabIndex = 0;
            this.lbl_tckn.Text = "TC Kimlik No:";
            // 
            // tb_tckn
            // 
            this.tb_tckn.Location = new System.Drawing.Point(116, 12);
            this.tb_tckn.Mask = "00000000000";
            this.tb_tckn.Name = "tb_tckn";
            this.tb_tckn.Size = new System.Drawing.Size(86, 23);
            this.tb_tckn.TabIndex = 1;
            this.tb_tckn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_tckn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_tckn_KeyUp);
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(12, 44);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(73, 17);
            this.lbl_adsoyad.TabIndex = 2;
            this.lbl_adsoyad.Text = "Ad Soyad:";
            // 
            // tb_fullname
            // 
            this.tb_fullname.Location = new System.Drawing.Point(116, 41);
            this.tb_fullname.MaxLength = 100;
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(198, 23);
            this.tb_fullname.TabIndex = 3;
            this.tb_fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cinsiyet:";
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(116, 70);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(62, 21);
            this.rb_male.TabIndex = 6;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Erkek";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(184, 70);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(62, 21);
            this.rb_female.TabIndex = 7;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Kadın";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // dt_dateofbirth
            // 
            this.dt_dateofbirth.Location = new System.Drawing.Point(116, 97);
            this.dt_dateofbirth.Name = "dt_dateofbirth";
            this.dt_dateofbirth.Size = new System.Drawing.Size(198, 23);
            this.dt_dateofbirth.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Doğum Tarihi:";
            // 
            // cb_city
            // 
            this.cb_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Location = new System.Drawing.Point(116, 126);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(198, 24);
            this.cb_city.TabIndex = 10;
            this.cb_city.SelectedIndexChanged += new System.EventHandler(this.cb_city_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adres Bilgileri:";
            // 
            // cb_district
            // 
            this.cb_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_district.FormattingEnabled = true;
            this.cb_district.Location = new System.Drawing.Point(116, 156);
            this.cb_district.Name = "cb_district";
            this.cb_district.Size = new System.Drawing.Size(198, 24);
            this.cb_district.TabIndex = 12;
            // 
            // cb_neightbourhood
            // 
            this.cb_neightbourhood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_neightbourhood.FormattingEnabled = true;
            this.cb_neightbourhood.Location = new System.Drawing.Point(116, 186);
            this.cb_neightbourhood.Name = "cb_neightbourhood";
            this.cb_neightbourhood.Size = new System.Drawing.Size(198, 24);
            this.cb_neightbourhood.TabIndex = 13;
            // 
            // cb_streetalley
            // 
            this.cb_streetalley.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_streetalley.FormattingEnabled = true;
            this.cb_streetalley.Location = new System.Drawing.Point(116, 216);
            this.cb_streetalley.Name = "cb_streetalley";
            this.cb_streetalley.Size = new System.Drawing.Size(198, 24);
            this.cb_streetalley.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kan Grubu:";
            // 
            // cb_bloodtype
            // 
            this.cb_bloodtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_bloodtype.FormattingEnabled = true;
            this.cb_bloodtype.Location = new System.Drawing.Point(115, 252);
            this.cb_bloodtype.Name = "cb_bloodtype";
            this.cb_bloodtype.Size = new System.Drawing.Size(199, 24);
            this.cb_bloodtype.TabIndex = 16;
            this.cb_bloodtype.SelectedIndexChanged += new System.EventHandler(this.Alarm);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Telefon:";
            // 
            // tb_phone1
            // 
            this.tb_phone1.Location = new System.Drawing.Point(115, 291);
            this.tb_phone1.Mask = "+90 (999) 000 0000";
            this.tb_phone1.Name = "tb_phone1";
            this.tb_phone1.Size = new System.Drawing.Size(117, 23);
            this.tb_phone1.TabIndex = 18;
            this.tb_phone1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.phone_number_check);
            // 
            // tb_phone2
            // 
            this.tb_phone2.Location = new System.Drawing.Point(115, 320);
            this.tb_phone2.Mask = "+90 (999) 000 0000";
            this.tb_phone2.Name = "tb_phone2";
            this.tb_phone2.Size = new System.Drawing.Size(117, 23);
            this.tb_phone2.TabIndex = 19;
            this.tb_phone2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.phone_number_check);
            // 
            // tb_phone3
            // 
            this.tb_phone3.Location = new System.Drawing.Point(115, 349);
            this.tb_phone3.Mask = "+90 (999) 000 0000";
            this.tb_phone3.Name = "tb_phone3";
            this.tb_phone3.Size = new System.Drawing.Size(117, 23);
            this.tb_phone3.TabIndex = 20;
            this.tb_phone3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.phone_number_check);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_save.Location = new System.Drawing.Point(239, 389);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 32);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Kaydet";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cancel.Location = new System.Drawing.Point(158, 389);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 32);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Vazgeç";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // NewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 430);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_phone3);
            this.Controls.Add(this.tb_phone2);
            this.Controls.Add(this.tb_phone1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_bloodtype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_streetalley);
            this.Controls.Add(this.cb_neightbourhood);
            this.Controls.Add(this.cb_district);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_city);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_dateofbirth);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_fullname);
            this.Controls.Add(this.lbl_adsoyad);
            this.Controls.Add(this.tb_tckn);
            this.Controls.Add(this.lbl_tckn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewPatient";
            this.Text = "Yeni Hasta Girişi";
            this.Load += new System.EventHandler(this.NewPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tckn;
        private System.Windows.Forms.MaskedTextBox tb_tckn;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.DateTimePicker dt_dateofbirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_district;
        private System.Windows.Forms.ComboBox cb_neightbourhood;
        private System.Windows.Forms.ComboBox cb_streetalley;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_bloodtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tb_phone1;
        private System.Windows.Forms.MaskedTextBox tb_phone2;
        private System.Windows.Forms.MaskedTextBox tb_phone3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}