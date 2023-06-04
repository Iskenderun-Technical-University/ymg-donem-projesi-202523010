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
    public partial class işlemler_üye : Form
    {
        public işlemler_üye()
        {
            InitializeComponent();
        }
        public string sqlsorgu;
        private void işlemler_üye_Load(object sender, EventArgs e)
        {
            sqlsorgu = "select*from table_işlemler where kulanıcıadı='" + loding.kulanıcı + "'";
            veritabanı.griddoldursorgulu(dataGridView1, sqlsorgu);
        }
    }
}
