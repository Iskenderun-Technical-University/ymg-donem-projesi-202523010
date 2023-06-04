using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çiftçi_otomasyonu
{
    public partial class şifredeğiştirme : Form
    {
        public şifredeğiştirme()
        {
            InitializeComponent();
        }
        public int toplam;
        public void rasgele()
        {
            Random rnd = new Random();
            int rasgele1 = rnd.Next(0, 50);
            int rasgele2 = rnd.Next(0, 50);
            label1.Text = rasgele1+" + "+ rasgele2.ToString();
            toplam = rasgele1 + rasgele2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (toplam.ToString() == textBox1.Text)
            {
                string ab = loding.kulanıcı;
                if (veritabanı.lodingkontrol(ab, textBox2.Text))
                {
                    if (textBox3.Text == "" && textBox4.Text == "")
                    {
                        textBox2.Enabled = false;
                        MessageBox.Show("yeni şifre boş geçilemez!");
                    }
                    if (textBox3.Text == textBox4.Text)
                    {
                        if (veritabanı.şifredeğiştirme(ab, veritabanı.md5şifreleme(textBox3.Text)))
                        {
                            MessageBox.Show("şifre değiştirme işlemi başarıyla gerçekleşti.");
                            this.Hide();
                            yönetici a = new yönetici();
                            a.Show();
                        }
                    }
                    else
                    {
                        textBox2.Enabled = false;
                        MessageBox.Show("girilen yeni şifre birbiriyle uyşmuyor");
                        rasgele();
                    }
                }
                else
                {
                    MessageBox.Show("eski şifre hatalı.");
                    textBox1.Clear();
                    textBox2.Clear();
                    rasgele();
                }
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("cahpcaht değrei hatalı..");
                rasgele();
            } 
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            rasgele();
        }
    }
}
