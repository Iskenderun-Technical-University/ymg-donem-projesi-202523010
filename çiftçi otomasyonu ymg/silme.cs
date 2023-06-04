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
    public partial class silme : Form
    {
        public silme()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            veritabanı.gridtümünüdoldur(dataGridView1, "select*from table_üyeler");
        }
        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (veritabanı.silme(Convert.ToInt32(textBox1.Text), textBox2.Text))
            {
                this.Hide();
                yönetici b = new yönetici();
                b.Show();
            }
        }
    }
}
