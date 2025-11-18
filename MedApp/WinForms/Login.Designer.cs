namespace WinForms
{
    partial class Login
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
            label_login = new Label();
            label_password = new Label();
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            button_login = new Button();
            SuspendLayout();
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Location = new Point(150, 120);
            label_login.Name = "label_login";
            label_login.Size = new Size(44, 15);
            label_login.TabIndex = 0;
            label_login.Text = "Логин:";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(150, 170);
            label_password.Name = "label_password";
            label_password.Size = new Size(52, 15);
            label_password.TabIndex = 1;
            label_password.Text = "Пароль:";
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(220, 117);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(230, 23);
            textBox_login.TabIndex = 2;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(220, 167);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(230, 23);
            textBox_password.TabIndex = 3;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.Location = new Point(220, 230);
            button_login.Name = "button_login";
            button_login.Size = new Size(160, 30);
            button_login.TabIndex = 4;
            button_login.Text = "Авторизоваться";
            button_login.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Controls.Add(label_password);
            Controls.Add(label_login);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_login;
        private Label label_password;
        private TextBox textBox_login;
        private TextBox textBox_password;
        private Button button_login;
    }
}