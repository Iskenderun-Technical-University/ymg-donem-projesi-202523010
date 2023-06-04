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
    public partial class işlemler_sorgu : Form
    {
        public işlemler_sorgu()
        {
            InitializeComponent();
        }
        public string sqlsorgu;
        private void işlemler_sorgu_Load(object sender, EventArgs e)
        {
            veritabanı.gridtümünüdoldur(dataGridView1, "select*from table_işlemler");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (radioButton1.Checked)
                {
                    sqlsorgu = "select*from table_işlemler where uad like'%" + textBox1.Text + "%'";
                    veritabanı.griddoldursorgulu(dataGridView1, sqlsorgu);
                }
                else if (radioButton2.Checked)
                {
                    sqlsorgu = "select*from table_işlemler where tutar<'" + Convert.ToDouble(textBox1.Text) + "'";
                    veritabanı.griddoldursorgulu(dataGridView1, sqlsorgu);
                }
                else if (radioButton3.Checked)
                {
                    sqlsorgu = "select*from table_işlemler where kulanıcıadı like'%" + textBox1.Text + "%'";
                    veritabanı.griddoldursorgulu(dataGridView1, sqlsorgu);
                }
            }
            else
            {
                veritabanı.gridtümünüdoldur(dataGridView1, "select*from table_işlemler");
            }

        }

    }
}
