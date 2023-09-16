using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineSınav_Uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayac = 3000;
        int dogru = 0;
        int yanlis = 0;

        public void sonuclar(RadioButton seciliolan)
        {
            if (seciliolan.Checked==true)
            {
                dogru++;
                seciliolan.BackColor = Color.Blue;
            }
            else
            {
                yanlis++;
            }

            lbl_dogrusayisi.Text = dogru.ToString();
            lbl_yanlissayisi.Text = yanlis.ToString();  
        }

        public void grubtrue()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
        }

        public void grubfalse()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            grubfalse();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            lbl_sure.Text = sayac.ToString();

            if (sayac==0)
            {
                timer1.Enabled = false;
                grubfalse();

                MessageBox.Show("Süre Doldu");
                btn_basla.Enabled = false;
                btn_bitir.Enabled = false;

                sonuclar(radioButton3);
                sonuclar(radioButton5);
                sonuclar(radioButton10);
                sonuclar(radioButton15);
            }
        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            if ((txt_tcno.Text=="") || (txt_adsoyad.Text == ""))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
            else if (txt_tcno.Text.Length != 11)
            {
                MessageBox.Show("Tc Kimlik numaranız 11 haneli olmalıdır");
            }
            else
            {
                timer1.Enabled=true;
                grubtrue();
                lbl_tcno.Text = txt_tcno.Text;
                lbl_adsoyad.Text = txt_adsoyad.Text;
                btn_basla.Enabled = false;
            }
        }

        private void btn_bitir_Click(object sender, EventArgs e)
        {
            grubfalse();
            btn_bitir.Enabled=false;
            timer1.Enabled=false;


            sonuclar(radioButton3);
            sonuclar(radioButton5);
            sonuclar(radioButton10);
            sonuclar(radioButton15);

        }
    }
}
