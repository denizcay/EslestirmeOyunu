using EslestirmeOyunu.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EslestirmeOyunu
{
    public partial class Form1 : Form
    {
        int sutunAdet = 4;
        int satirAdet = 4;
        int kartBoyut = 75;
        int kartArasi = 5;
        int[] bayrakHavuzu;
        int[] bayraklar;
        List<PictureBox> acilanlar;
        List<PictureBox> kartlar;
        readonly Seviye _seviye;

        public int KartAdet { get { return satirAdet * sutunAdet; } }
        public Form1(Seviye seviye)
        {
            _seviye = seviye;
            SeviyeAyarla();
            InitializeComponent();
            acilanlar = new List<PictureBox>();
            BayrakHavuzunuDoldur();
            KartlariDiz();
        }

        private void KartlariGoster()
        {
            foreach (PictureBox item in kartlar)
                KartiAc(item);

            Thread.Sleep(2000); // todo: sure zorluk seviyesine gore ayarlanabilir.     
            pnlKartlar.Enabled = false;
            foreach (PictureBox item in kartlar)
                KartiKapat(item);

            Application.DoEvents(); // kuyruktaki eventlere gecer
            pnlKartlar.Enabled = true;
        }
        private void KartiKapat(PictureBox pb)
        {
            pb.Image = Resources.question;
        }

        private void SeviyeAyarla()
        {
            switch (_seviye)
            {
                case Seviye.Kolay:
                    satirAdet = sutunAdet = 4;
                    break;
                case Seviye.Orta:
                    satirAdet = sutunAdet = 6;
                    break;
                case Seviye.Zor:
                    satirAdet = sutunAdet = 8;
                    break;
                default:
                    throw new Exception("Olmayan bir seviye secimi yapildi!");
            }
        }

        private void BayrakHavuzunuDoldur()
        {
            bayrakHavuzu = Enumerable.Range(1, 263).ToArray();
            Islemler.Karistir(bayrakHavuzu);
        }
        private void BayraklariDoldur()
        {
            bayraklar = new int[KartAdet];
            Array.Copy(bayrakHavuzu, bayraklar, KartAdet / 2);
            Array.Copy(bayrakHavuzu, 0, bayraklar, KartAdet / 2, KartAdet / 2);
            Islemler.Karistir(bayraklar);
        }

        private void KartlariDiz()
        {
            BayraklariDoldur();

            kartlar = new List<PictureBox>();
            pnlKartlar.Width = sutunAdet * (kartBoyut + kartArasi) - kartArasi;
            pnlKartlar.Height = satirAdet * (kartBoyut + kartArasi) - kartArasi;
            ClientSize = new Size(pnlKartlar.Width + 20, pnlKartlar.Height + 20);

            for (int i = 0; i < KartAdet; i++)
            {
                PictureBox pb = new PictureBox();
                kartlar.Add(pb);
                pb.Tag = i;
                pb.Click += Pb_Click;
                // pb.Image = Properties.Resources._154;
                // pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + rast.Next(1, 264));
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = Resources.question;
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Width = kartBoyut;
                pb.Height = kartBoyut;
                pb.Left = i % sutunAdet * (kartBoyut + kartArasi);
                pb.Top = i / sutunAdet * (kartBoyut + kartArasi);
                pnlKartlar.Controls.Add(pb);
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            if (acilanlar.Count == 1 && pb == acilanlar[0])
                return; // Acilana tekrar tiklandiysa metottan cik 
            if (acilanlar.Count == 2)
                AcikOlanlariKapat();

            acilanlar.Add(pb);
            KartiAc(pb);
            if (acilanlar.Count == 2 && AcilanlarAyniysa())
            {
                Thread.Sleep(500); // Ayni olan acik kartlari gizlenmeden gorebilmek icin 
                AcikKartlariGizle();
            }
        }
        private void KartiAc(PictureBox pb)
        {
            int indeks = (int)pb.Tag;
            int bayrakNo = bayraklar[indeks];
            pb.Image = (Bitmap)Resources.ResourceManager.GetObject("_" + bayrakNo);
            pb.Refresh(); // pictureboxi guncelle 
        }

        private bool AcilanlarAyniysa()
        {
            return bayraklar[(int)acilanlar[0].Tag] == bayraklar[(int)acilanlar[1].Tag];
        }

        private void AcikKartlariGizle()
        {
            foreach (PictureBox pictureBox in acilanlar)
                pictureBox.Hide();
            acilanlar.Clear();
        }

        private void AcikOlanlariKapat()
        {
            foreach (PictureBox pictureBox in acilanlar)
                KartiKapat(pictureBox);
            acilanlar.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            KartlariGoster();
        }
    }
}
