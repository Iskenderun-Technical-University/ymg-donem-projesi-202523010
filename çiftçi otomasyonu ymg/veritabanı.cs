using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //sql kütüphanesi
using System.Windows.Forms; //
using System.Data;//
using System.Security.Cryptography;// şifreleme kutuphanesi

namespace çiftçi_otomasyonu
{
    class veritabanı
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string sqlcon = "Data Source=LAPTOP-BH2FRMKS;Initial Catalog=çiftçi otomasyonu;Integrated Security=True";
        public static bool ekleme(string kulanıcı, string şifre, int yetki)
        {
            con = new SqlConnection(sqlcon);
            cmd = new SqlCommand();
            string komut = "insert into table_üyeler(kulanıcıadı,şifre,kayıttarihi,yetki) values(@user,@pass,@time,@yetki)";
            cmd.Parameters.AddWithValue("@user", kulanıcı);
            cmd.Parameters.AddWithValue("@pass", veritabanı.md5şifreleme(şifre));
            cmd.Parameters.AddWithValue("@time", DateTime.Now);
            cmd.Parameters.AddWithValue("@yetki", yetki);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = komut;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public static bool şifredeğiştirme(string kulanıcı, string şifre)
        {
            con = new SqlConnection(sqlcon);
            cmd = new SqlCommand();
            string komut = "update table_üyeler set şifre=@pass where kulanıcıadı=@user";
            cmd.Parameters.AddWithValue("@user", kulanıcı);
            cmd.Parameters.AddWithValue("@pass", şifre);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = komut;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
         }
        public static bool silme(int kıd,string kulanıcı)
        {
            con = new SqlConnection(sqlcon);
            string komut = "delete from table_üyeler where kıd=@kıd and kulanıcıadı=@user";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Kıd", kıd);
            cmd.Parameters.AddWithValue("@user", kulanıcı);
            con.Open();
            cmd.Connection= con;
            cmd.CommandText = komut;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("silme işlemi başarıyla gerçekleşti");
            return true;
        }
        public static bool lodingkontrol(string kulanıcıadı,string şifre)
        {
            string sorgu = "select*from table_üyeler Where kulanıcıadı=@user and şifre=@pass";
            con = new SqlConnection(sqlcon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kulanıcıadı);
            cmd.Parameters.AddWithValue("@pass", veritabanı.md5şifreleme(şifre));
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }       
        }
        public static DataGridView gridtümünüdoldur(DataGridView gridim ,string tabloismi)
        {
            con = new SqlConnection(sqlcon);
            da = new SqlDataAdapter(tabloismi, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds,tabloismi);
            gridim.DataSource = ds.Tables[tabloismi];
            con.Close();
            return gridim;
        }
        public static DataGridView griddoldursorgulu(DataGridView gridim, string sqlsorgu)
        {
            con = new SqlConnection(sqlcon);
            da = new SqlDataAdapter(sqlsorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            gridim.DataSource = ds.Tables[0];
            con.Close();
            return gridim;
        }
        public static string md5şifreleme(string şifre)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(şifre);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
            {
                sb.Append(item.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        public static string sha256şifreleme(string şifre)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] dizi = Encoding.UTF8.GetBytes(şifre);
            dizi = sha256.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
            {
                sb.Append(item.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}
