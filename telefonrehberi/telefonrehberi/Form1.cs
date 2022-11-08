using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefonrehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("uzun şifre gir");
            }
            else
            {
                Textfiles textfiles = new Textfiles();
                textfiles.name = txtName.Text;
                textfiles.surname = txtSurname.Text;
                textfiles.emailAddress = txtEmailAddress.Text;
                textfiles.password = txtPassword.Text;

                if (textfiles.SaveTextFiles() == 'c')
                {
                    MessageBox.Show("başarılı kayıt");
                }
                else
                {
                    MessageBox.Show("lütfen kayıt olunuz");
                }
            }
        }
    }
}



