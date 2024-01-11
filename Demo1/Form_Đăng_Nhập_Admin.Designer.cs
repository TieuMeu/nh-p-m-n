namespace Demo1
{
    partial class Form_Đăng_Nhập_Admin
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 88);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(150, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 166);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng Nhập";
            // 
            // button1
            // 
            button1.Location = new Point(150, 285);
            button1.Name = "button1";
            button1.Size = new Size(98, 33);
            button1.TabIndex = 3;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(205, 33);
            label3.Name = "label3";
            label3.Size = new Size(306, 37);
            label3.TabIndex = 6;
            label3.Text = "Form Đăng Nhập Admin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(300, 285);
            button2.Name = "button2";
            button2.Size = new Size(98, 33);
            button2.TabIndex = 3;
            button2.Text = "Quên Mật Khẩu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(450, 285);
            button4.Name = "button4";
            button4.Size = new Size(98, 33);
            button4.TabIndex = 3;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // Form_Đăng_Nhập_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form_Đăng_Nhập_Admin";
            Text = "Form_Đăng_Nhập_Admin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button button4;
    }
}