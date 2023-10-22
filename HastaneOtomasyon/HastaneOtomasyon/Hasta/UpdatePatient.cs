using HastaneOtomasyon.Hasta.Models;
using HastaneOtomasyon.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.Hasta
{
    public partial class UpdatePatient : Form
    {
        private Cities cities;

        public UpdatePatient()
        {
            InitializeComponent();
        }

        private void UpdatePatient_Load(object sender, EventArgs e)
        {
            btn_update.Enabled = false;

            //İl ve ilçe listeleri için bu sınıf tanımlandı.
            cities = new Cities();

            //ComboBox yapılarının ilk seçenekleri olarak "Seçiniz" seçeneği eklendi.
            //Şehirler için:
            cb_city.Items.Add("-- Şehir Seçiniz --");
            cb_city.SelectedIndex = 0;
            string[] city_names = cities.AllCities.Keys.ToArray();
            cb_city.Items.AddRange(city_names);

            //İlçeler için:
            cb_district.Items.Add("-- İlçe/Semt Seçiniz --");
            cb_district.SelectedIndex = 0;

            //Mahalleler için:
            cb_neightbourhood.Items.Add("--Mahalle Seçiniz --");
            cb_neightbourhood.SelectedIndex = 0;

            //Cadde/Sokak için:
            cb_streetalley.Items.Add("-- Cadde/Sokak Seçiniz --");
            cb_streetalley.SelectedIndex = 0;

            //Kan Grubu için:
            foreach (BloodTypes btype in Enum.GetValues(typeof(BloodTypes)))
            {
                var item = new BloodTypeModel
                {
                    BloodType = btype,
                    Description = btype.GetDescription()
                };

                cb_bloodtype.Items.Add(item);
            }
            cb_bloodtype.DisplayMember = "Description";
            cb_bloodtype.ValueMember = "BloodType";
            cb_bloodtype.SelectedIndex = 0;

            //Telefon Numaraları Başlangıç:
            tb_phone1.Text = "+905";
            tb_phone2.Text = "+905";
            tb_phone3.Text = "+905";
        }

        private void phone_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tools.PhoneFormatCheck(tb_phone1.Text) ||
                Tools.PhoneFormatCheck(tb_phone2.Text) ||
                Tools.PhoneFormatCheck(tb_phone3.Text))
            {
                tb_phone1.BackColor = Color.LightGreen;
                tb_phone2.BackColor = Color.LightGreen;
                tb_phone3.BackColor = Color.LightGreen;
            }
            else
            {
                tb_phone1.BackColor = Color.LightSalmon;
                tb_phone2.BackColor = Color.LightSalmon;
                tb_phone3.BackColor = Color.LightSalmon;
            }
        }

        private void tb_tckn_KeyUp(object sender, KeyEventArgs e)
        {
            tb_tckn.BackColor = Tools.TCKNCheck(tb_tckn.Text.Trim()) ? Color.LightGreen : Color.LightSalmon;
        }

        private void tb_fullname_KeyUp(object sender, KeyEventArgs e)
        {
            ////Trim: Bir metin yapısında başta ve sonra bulunan boşlukları kaldırır.
            //string fullname = tb_fullname.Text.Trim();

            ////Split('ayraç karakteri'): Bir cümleyi belirtilmiş olan ayraç karakteri (char) ile bölme işlemidir.
            //string[] words = fullname.Split(' ');

            //bool status = false;
            //if (words.Length > 1)
            //{
            //    status = true;
            //    foreach (string word in words)
            //    {
            //        if (word.Length < 2)
            //        {
            //            status = false;
            //            break;
            //        }
            //    }
            //}

            tb_fullname.BackColor = Tools.WordCheck(tb_fullname.Text, 2) ? Color.LightGreen : Color.LightSalmon;
        }

        private void cb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_district.Items.Clear();
            cb_district.Items.Add("-- İlçe/Semt Seçiniz --");
            cb_district.SelectedIndex = 0;

            if (cb_city.SelectedIndex > 0)
            {
                string[] districts = cities.AllCities[cb_city.SelectedItem.ToString()];
                cb_district.Items.AddRange(districts);
            }

            cb_city.BackColor = cb_city.SelectedIndex > 0 ? Color.LightGreen : Color.LightSalmon;
        }

        private void cb_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_district.BackColor = cb_district.SelectedIndex > 0 ? Color.LightGreen : Color.LightSalmon;
        }

        private void rb_checked_changed(object sender, EventArgs e)
        {
            if (rb_male.Checked || rb_female.Checked)
            {
                rb_male.ForeColor = Color.Green;
                rb_female.ForeColor = Color.Green;
            }
            else
            {
                rb_male.ForeColor = Color.Salmon;
                rb_female.ForeColor = Color.Salmon;
            }
        }

        private void cb_bloodtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (BloodTypeModel)cb_bloodtype.SelectedItem;
            //MessageBox.Show(item.Description, item.BloodType.ToString());
            cb_bloodtype.BackColor = item.BloodType == BloodTypes.None ? Color.LightSalmon : Color.LightGreen;
        }
    }
}
