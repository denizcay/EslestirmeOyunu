using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EslestirmeOyunu
{
    public partial class YeniOyunForm : Form
    {
        public YeniOyunForm()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Seviye s = rbKolay.Checked ? Seviye.Kolay : (rbOrta.Checked ? Seviye.Orta : Seviye.Zor);
            Hide();
            new Form1(s).Show(this); // owner olarak set etme
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
