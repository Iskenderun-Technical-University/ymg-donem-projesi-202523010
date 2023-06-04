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
    public partial class ürün_sorgu : Form
    {
        public ürün_sorgu()
        {
            InitializeComponent();
        }
        public string sqlsorgu;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (radioButton1.Checked)
                {
                    sqlsorgu = "select*from table_ürünler where uad like'%" + textBox1.Text + "%'";
                    veritabanı.griddoldursorgulu(dataGridView1, sqlsorgu);
                }
                else if (radioButton2.Checked)
                {
                    sqlsorgu = "select*from table_ürünler where fiyat>'"+ Convert.ToDouble(textBox1.Text) + "'";
                    veritabanı.griddoldursorgulu(dataGridView1, sqlsorgu);
                }
                else if (radioButton3.Checked)
                {
                    sqlsorgu = "select*from table_ürünler where stok<'" + Convert.ToInt32(textBox1.Text) + "'";
                    veritabanı.griddoldursorgulu(dataGridView1, sqlsorgu);
                }
            }
            else
            {
                veritabanı.gridtümünüdoldur(dataGridView1, "select*from table_ürünler");
            }
        }

        private void ürün_sorgu_Load(object sender, EventArgs e)
        {
            veritabanı.gridtümünüdoldur(dataGridView1, "select*from table_ürünler");
        }
    }
}
