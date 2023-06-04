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
    public partial class ekleme : Form
    {
        public ekleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
                MessageBox.Show("kullanıcı adı , şifre ve yetki boş geçilemez!");
            else
            {
                int yetki = comboBox1.SelectedIndex;
                if (veritabanı.ekleme(textBox1.Text, textBox2.Text,yetki))
                {
                    MessageBox.Show("yeni kullanıcı ekeleme işlemi başarıyla gerçekleşti.");
                    this.Hide();
                    yönetici a = new yönetici();
                    a.Show();
                }
            }
        }
    }
}
