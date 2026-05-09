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
            showpassword = new Button();
            label_Error = new Label();
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
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(showpassword);
            panel1.Controls.Add(label_Error);
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
            // showpassword
            // 
            showpassword.BackColor = Color.White;
            showpassword.FlatAppearance.BorderSize = 0;
            showpassword.FlatStyle = FlatStyle.Flat;
            showpassword.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showpassword.ForeColor = Color.Black;
            showpassword.Location = new Point(448, 177);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(32, 27);
            showpassword.TabIndex = 11;
            showpassword.UseVisualStyleBackColor = false;
            showpassword.Click += button3_Click;
            // 
            // label_Error
            // 
            label_Error.AutoSize = true;
            label_Error.ForeColor = Color.Red;
            label_Error.Location = new Point(120, 73);
            label_Error.Name = "label_Error";
            label_Error.Size = new Size(0, 20);
            label_Error.TabIndex = 10;
            label_Error.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(74, 180);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(70, 20);
            label_Password.TabIndex = 9;
            label_Password.Text = "Mật khẩu";
            label_Password.Click += label_Password_Click;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(37, 117);
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
            label_Login.Location = new Point(175, 16);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(194, 46);
            label_Login.TabIndex = 7;
            label_Login.Text = "Đăng nhập";
            label_Login.Click += label_Login_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(280, 260);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(94, 29);
            button_Exit.TabIndex = 4;
            button_Exit.Text = "Thoát";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // button_Login
            // 
            button_Login.Location = new Point(170, 260);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(94, 29);
            button_Login.TabIndex = 3;
            button_Login.Tag = "";
            button_Login.Text = "Đăng nhập";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(180, 177);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(262, 27);
            textBox_Password.TabIndex = 2;
            textBox_Password.Tag = "";
            textBox_Password.UseSystemPasswordChar = true;
            textBox_Password.TextChanged += textBox_Password_TextChanged;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(180, 114);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(262, 27);
            textBox_Name.TabIndex = 1;
            textBox_Name.Tag = "";
            textBox_Name.TextChanged += textBox_Name_TextChanged;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 372);
            Controls.Add(panel1);
            Name = "FLogin";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label_Error;
        public Button showpassword;
    }
}
