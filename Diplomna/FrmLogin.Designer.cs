namespace Diplomna
{
    partial class FrmLogin
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
            BtnRegister = new Button();
            BtnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            TbUserName = new TextBox();
            TbPassword = new TextBox();
            SuspendLayout();
            // 
            // BtnRegister
            // 
            BtnRegister.Location = new Point(12, 209);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(112, 41);
            BtnRegister.TabIndex = 0;
            BtnRegister.Text = "Регистрация";
            BtnRegister.UseVisualStyleBackColor = true;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(184, 209);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(112, 41);
            BtnLogin.TabIndex = 1;
            BtnLogin.Text = "Вход";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 19);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 2;
            label1.Text = "Потребителско име";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 99);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Парола";
            // 
            // TbUserName
            // 
            TbUserName.Location = new Point(12, 54);
            TbUserName.Name = "TbUserName";
            TbUserName.Size = new Size(284, 27);
            TbUserName.TabIndex = 4;
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(12, 139);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.Size = new Size(284, 27);
            TbPassword.TabIndex = 5;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(308, 269);
            Controls.Add(TbPassword);
            Controls.Add(TbUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnLogin);
            Controls.Add(BtnRegister);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Влизане в системата";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRegister;
        private Button BtnLogin;
        private Label label1;
        private Label label2;
        private TextBox TbUserName;
        private TextBox TbPassword;
    }
}