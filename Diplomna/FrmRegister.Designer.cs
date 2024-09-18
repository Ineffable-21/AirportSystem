namespace Diplomna
{
    partial class FrmRegister
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
            CbUsersType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            DtpBirthday = new DateTimePicker();
            TbPhoneNumber = new TextBox();
            TbName = new TextBox();
            TbEmailAddress = new TextBox();
            TbUserName = new TextBox();
            TbPassword = new TextBox();
            CbGenders = new ComboBox();
            BtnRegister = new Button();
            SuspendLayout();
            // 
            // CbUsersType
            // 
            CbUsersType.FormattingEnabled = true;
            CbUsersType.Location = new Point(47, 49);
            CbUsersType.Name = "CbUsersType";
            CbUsersType.Size = new Size(177, 28);
            CbUsersType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Тип потребител";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 9);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Име";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 97);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 3;
            label3.Text = "Дата на раждане";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 96);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 4;
            label4.Text = "Пол";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 184);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 5;
            label5.Text = "Телефонен номер";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 184);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 6;
            label6.Text = "Имейл адрес";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 271);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 7;
            label7.Text = "Потребителско име";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(298, 271);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 8;
            label8.Text = "Парола";
            // 
            // DtpBirthday
            // 
            DtpBirthday.CustomFormat = "yyyy-MM-dd";
            DtpBirthday.Format = DateTimePickerFormat.Custom;
            DtpBirthday.Location = new Point(47, 137);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(177, 27);
            DtpBirthday.TabIndex = 9;
            // 
            // TbPhoneNumber
            // 
            TbPhoneNumber.Location = new Point(47, 224);
            TbPhoneNumber.Name = "TbPhoneNumber";
            TbPhoneNumber.Size = new Size(177, 27);
            TbPhoneNumber.TabIndex = 10;
            // 
            // TbName
            // 
            TbName.Location = new Point(241, 49);
            TbName.Name = "TbName";
            TbName.Size = new Size(177, 27);
            TbName.TabIndex = 11;
            // 
            // TbEmailAddress
            // 
            TbEmailAddress.Location = new Point(241, 224);
            TbEmailAddress.Name = "TbEmailAddress";
            TbEmailAddress.Size = new Size(177, 27);
            TbEmailAddress.TabIndex = 12;
            // 
            // TbUserName
            // 
            TbUserName.Location = new Point(47, 311);
            TbUserName.Name = "TbUserName";
            TbUserName.Size = new Size(177, 27);
            TbUserName.TabIndex = 13;
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(241, 311);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.Size = new Size(177, 27);
            TbPassword.TabIndex = 14;
            // 
            // CbGenders
            // 
            CbGenders.FormattingEnabled = true;
            CbGenders.Location = new Point(241, 136);
            CbGenders.Name = "CbGenders";
            CbGenders.Size = new Size(177, 28);
            CbGenders.TabIndex = 15;
            // 
            // BtnRegister
            // 
            BtnRegister.Location = new Point(179, 364);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(112, 41);
            BtnRegister.TabIndex = 16;
            BtnRegister.Text = "Регистрирай";
            BtnRegister.UseVisualStyleBackColor = true;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(473, 417);
            Controls.Add(BtnRegister);
            Controls.Add(CbGenders);
            Controls.Add(TbPassword);
            Controls.Add(TbUserName);
            Controls.Add(TbEmailAddress);
            Controls.Add(TbName);
            Controls.Add(TbPhoneNumber);
            Controls.Add(DtpBirthday);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CbUsersType);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистриране в системата";
            Load += FrmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CbUsersType;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker DtpBirthday;
        private TextBox TbPhoneNumber;
        private TextBox TbName;
        private TextBox TbEmailAddress;
        private TextBox TbUserName;
        private TextBox TbPassword;
        private ComboBox CbGenders;
        private Button BtnRegister;
    }
}