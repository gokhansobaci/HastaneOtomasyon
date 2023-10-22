using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class TestForm : Form
    {

        public TestForm()
        {
            InitializeComponent();
        }

        private int say = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            say++;
            label1.Text = "Etiket: " + say + " kez tıklandı. ";
        }


        private int sayac;
        private void MainForm_Load(object sender, EventArgs e)
        {
            sayac = 0;
            sayac_label.Text = sayac.ToString();
        }

        private void arti_button_Click(object sender, EventArgs e)
        {
            sayac++;
            sayac_label.Text = sayac.ToString();
        }

        private void eksi_button_Click(object sender, EventArgs e)
        {
            sayac--;
            sayac_label.Text = sayac.ToString();
        }

        private void metin_kutusu_TextChanged(object sender, EventArgs e)
        {
            metin_label.Text = metin_kutusu.Text;
        }

    }
}
