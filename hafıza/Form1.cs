using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafıza
{

    public partial class Form1 : Form
    {
    
   
    private List<Button> secilenler = new List<Button>();
    

        public Form1()
        {
            InitializeComponent();
        }
        public int sure = 0;

        public int hata_sayisi = 0;



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnBaslat_Click(object sender, EventArgs e)
        {

            timer1.Start();
            List<int> sayilar = new List<int>();
            Random rastgeleSayi = new Random();//rastgele sayı üretiyor
            for (int i = 1; i <= (Convert.ToInt32(txtYatay.Text) * Convert.ToInt32(txtDikey.Text)) / 2; i++)
            {
                sayilar.Add(i);
                sayilar.Add(i);
            }


            for (int i = 0; i < Convert.ToInt32(txtYatay.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt32(txtDikey.Text); j++)
                {
                    int gelensayi = rastgeleSayi.Next(0, sayilar.Count);
                    Button buton = new Button
                    {
                        Name = sayilar[gelensayi].ToString(),
                        Text = null,
                        Tag = sayilar[gelensayi].ToString(),
                        Height = 60,
                        Width = 60,
                        Top = (j) * 60 + 20,
                        Left = (i) * 60 + 10,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        ForeColor = Color.Red,
                        BackColor=Color.Yellow,
                        


                    };
                    buton.Click += Buton_Click;//event ediyoruz
                    groupBox1.Controls.Add(buton);
                    var secilen = sayilar[gelensayi];
                    sayilar.Remove(secilen);
                }
            }

        }

        private void Buton_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            if (string.IsNullOrEmpty(buton.Text))
            {
                buton.Text = buton.Name;
                secilenler.Add(buton);
                buton.Refresh();
            }
          
            if (secilenler.Count == 2)
            {

                System.Threading.Thread.Sleep(500);

                if (secilenler[0].Text == secilenler[1].Text)
                {
                    secilenler[0].Dispose();
                    secilenler[1].Dispose();
                    if(groupBox1.Controls.Count==0)
                    {
                        timer1.Stop();
                        MessageBox.Show("tebrikler kazandınız"+sure+ " saniyede bitirdiniz");
                    }
                   
                }
                else if (secilenler[0].Text != secilenler[1].Text)
                {

                    hata_sayisi += 1;
                    lbl_Hatasayisi.Text = "Hata Sayısı: " + hata_sayisi.ToString();
                    secilenler[0].Text = null;
                    secilenler[1].Text = null;
                   

                }
                secilenler.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            sure = sure+1;
            süre.Text = sure.ToString();

            süre.Text = Convert.ToString("SÜRE: " + sure);
           
        }

    }
}
