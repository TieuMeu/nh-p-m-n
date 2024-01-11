namespace Demo1
{
    partial class Form_Tai_Khoan
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(321, 117);
            button1.Name = "button1";
            button1.Size = new Size(130, 40);
            button1.TabIndex = 0;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(321, 199);
            button2.Name = "button2";
            button2.Size = new Size(130, 40);
            button2.TabIndex = 1;
            button2.Text = "Nhân Viên";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(218, 36);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 2;
            label1.Text = "Form Đăng Nhập Tài Khoản";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(258, 285);
            button3.Name = "button3";
            button3.Size = new Size(253, 40);
            button3.TabIndex = 3;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form_Tai_Khoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form_Tai_Khoan";
            Text = "Form_Tai_Khoan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
    }
}