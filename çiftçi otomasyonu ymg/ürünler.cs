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
    public partial class ürünler : Form
    {
        static SqlConnection con;
        static SqlCommand cmd, cmd1;
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataSet ds;
        public static string sqlcon = "Data Source=LAPTOP-BH2FRMKS;Initial Catalog=çiftçi otomasyonu;Integrated Security=True";

        public ürünler()
        {
            InitializeComponent();
        }
        public static int uıd;

        private void ürünler_Load(object sender, EventArgs e)
        {
            veritabanı.gridtümünüdoldur(dataGridView1, "Select*from table_ürünler where stok>0");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[1].HeaderText = "ürünler";
            label6.Text = loding.kulanıcı;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                uıd = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                label3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                label4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                label12.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                label6.Text = loding.kulanıcı;
                if (textBox3.Text != "")
                    label2.Text = (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(label4.Text)).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(textBox3.Text !="")
                label2.Text = (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(label4.Text)).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            şifredeğiştirme a = new şifredeğiştirme();
            this.Hide();
            a.ShowDialog();
        }
        public string sqlsorgu;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                sqlsorgu = "select * from table_ürünler where uad like '%" + textBox2.Text + "%' ";
                veritabanı.griddoldursorgulu(dataGridView1, sqlsorgu);
            }
            else
            {
                veritabanı.gridtümünüdoldur(dataGridView1, "Select*from table_ürünler where stok>0");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox3.Text!="")
                {
                    if (Convert.ToInt32(label12.Text) >= Convert.ToInt32(textBox3.Text))
                    {
                        con = new SqlConnection(sqlcon);
                        string sorgu = "insert into table_işlemler(uad,ibirim,ifiyat,tutar,itarih,kulanıcıadı,uıd,iaçıklama) values (@uad,@ibirim,@ifiyat,@tutar,@itarih,@kulanıcıadı,@uıd,@iaçıklama)";
                        cmd = new SqlCommand(sorgu, con);
                        cmd.Parameters.AddWithValue("@uad", label3.Text.ToString());
                        cmd.Parameters.AddWithValue("@ibirim", Convert.ToInt32(textBox3.Text));
                        cmd.Parameters.AddWithValue("@ifiyat", Convert.ToDouble(label4.Text));
                        cmd.Parameters.AddWithValue("@tutar", Convert.ToInt32(label2.Text.ToString()));
                        cmd.Parameters.AddWithValue("@itarih", DateTime.Now);
                        cmd.Parameters.AddWithValue("@kulanıcıadı", label6.Text.ToString());
                        cmd.Parameters.AddWithValue("@uıd", uıd);
                        cmd.Parameters.AddWithValue("@iaçıklama", richTextBox1.Text.ToString());
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        string sorgu2 = "update table_ürünler set stok=@stok where uıd=@uıd";
                        cmd1 = new SqlCommand(sorgu2, con);
                        cmd1.Parameters.AddWithValue("@uıd", uıd);
                        cmd1.Parameters.AddWithValue("@stok", Convert.ToInt32(label12.Text)-Convert.ToInt32(textBox3.Text));
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("satış işlemi başarıyla gerçekleşti.");
                        veritabanı.gridtümünüdoldur(dataGridView1, "Select*from table_ürünler where stok>0");
                        textBox3.Clear();
                        richTextBox1.Clear();
                        işlemler_üye a = new işlemler_üye();
                        a.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("stokta yeterli adete bulunmuyor ");
                    }

                }
                else
                {
                    MessageBox.Show("stok giriniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
