using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace telefonrehberi
{
    public partial class Form3 : Form
    {
        public string dosya_yolu = @"C:\metinbelgesi.txt";
     

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kaydet_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAD.Text))
                MessageBox.Show("lütfen adı giriniz");
            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
                MessageBox.Show(" lütfen soyadı giriniz");
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
                MessageBox.Show("lütfen telefon numarasını giriniz");


            else
            {
                string kayit = txtId.Text + "," + txtAD.Text + "," + txtSoyad.Text + "," + txtPhone.Text + "," + txtTarih.Text ;

                dosyayaYaz(kayit);

                MessageBox.Show("Kayit Tamamlandi");

            }

        }
        private void dosyayaYaz(string yazim)
        {


            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);


            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(yazim);


            sw.Flush();

            sw.Close();
            fs.Close();

        }

        private void kayitlar_Click(object sender, EventArgs e)
        {
            Kayitlar();
        }
        public List<Rehber> KayitGetir()
        {
            List<Rehber> telefonRehber = new List<Rehber>();
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                try
                {
                    string[] reh = yazi.Split(',');
                    Rehber kisi = new Rehber();
                    kisi.Id = reh[0];
                    kisi.Ad = reh[1];
                    kisi.Soyad = reh[2];
                    kisi.Phone = reh[3];
                    kisi.Tarih = reh[4];

                    telefonRehber.Add(kisi);
                }
                catch (Exception)
                {

                   
                }

                yazi = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
            return telefonRehber;
        }
        public void Kayitlar()
        {

            var telefonRehber = KayitGetir();

            telefonRehber = telefonRehber.OrderBy(p => p.Soyad).ToList();
            dataGridRehber.DataSource = telefonRehber;
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            if (txtAra.Text.Equals(""))
                MessageBox.Show("lütfen aramak istediğiniz kişiyi girin");
            else
            {
                string ara = txtAra.Text.ToLower();
                var telefonRehber = KayitGetir();

                List<Rehber> filtered = new List<Rehber>();

                telefonRehber = telefonRehber.OrderBy(p => p.Soyad).ToList();

                for (int i = 0; i < telefonRehber.Count; i++)
                {
                    var rehber = telefonRehber[i];

                    if (rehber.Ad.ToLower().Contains(ara) || rehber.Soyad.ToLower().Contains(ara) || rehber.Phone.Contains(ara))
                    {
                        filtered.Add(rehber);

                    }
                }
                dataGridRehber.DataSource = filtered;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "excel dosyası |*.xlsx| excel dosyası|*.xls";
            file.Title = "dosya seç";

            if (file.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection baglan;
                baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file.FileName + ";Extended Properties='Excel 12.0 xml;HDR=YES;'");
                baglan.Open();
                OleDbDataAdapter adap = new OleDbDataAdapter("Select * from[Sayfa1$]", baglan);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridRehber.DataSource = dt;
                baglan.Close();
            }

        }


        private void dataGridRehber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridRehber.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAD.Text = dataGridRehber.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridRehber.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dataGridRehber.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTarih.Text = dataGridRehber.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(dataGridRehber.SelectedRows.Count > 0)
            {
                dataGridRehber.Rows.RemoveAt(dataGridRehber.SelectedRows[0].Index);

            }

            else

            {
                MessageBox.Show("geçersiz işlem");

            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtId.Clear();
            txtAD.Clear();
            txtSoyad.Clear();
            txtPhone.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextWriter sw = new StreamWriter(@"C:\metinbelgesi.txt", true);
            int rowcount = dataGridRehber.Rows.Count;
            for (int i = 0; i < rowcount - 0; i++)
            {
                sw.WriteLine(dataGridRehber.Rows[i].Cells[1].Value.ToString() + "\t"
                 + dataGridRehber.Rows[i].Cells[2].Value.ToString() + "\t"
                 + dataGridRehber.Rows[i].Cells[4].Value.ToString() + "\t");
            }
            sw.Close();
            MessageBox.Show("başarıyla güncellendi");
        }
    }
}

        
    


 