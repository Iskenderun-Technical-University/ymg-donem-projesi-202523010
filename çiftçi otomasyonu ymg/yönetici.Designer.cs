
namespace çiftçi_otomasyonu
{
    partial class yönetici
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSatışıYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSorguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemSorguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-8, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(149, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 30);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(149, 328);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 30);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(149, 375);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(196, 30);
            this.textBox3.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 416);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 30);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.şifreDeğiştirmeToolStripMenuItem,
            this.ürünToolStripMenuItem,
            this.işlemSorguToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.kullanıcılarToolStripMenuItem.Text = "işlemler";
            this.kullanıcılarToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarToolStripMenuItem_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEklemeToolStripMenuItem,
            this.kullanıcıSilmeToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "kullanıcı işlemleri";
            // 
            // kullanıcıEklemeToolStripMenuItem
            // 
            this.kullanıcıEklemeToolStripMenuItem.Name = "kullanıcıEklemeToolStripMenuItem";
            this.kullanıcıEklemeToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.kullanıcıEklemeToolStripMenuItem.Text = "kullanıcı ekleme";
            this.kullanıcıEklemeToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEklemeToolStripMenuItem_Click);
            // 
            // kullanıcıSilmeToolStripMenuItem
            // 
            this.kullanıcıSilmeToolStripMenuItem.Name = "kullanıcıSilmeToolStripMenuItem";
            this.kullanıcıSilmeToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.kullanıcıSilmeToolStripMenuItem.Text = "kullanıcı silme";
            this.kullanıcıSilmeToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıSilmeToolStripMenuItem_Click);
            // 
            // şifreDeğiştirmeToolStripMenuItem
            // 
            this.şifreDeğiştirmeToolStripMenuItem.Name = "şifreDeğiştirmeToolStripMenuItem";
            this.şifreDeğiştirmeToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.şifreDeğiştirmeToolStripMenuItem.Text = "şifre değiştirme";
            this.şifreDeğiştirmeToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğiştirmeToolStripMenuItem_Click);
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünSatışıYapToolStripMenuItem,
            this.ürünSorguToolStripMenuItem});
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.ürünToolStripMenuItem.Text = "ürün";
            // 
            // ürünSatışıYapToolStripMenuItem
            // 
            this.ürünSatışıYapToolStripMenuItem.Name = "ürünSatışıYapToolStripMenuItem";
            this.ürünSatışıYapToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ürünSatışıYapToolStripMenuItem.Text = "ürün satışı yap";
            this.ürünSatışıYapToolStripMenuItem.Click += new System.EventHandler(this.ürünSatışıYapToolStripMenuItem_Click);
            // 
            // ürünSorguToolStripMenuItem
            // 
            this.ürünSorguToolStripMenuItem.Name = "ürünSorguToolStripMenuItem";
            this.ürünSorguToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ürünSorguToolStripMenuItem.Text = "ürün sorgu";
            this.ürünSorguToolStripMenuItem.Click += new System.EventHandler(this.ürünSorguToolStripMenuItem_Click);
            // 
            // işlemSorguToolStripMenuItem
            // 
            this.işlemSorguToolStripMenuItem.Name = "işlemSorguToolStripMenuItem";
            this.işlemSorguToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.işlemSorguToolStripMenuItem.Text = "işlem sorgu";
            this.işlemSorguToolStripMenuItem.Click += new System.EventHandler(this.işlemSorguToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "kID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kullanıcı adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(85, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre:";
            // 
            // yönetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::çiftçi_otomasyonu.Properties.Resources.e683bc76_3817_43bd_a7df_d397dcf17522_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(504, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "yönetici";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirmeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSatışıYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSorguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemSorguToolStripMenuItem;
    }
}

