namespace Demo1
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Login_ADMIN = new FlowLayoutPanel();
            button4 = new Button();
            panel5 = new Panel();
            pictureBox6 = new PictureBox();
            textBox1 = new TextBox();
            panel6 = new Panel();
            pictureBox7 = new PictureBox();
            textBox2 = new TextBox();
            bt_Login_AD = new Button();
            pictureBox8 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Login_NhanVien = new FlowLayoutPanel();
            button3 = new Button();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            txt_username = new TextBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            txt_password = new TextBox();
            bt_Login_NV = new Button();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            Login_NV_Tradi = new System.Windows.Forms.Timer(components);
            Login_AD_Tradi = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            Login_ADMIN.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            Login_NhanVien.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 800);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Login_ADMIN);
            flowLayoutPanel1.Controls.Add(pictureBox8);
            flowLayoutPanel1.Location = new Point(32, 326);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(370, 373);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // Login_ADMIN
            // 
            Login_ADMIN.Controls.Add(button4);
            Login_ADMIN.Controls.Add(panel5);
            Login_ADMIN.Controls.Add(panel6);
            Login_ADMIN.Controls.Add(bt_Login_AD);
            Login_ADMIN.Location = new Point(3, 4);
            Login_ADMIN.Margin = new Padding(3, 4, 3, 4);
            Login_ADMIN.Name = "Login_ADMIN";
            Login_ADMIN.Size = new Size(355, 80);
            Login_ADMIN.TabIndex = 3;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 4);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(352, 76);
            button4.TabIndex = 1;
            button4.Text = " ADMIN";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            button4.MouseEnter += button4_MouseEnter;
            button4.MouseLeave += button4_MouseLeave;
            button4.MouseHover += button4_MouseHover;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDarkDark;
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(3, 88);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(352, 65);
            panel5.TabIndex = 4;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(6, 7);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 51);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlDarkDark;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(63, 17);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "user";
            textBox1.Size = new Size(272, 25);
            textBox1.TabIndex = 0;
            textBox1.Tag = "";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDarkDark;
            panel6.Controls.Add(pictureBox7);
            panel6.Controls.Add(textBox2);
            panel6.Location = new Point(3, 161);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(352, 65);
            panel6.TabIndex = 5;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(7, 8);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(50, 48);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlDarkDark;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(63, 17);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "pass";
            textBox2.Size = new Size(272, 25);
            textBox2.TabIndex = 0;
            textBox2.UseSystemPasswordChar = true;
            // 
            // bt_Login_AD
            // 
            bt_Login_AD.FlatStyle = FlatStyle.Flat;
            bt_Login_AD.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Login_AD.ForeColor = Color.White;
            bt_Login_AD.Location = new Point(3, 234);
            bt_Login_AD.Margin = new Padding(3, 4, 3, 4);
            bt_Login_AD.Name = "bt_Login_AD";
            bt_Login_AD.Size = new Size(352, 51);
            bt_Login_AD.TabIndex = 6;
            bt_Login_AD.Text = "LOGIN";
            bt_Login_AD.UseVisualStyleBackColor = true;
            bt_Login_AD.Click += bt_Login_AD_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 92);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(355, 49);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 4;
            pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(127, 57);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(450, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 800);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(Login_NhanVien);
            flowLayoutPanel2.Controls.Add(pictureBox5);
            flowLayoutPanel2.Location = new Point(53, 326);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(370, 373);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // Login_NhanVien
            // 
            Login_NhanVien.Controls.Add(button3);
            Login_NhanVien.Controls.Add(panel3);
            Login_NhanVien.Controls.Add(panel4);
            Login_NhanVien.Controls.Add(bt_Login_NV);
            Login_NhanVien.Location = new Point(3, 4);
            Login_NhanVien.Margin = new Padding(3, 4, 3, 4);
            Login_NhanVien.Name = "Login_NhanVien";
            Login_NhanVien.Size = new Size(355, 80);
            Login_NhanVien.TabIndex = 3;
            Login_NhanVien.Paint += Login_NhanVien_Paint;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(3, 4);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(352, 76);
            button3.TabIndex = 1;
            button3.Text = " Nhân Viên";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(txt_username);
            panel3.Location = new Point(3, 88);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 65);
            panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 7);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.ButtonFace;
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(63, 17);
            txt_username.Margin = new Padding(3, 4, 3, 4);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "user";
            txt_username.Size = new Size(272, 25);
            txt_username.TabIndex = 0;
            txt_username.Tag = "";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(txt_password);
            panel4.Location = new Point(3, 161);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(352, 65);
            panel4.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(7, 8);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.ButtonFace;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(63, 17);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "pass";
            txt_password.Size = new Size(272, 25);
            txt_password.TabIndex = 0;
            txt_password.UseSystemPasswordChar = true;
            // 
            // bt_Login_NV
            // 
            bt_Login_NV.FlatStyle = FlatStyle.Flat;
            bt_Login_NV.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Login_NV.Location = new Point(3, 234);
            bt_Login_NV.Margin = new Padding(3, 4, 3, 4);
            bt_Login_NV.Name = "bt_Login_NV";
            bt_Login_NV.Size = new Size(352, 51);
            bt_Login_NV.TabIndex = 6;
            bt_Login_NV.Text = "LOGIN";
            bt_Login_NV.UseVisualStyleBackColor = true;
            bt_Login_NV.Click += bt_Login_NV_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 92);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(367, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(385, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(69, 62);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(127, 23);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(213, 303);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Login_NV_Tradi
            // 
            Login_NV_Tradi.Interval = 20;
            Login_NV_Tradi.Tick += Login_NV_Tradi_Tick;
            // 
            // Login_AD_Tradi
            // 
            Login_AD_Tradi.Interval = 20;
            Login_AD_Tradi.Tick += Login_AD_Tradi_Tick;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 800);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Login";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            Login_ADMIN.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            Login_NhanVien.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
        private PictureBox pictureBox2;
        private FlowLayoutPanel Login_NhanVien;
        private Panel panel3;
        private TextBox txt_username;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox3;
        private Panel panel4;
        private PictureBox pictureBox4;
        private TextBox txt_password;
        private System.Windows.Forms.Timer Login_NV_Tradi;
        private PictureBox pictureBox5;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel Login_ADMIN;
        private Button button4;
        private Panel panel5;
        private PictureBox pictureBox6;
        private TextBox textBox1;
        private Panel panel6;
        private PictureBox pictureBox7;
        private TextBox textBox2;
        private PictureBox pictureBox8;
        private System.Windows.Forms.Timer Login_AD_Tradi;
        private Button bt_Login_AD;
        private Button bt_Login_NV;
    }
}