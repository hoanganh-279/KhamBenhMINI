namespace KhamBenhMINI
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label_Password = new Label();
            label_Name = new Label();
            label_Login = new Label();
            button_Exit = new Button();
            button_Login = new Button();
            textBox_Password = new TextBox();
            textBox_Name = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label_Password);
            panel1.Controls.Add(label_Name);
            panel1.Controls.Add(label_Login);
            panel1.Controls.Add(button_Exit);
            panel1.Controls.Add(button_Login);
            panel1.Controls.Add(textBox_Password);
            panel1.Controls.Add(textBox_Name);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 348);
            panel1.TabIndex = 7;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(55, 161);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(70, 20);
            label_Password.TabIndex = 9;
            label_Password.Text = "Mật khẩu";
            label_Password.Click += label_Password_Click;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(55, 99);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(107, 20);
            label_Name.TabIndex = 8;
            label_Name.Text = "Tên đăng nhập";
            label_Name.Click += label_Name_Click;
            // 
            // label_Login
            // 
            label_Login.AutoSize = true;
            label_Login.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Login.Location = new Point(177, 17);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(194, 46);
            label_Login.TabIndex = 7;
            label_Login.Text = "Đăng nhập";
            label_Login.Click += label_Login_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(295, 250);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(94, 29);
            button_Exit.TabIndex = 6;
            button_Exit.Text = "Thoát";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // button_Login
            // 
            button_Login.Location = new Point(109, 250);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(94, 29);
            button_Login.TabIndex = 5;
            button_Login.Text = "Đăng nhập";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(177, 161);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(262, 27);
            textBox_Password.TabIndex = 4;
            textBox_Password.TextChanged += textBox_Password_TextChanged;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(177, 96);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(262, 27);
            textBox_Name.TabIndex = 3;
            textBox_Name.TextChanged += textBox_Name_TextChanged;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 372);
            Controls.Add(panel1);
            Name = "FLogin";
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_Exit;
        private Button button_Login;
        private TextBox textBox_Password;
        private TextBox textBox_Name;
        private Label label_Password;
        private Label label_Name;
        private Label label_Login;
    }
}
