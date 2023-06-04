using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace çiftçi_otomasyonu
{
    public partial class yönetici : Form
    {//Data Source=LAPTOP-BH2FRMKS;Initial Catalog="çiftçi otomasyonu";Integrated Security=True
        public yönetici()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
         veritabanı.gridtümünüdoldur(dataGridView1,"select*from table_üyeler");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Columns[2].Visible = false;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //textBox4.Text = dataGridView1.CurrentCell.Value.ToString(); 
        }
        private void şifreDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            şifredeğiştirme a = new şifredeğiştirme();
            this.Hide();
            a.ShowDialog();
        }

        private void kullanıcıEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ekleme a = new ekleme();
            a.ShowDialog();
        }

        private void kullanıcıSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            silme a = new silme();
            a.ShowDialog();
        }

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            işlemler a = new işlemler();
            a.ShowDialog();
        }

        private void ürünSatışıYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ürünler a = new ürünler();
            a.ShowDialog();
        }

        private void ürünSorguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ürün_sorgu a = new ürün_sorgu();
            a.ShowDialog();
        }

        private void işlemSorguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            işlemler_sorgu a = new işlemler_sorgu();
            a.ShowDialog();
        }
    }
}
