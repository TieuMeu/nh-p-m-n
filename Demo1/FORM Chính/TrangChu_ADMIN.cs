using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class TrangChu_ADMIN : Form
    {
        public TrangChu_ADMIN()
        {
            InitializeComponent();

        }
        private void hideSubMenu()
        {
            pictureBox3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login dangNhap = new Form_Login();
            dangNhap.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void loadform(object Form)
        {
            if (this.panel4.Controls.Count > 0)
                this.panel4.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(f);
            this.panel4.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new QuanLy_NV());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new QuanLy_NhapHang());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new QuanLy_DonHang());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new QuanLy_KhachHang());
            hideSubMenu();
        }
    }
}
