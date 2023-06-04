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
    public partial class loding : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static DataSet ds;
        public static string yetki;
        public static string sqlcon = "Data Source=LAPTOP-BH2FRMKS;Initial Catalog=çiftçi otomasyonu;Integrated Security=True";
        public static string kulanıcı;
        public loding()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int denemesayısı = 0;
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (veritabanı.lodingkontrol(textBox1.Text, textBox2.Text))
            {
                kulanıcı = textBox1.Text;
                con = new SqlConnection(sqlcon);
                string sorgu = "select yetki from table_üyeler where kulanıcıadı='"+textBox1.Text+"' and şifre='"+veritabanı.md5şifreleme(textBox2.Text)+"'";
                da = new SqlDataAdapter(sorgu, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Tables[0]");
                con.Close();
                dataGridView1.DataSource= ds.Tables[0];
                yetki = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (yetki=="1")
                {
                    MessageBox.Show("giriş başarılı...");
                    this.Hide();
                    yönetici a = new yönetici();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("giriş başarılı...");
                    this.Hide();
                    ürünler a = new ürünler();
                    a.Show();
                }
            }
            else
            {
                denemesayısı++;
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                MessageBox.Show("kullanıcı adı ya da şifre yanlış...");
                if (denemesayısı == 3)
                {
                    MessageBox.Show("3 defa hatalı giriş yaptınız.");
                    Application.Exit();
                }

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
