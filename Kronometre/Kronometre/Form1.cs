using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        int salise, saniye, dakika, saat = 0;
        int aktifSs = DateTime.Now.Millisecond, aktifSn = DateTime.Now.Second, aktifDk = DateTime.Now.Minute, aktifSa = DateTime.Now.Hour;

        bool geriSayim = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            if (!geriSayim)
            {
                timer1.Start();
                buttonBasla.Enabled = false;
                labelAktifSs.Text = aktifSs.ToString();
                labelAktifSn.Text = aktifSn.ToString();
                labelAktifDk.Text = aktifDk.ToString();
                labelAktifSa.Text = aktifSa.ToString();
            }
            else
            {
                timer1.Start();
                buttonBasla.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!geriSayim) 
            {
                salise++;
                labelSs.Text = salise.ToString();
                if (salise == 60)
                {
                    saniye++;
                    labelSn.Text = saniye.ToString();
                    salise = 0;
                }
                if (saniye == 60)
                {
                    dakika++;
                    labelDk.Text = dakika.ToString();
                    saniye = 0;
                }
                if (dakika == 60)
                {
                    saat++;
                    labelSa.Text = saat.ToString();
                    dakika = 0;
                }

                if (saniye == aktifSn && salise == aktifSs)
                {
                    timer1.Stop();
                    buttonBasla.BackColor = Color.Green;
                    buttonBasla.Enabled = true;
                    geriSayim = true;
                }
            }
            else
            {
                labelSs.Text = "0";
                labelSn.Text = "0";
                labelDk.Text = "0";
                labelSa.Text = "0";

                aktifSs--;
                if (aktifSs < 0)
                {
                    aktifSs = 59;
                    aktifSn--;
                }
                if (aktifSn < 0)
                {
                    aktifSn = 59;
                    aktifDk--;
                }
                if (aktifDk < 0)
                {
                    aktifDk = 59;
                    aktifSa--;
                }

                labelAktifSs.Text = aktifSs.ToString();
                labelAktifSn.Text = aktifSn.ToString();
                labelAktifDk.Text = aktifDk.ToString();
                labelAktifSa.Text = aktifSa.ToString();

                if (aktifSa == 0 && aktifDk == 0 && aktifSn == 0 && aktifSs == 0)
                {
                    timer1.Stop();
                    buttonBasla.Enabled = true;

                    geriSayim = false;
                    aktifSs = DateTime.Now.Millisecond; aktifSn = DateTime.Now.Second; aktifDk = DateTime.Now.Minute; aktifSa = DateTime.Now.Hour;

                    salise = saniye = dakika = saat = 0;
                    labelSs.Text = "0";
                    labelSn.Text = "0";
                    labelDk.Text = "0";
                    labelSa.Text = "0";

                    labelAktifSs.Text = aktifSs.ToString();
                    labelAktifSn.Text = aktifSn.ToString();
                    labelAktifDk.Text = aktifDk.ToString();
                    labelAktifSa.Text = aktifSa.ToString();
                }
            }
        }
    }
}