using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace hafıza
{
    public partial class Form2 : Form
    {
        Label bırıncıTıklama = null;
        Label ıkıncıTıklama = null;



        Random random = new Random();//kutular için rastgele simgeler seçiyor
        List<string> resım = new List<string>()
    {
        "A", "A", "B", "B", "C", "C", "k", "k","N", "N", "Z", "Z", "v", "v", "a", "a", "b", "b",//her bir simge iki kez görüntüleniyor
        "E", "E", "z", "z", "w", "w", "H", "H","d", "d", "e", "e", "f", "f", "y", "y","h", "h"
    };
        private void ResimleriAta()// resimleri rastgele kutulara atıyor
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label resim_etiket = control as Label;//resim_etiketine dönüştürüyor
                if (resim_etiket != null)//
                {
                    int randomNumber = random.Next(resım.Count);
                    resim_etiket.Text = resım[randomNumber];
                    resım.RemoveAt(randomNumber);//forma eklenen listeyi listeden siliyor.tekrar kullanılmasın diye
                    resim_etiket.ForeColor = resim_etiket.BackColor;
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
            ResimleriAta();
            
        }
        public
          int sure = 0;
        int kalan_hak = 15;

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_hak.Text = "Kalan hakkınız"+kalan_hak.ToString();
        }

        private void lblKutu1_Click(object sender, EventArgs e)
        {
           
            if (timer1.Enabled == true)
                return;

            Label tıklananResim = sender as Label;

            if (tıklananResim != null)//aynı kutuya iki kez tıklamayı önlüyor
            {
                
               
                if (tıklananResim.ForeColor == Color.Black)
                    return;

             
                if (bırıncıTıklama == null) // eğer null ise bu birinci resimdir
                {
                    bırıncıTıklama = tıklananResim;
                    bırıncıTıklama.ForeColor = Color.Black;
                    return;
                }


                ıkıncıTıklama = tıklananResim;//ikinci tıklanan boş değil
                ıkıncıTıklama.ForeColor = Color.Black;


              
                kazanmaDurumu();
                if (bırıncıTıklama.Text == ıkıncıTıklama.Text)
                {
                    bırıncıTıklama = null;// tıklananları null ediyorum ki başka resime tıklayabilsin
                    ıkıncıTıklama = null;
                    return;
                  
                }
                else
                {
                    string temp1 = bırıncıTıklama.Text;
                    bırıncıTıklama.Text = ıkıncıTıklama.Text;//temp özelliğini kullanarak seçilen iki resim eş değilse birbiriyle yer değişiyor
                    ıkıncıTıklama.Text = temp1;
                    kalan_hak -= 1;
                    lbl_hak.Text = "Kalan hakkınız: " + kalan_hak.ToString();
                    if(kalan_hak==0)
                    {
                        MessageBox.Show("hakkınız bitti,oyunu kaybettiniz");
                    }
                //
                }

                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            timer1.Stop();


            bırıncıTıklama.ForeColor = bırıncıTıklama.BackColor;
            ıkıncıTıklama.ForeColor = ıkıncıTıklama.BackColor;


            bırıncıTıklama = null;
            ıkıncıTıklama = null;
        }
        private void kazanmaDurumu()
        {
          
            foreach (Control control in tableLayoutPanel1.Controls)//paneli kontrol ediyorum. eğer tekrar döngüye girmezse kazandı anlamına gelir
            {
                Label resim_etiket = control as Label;

                if (resim_etiket != null)
                {
                    if (resim_etiket.ForeColor == resim_etiket.BackColor)
                        return;
                }
            }

            timer2.Stop();
            MessageBox.Show("tebrikler kazandınız" +sure+ " saniyede bitirdiniz ");
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            sure = sure + 1;
            süre.Text = sure.ToString();

            süre.Text = Convert.ToString("SÜRE: " + sure);
        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            timer2.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Enabled = true;
        }
    }
}

  