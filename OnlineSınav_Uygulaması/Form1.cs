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
    public partial class SınavGiris : Form
    {
        public SınavGiris()
        {
            InitializeComponent();
        }

        private void btn_sinavagiris_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();

            this.Hide();
        }
    }
}
