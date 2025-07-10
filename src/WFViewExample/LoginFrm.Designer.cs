namespace WFViewExample
{
    partial class LoginFrm
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
            LoginBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            UserTxt = new TextBox();
            PasswordTxt = new TextBox();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(463, 336);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(130, 50);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 88);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 163);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // UserTxt
            // 
            UserTxt.Location = new Point(215, 88);
            UserTxt.Name = "UserTxt";
            UserTxt.Size = new Size(125, 27);
            UserTxt.TabIndex = 3;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(215, 160);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.Size = new Size(125, 27);
            PasswordTxt.TabIndex = 4;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PasswordTxt);
            Controls.Add(UserTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Name = "LoginFrm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private Label label1;
        private Label label2;
        private TextBox UserTxt;
        private TextBox PasswordTxt;
    }
}