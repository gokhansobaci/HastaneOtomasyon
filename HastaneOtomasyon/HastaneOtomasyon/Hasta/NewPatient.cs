using HastaneOtomasyon.Hasta.Models;
using HastaneOtomasyon.Hasta.Services;
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
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void Alarm(object sender, EventArgs e)
        {
            //sender: Bu olayın bağlı olduğu komponenti temsil eder. Hangi komponent kullanılıyorsa ona dönüştürmek gereklidir.
            ComboBox box = (ComboBox)sender;
            MessageBox.Show(box.SelectedItem.ToString());
        }

        private Cities cities;
        private void NewPatient_Load(object sender, EventArgs e)
        {
            cities = new Cities();
            cb_city.Items.Add("--- İl Seçiniz ---");
            cb_district.Items.Add("--- İlçe seçiniz ---");
            cb_neightbourhood.Items.Add("--- Mahalle Seçiniz ---");
            cb_streetalley.Items.Add("--- Cadde/Sokak seçiniz ---");

            //cb_bloodtype.DataSource = Enum.GetValues(typeof(BloodTypes));
            //datasource: Bu ekleme yöntemi koleksiyonu en saf haliyle alıp değişime kapalı bir şekilde kullanır. Enum yapılarında eklenen açıklama uzantısını çalışmaz hale getirir.

            cb_bloodtype.Items.Add("--- Kan Grubu seçiniz ---");
            foreach (BloodTypes item in Enum.GetValues(typeof(BloodTypes)))
            {
                //Tüm Enum yapıları için tanımlanmış GetDescription uzantısı burada çağırılarak, her elemanın açıklama alanı okunur.
                var bloodtype = new KeyValuePair<object, string>(item, item.GetDescription());
                //ComboBox: Anahtar-Değer ikilisinin anahtar kısmını seçim için arkaplanda, değer kısmını gösterim için ön planda kullanır.
                cb_bloodtype.Items.Add(bloodtype);
            }
            cb_bloodtype.DisplayMember = "Value";
            cb_bloodtype.ValueMember = "Key";
            
            cb_city.Items.AddRange(cities.AllCities.Keys.ToArray());

            cb_city.SelectedIndex = 0;
            cb_district.SelectedIndex = 0;
            cb_neightbourhood.SelectedIndex = 0;
            cb_streetalley.SelectedIndex = 0;

            cb_bloodtype.SelectedIndex = 0;

            btn_save.Enabled = false;

            tb_phone1.Text = "+905";
            tb_phone2.Text = "+905";
            tb_phone3.Text = "+905";
        }

        private void cb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_city.SelectedIndex > 0)
            {
                string selected_city = cb_city.SelectedItem.ToString();
                string[] selected_districts = cities.AllCities[selected_city];
                cb_district.Items.Clear();
                cb_district.Items.Add("--- İlçe seçiniz ---");
                cb_district.Items.AddRange(selected_districts);
                cb_district.SelectedIndex = 0;
            }
        }

        private void tb_tckn_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tools.TCKNCheck(tb_tckn.Text))
            {
                tb_tckn.BackColor = Color.LightGreen;
                btn_save.Enabled = true;
            }
            else
            {
                tb_tckn.BackColor = Color.LightSalmon;
                btn_save.Enabled = false;
            }
        }

        private void phone_number_check(object sender, KeyEventArgs e)
        {
            if (Tools.PhoneFormatCheck(tb_phone1.Text) ||
                Tools.PhoneFormatCheck(tb_phone2.Text) ||
                Tools.PhoneFormatCheck(tb_phone3.Text))
            {
                tb_phone1.BackColor = Color.LightGreen;
                tb_phone2.BackColor = Color.LightGreen;
                tb_phone3.BackColor = Color.LightGreen;
                btn_save.Enabled = true;
            }
            else
            {
                tb_phone1.BackColor = Color.LightSalmon;
                tb_phone2.BackColor = Color.LightSalmon;
                tb_phone3.BackColor = Color.LightSalmon;
                btn_save.Enabled = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            PatientModel patient = new PatientModel
            {
                NationalID = long.Parse(tb_tckn.Text),
                Firstname = tb_fullname.Text.Split(' ')[0],
                Lastname = string.Join(" ", tb_fullname.Text.Split(' ').Skip(1)),
                Gender = rb_male.Checked && !rb_female.Checked,
                DateOfBirth = dt_dateofbirth.Value,
                City = cb_city.SelectedItem.ToString(),
                District = cb_district.SelectedItem.ToString(),
                Neighbourhood = cb_neightbourhood.SelectedIndex > 0 ? cb_neightbourhood.SelectedText : null,
                StreetAlley = cb_neightbourhood.SelectedIndex > 0 ? cb_neightbourhood.SelectedText : null,
                BloodType = cb_bloodtype.SelectedIndex > 0 ? (BloodTypes?)cb_bloodtype.SelectedItem : null,
                Phone1 = Tools.PhoneFormatCheck(tb_phone1.Text) ? tb_phone1.Text : null,
                Phone2 = Tools.PhoneFormatCheck(tb_phone2.Text) ? tb_phone2.Text : null,
                Phone3 = Tools.PhoneFormatCheck(tb_phone3.Text) ? tb_phone3.Text : null,
            };

            PatientService service = new PatientService();
            service.AddPatient(patient);
        }
    }
}
