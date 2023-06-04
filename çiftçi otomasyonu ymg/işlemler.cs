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
    public partial class işlemler : Form
    {
        public işlemler()
        {
            InitializeComponent();
        }

        private void işlemler_Load(object sender, EventArgs e)
        {
            veritabanı.gridtümünüdoldur(dataGridView1, "select*from table_işlemler");
        }
    }
}
