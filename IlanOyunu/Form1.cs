using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IlanOyunu
{
    public partial class Form1 : Form
    {
        const int EN = 30;      // panelin eni (ilanın və yemin ölçüsü)
        const int HUND = 20;    // panelin hündürlüyü

        List<Panel> ilan = new List<Panel>();   // ilanın panelləri (0-cı indeks = baş)
        Panel yem;
        Random rnd = new Random();

        int dx = 0, dy = 0;     // hərəkət istiqaməti
        int xal = 0;
        bool oyunGedir = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YeniOyun();
        }

        // ---------- Panel yaratmaq ----------
        private Panel PanelYarat()
        {
            Panel p = new Panel();
            p.Size = new Size(EN, HUND);
            p.BackColor = Color.Black;
            panelOyun.Controls.Add(p);
            return p;
        }

        // ---------- Yeni oyun (xal sıfırlanır) ----------
        private void YeniOyun()
        {
            timer1.Stop();
            oyunGedir = false;

            foreach (Panel p in ilan)
            {
                panelOyun.Controls.Remove(p);
                p.Dispose();
            }
            ilan.Clear();

            if (yem != null)
            {
                panelOyun.Controls.Remove(yem);
                yem.Dispose();
                yem = null;
            }

            xal = 0;
            lblXal.Text = "0";
            dx = 0;
            dy = 0;

            // ilanın başı - ortada
            Panel bas = PanelYarat();
            bas.Location = new Point(
                (panelOyun.ClientSize.Width / EN / 2) * EN,
                (panelOyun.ClientSize.Height / HUND / 2) * HUND);
            ilan.Add(bas);

            YemYerlestir();
        }

        // ---------- Yemi təsadüfi yerə qoymaq ----------
        private void YemYerlestir()
        {
            yem = PanelYarat();
            int sutun = panelOyun.ClientSize.Width / EN;
            int setir = panelOyun.ClientSize.Height / HUND;

            do
            {
                yem.Location = new Point(rnd.Next(sutun) * EN, rnd.Next(setir) * HUND);
            }
            while (ilan.Any(p => p.Location == yem.Location));
        }

        // ---------- İstiqamət seçmək / oyunu başlatmaq ----------
        private void IstiqametVer(int x, int y)
        {
            // ilan uzundursa, əks istiqamətə dönə bilməz
            if (ilan.Count > 1 && x == -dx && y == -dy)
                return;

            dx = x;
            dy = y;

            if (!oyunGedir)
            {
                oyunGedir = true;
                timer1.Start();   // ok düyməsi ilə oyun başlayır
            }
        }

        // ---------- Timer: ilanın hərəkəti ----------
        private void timer1_Tick(object sender, EventArgs e)
        {
            Panel bas = ilan[0];
            Point yeniYer = new Point(bas.Left + dx * EN, bas.Top + dy * HUND);

            // panelin sərhədlərinə dəydi -> oyun bitir
            if (yeniYer.X < 0 || yeniYer.Y < 0 ||
                yeniYer.X + EN > panelOyun.ClientSize.Width ||
                yeniYer.Y + HUND > panelOyun.ClientSize.Height)
            {
                OyunBitdi();
                return;
            }

            // özünə dəydi -> oyun bitir
            if (ilan.Any(p => p.Location == yeniYer))
            {
                OyunBitdi();
                return;
            }

            if (yeniYer == yem.Location)
            {
                // yem yeyildi: yem paneli ilanın başı olur (ilan bir panel qədər böyüyür)
                ilan.Insert(0, yem);
                xal++;
                lblXal.Text = xal.ToString();
                YemYerlestir();
            }
            else
            {
                // quyruq paneli başın qarşısına keçir
                Panel quyruq = ilan[ilan.Count - 1];
                ilan.RemoveAt(ilan.Count - 1);
                quyruq.Location = yeniYer;
                ilan.Insert(0, quyruq);
            }
        }

        private void OyunBitdi()
        {
            timer1.Stop();
            MessageBox.Show("Oyun bitdi! Xalınız: " + xal, "İlan oyunu");
            YeniOyun();   // xal sıfırlanır, ok düyməsi ilə yenidən başlayır
        }

        // ---------- Ekrandakı ox düymələri ----------
        private void btnYuxari_Click(object sender, EventArgs e) { IstiqametVer(0, -1); }
        private void btnAsagi_Click(object sender, EventArgs e)  { IstiqametVer(0, 1); }
        private void btnSola_Click(object sender, EventArgs e)   { IstiqametVer(-1, 0); }
        private void btnSaga_Click(object sender, EventArgs e)   { IstiqametVer(1, 0); }

        private void btnCixis_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ---------- Klaviaturadakı ox düymələri ----------
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:    IstiqametVer(0, -1); return true;
                case Keys.Down:  IstiqametVer(0, 1);  return true;
                case Keys.Left:  IstiqametVer(-1, 0); return true;
                case Keys.Right: IstiqametVer(1, 0);  return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
