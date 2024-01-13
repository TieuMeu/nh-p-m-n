using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Demo1
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        bool menuExpand1 = false;
        bool menuExpand2 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_NhanVien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_NV_Tradi_Tick(object sender, EventArgs e)
        {
            if (menuExpand1 == false)
            {
                Login_NhanVien.Height += 10;
                if (Login_NhanVien.Height >= 300)
                {
                    Login_NV_Tradi.Stop();
                    menuExpand1 = true;
                }
            }
            else
            {
                Login_NhanVien.Height -= 10;
                if (Login_NhanVien.Height <= 60)
                {
                    Login_NV_Tradi.Stop();
                    menuExpand1 = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_NV_Tradi.Start();
        }

        private void Login_AD_Tradi_Tick(object sender, EventArgs e)
        {
            if (menuExpand2 == false)
            {
                Login_ADMIN.Height += 10;
                if (Login_ADMIN.Height >= 300)
                {
                    Login_AD_Tradi.Stop();
                    menuExpand2 = true;
                }
            }
            else
            {
                Login_ADMIN.Height -= 10;
                if (Login_ADMIN.Height <= 60)
                {
                    Login_AD_Tradi.Stop();
                    menuExpand2 = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login_AD_Tradi.Start();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(128, 255, 255, 255);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
        }

        private void bt_Login_AD_Click(object sender, EventArgs e)
        {
            TrangChu_ADMIN admin = new TrangChu_ADMIN();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void bt_Login_NV_Click(object sender, EventArgs e)
        {
            TrangChu_NhanVien nv = new TrangChu_NhanVien();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }
    }
}

