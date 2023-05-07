namespace LoginAcc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordU = new System.Windows.Forms.TextBox();
            this.LoginU = new System.Windows.Forms.TextBox();
            this.LastNameU = new System.Windows.Forms.TextBox();
            this.NameU = new System.Windows.Forms.TextBox();
            this.saveIn = new System.Windows.Forms.Button();
            this.ParametrsPass = new System.Windows.Forms.GroupBox();
            this.GenPass = new System.Windows.Forms.Button();
            this.CheckSpecialP = new System.Windows.Forms.CheckBox();
            this.lbSpecialP = new System.Windows.Forms.Label();
            this.CheckUpperCaseP = new System.Windows.Forms.CheckBox();
            this.lbUppercP = new System.Windows.Forms.Label();
            this.CountLettersP = new System.Windows.Forms.TextBox();
            this.lbLettersP = new System.Windows.Forms.Label();
            this.CountNumberP = new System.Windows.Forms.TextBox();
            this.LenPasP = new System.Windows.Forms.TextBox();
            this.lbDigitsP = new System.Windows.Forms.Label();
            this.lbLenghtP = new System.Windows.Forms.Label();
            this.AllUSers = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.rbntypeUser = new System.Windows.Forms.RadioButton();
            this.rbntypeAdmin = new System.Windows.Forms.RadioButton();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.firstGroup.SuspendLayout();
            this.ParametrsPass.SuspendLayout();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstGroup
            // 
            this.firstGroup.BackColor = System.Drawing.SystemColors.ControlDark;
            this.firstGroup.Controls.Add(this.label4);
            this.firstGroup.Controls.Add(this.label3);
            this.firstGroup.Controls.Add(this.label2);
            this.firstGroup.Controls.Add(this.label1);
            this.firstGroup.Controls.Add(this.PasswordU);
            this.firstGroup.Controls.Add(this.LoginU);
            this.firstGroup.Controls.Add(this.LastNameU);
            this.firstGroup.Controls.Add(this.NameU);
            this.firstGroup.Location = new System.Drawing.Point(12, 12);
            this.firstGroup.Name = "firstGroup";
            this.firstGroup.Size = new System.Drawing.Size(474, 175);
            this.firstGroup.TabIndex = 0;
            this.firstGroup.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(281, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(73, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(279, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "LastName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(68, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // PasswordU
            // 
            this.PasswordU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordU.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PasswordU.Location = new System.Drawing.Point(213, 125);
            this.PasswordU.Multiline = true;
            this.PasswordU.Name = "PasswordU";
            this.PasswordU.Size = new System.Drawing.Size(255, 36);
            this.PasswordU.TabIndex = 3;
            this.PasswordU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginU
            // 
            this.LoginU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginU.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LoginU.Location = new System.Drawing.Point(19, 125);
            this.LoginU.Multiline = true;
            this.LoginU.Name = "LoginU";
            this.LoginU.Size = new System.Drawing.Size(177, 36);
            this.LoginU.TabIndex = 2;
            // 
            // LastNameU
            // 
            this.LastNameU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameU.Location = new System.Drawing.Point(251, 42);
            this.LastNameU.Multiline = true;
            this.LastNameU.Name = "LastNameU";
            this.LastNameU.Size = new System.Drawing.Size(177, 36);
            this.LastNameU.TabIndex = 1;
            // 
            // NameU
            // 
            this.NameU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameU.Location = new System.Drawing.Point(19, 42);
            this.NameU.Multiline = true;
            this.NameU.Name = "NameU";
            this.NameU.Size = new System.Drawing.Size(177, 36);
            this.NameU.TabIndex = 0;
            this.NameU.TextChanged += new System.EventHandler(this.NameU_TextChanged);
            // 
            // saveIn
            // 
            this.saveIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveIn.Location = new System.Drawing.Point(12, 390);
            this.saveIn.Name = "saveIn";
            this.saveIn.Size = new System.Drawing.Size(125, 48);
            this.saveIn.TabIndex = 1;
            this.saveIn.Text = "Save";
            this.saveIn.UseVisualStyleBackColor = true;
            this.saveIn.Click += new System.EventHandler(this.saveIn_Click);
            // 
            // ParametrsPass
            // 
            this.ParametrsPass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ParametrsPass.Controls.Add(this.GenPass);
            this.ParametrsPass.Controls.Add(this.CheckSpecialP);
            this.ParametrsPass.Controls.Add(this.lbSpecialP);
            this.ParametrsPass.Controls.Add(this.CheckUpperCaseP);
            this.ParametrsPass.Controls.Add(this.lbUppercP);
            this.ParametrsPass.Controls.Add(this.CountLettersP);
            this.ParametrsPass.Controls.Add(this.lbLettersP);
            this.ParametrsPass.Controls.Add(this.CountNumberP);
            this.ParametrsPass.Controls.Add(this.LenPasP);
            this.ParametrsPass.Controls.Add(this.lbDigitsP);
            this.ParametrsPass.Controls.Add(this.lbLenghtP);
            this.ParametrsPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametrsPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ParametrsPass.Location = new System.Drawing.Point(263, 193);
            this.ParametrsPass.Name = "ParametrsPass";
            this.ParametrsPass.Size = new System.Drawing.Size(223, 255);
            this.ParametrsPass.TabIndex = 2;
            this.ParametrsPass.TabStop = false;
            this.ParametrsPass.Text = "ParametrsPassword";
            // 
            // GenPass
            // 
            this.GenPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenPass.Location = new System.Drawing.Point(28, 213);
            this.GenPass.Name = "GenPass";
            this.GenPass.Size = new System.Drawing.Size(166, 39);
            this.GenPass.TabIndex = 11;
            this.GenPass.Text = "generate";
            this.GenPass.UseVisualStyleBackColor = true;
            this.GenPass.Click += new System.EventHandler(this.GenPass_Click);
            // 
            // CheckSpecialP
            // 
            this.CheckSpecialP.AutoSize = true;
            this.CheckSpecialP.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckSpecialP.Location = new System.Drawing.Point(131, 186);
            this.CheckSpecialP.Name = "CheckSpecialP";
            this.CheckSpecialP.Size = new System.Drawing.Size(18, 17);
            this.CheckSpecialP.TabIndex = 10;
            this.CheckSpecialP.UseVisualStyleBackColor = true;
            // 
            // lbSpecialP
            // 
            this.lbSpecialP.AutoSize = true;
            this.lbSpecialP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSpecialP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSpecialP.Location = new System.Drawing.Point(10, 185);
            this.lbSpecialP.Name = "lbSpecialP";
            this.lbSpecialP.Size = new System.Drawing.Size(87, 25);
            this.lbSpecialP.TabIndex = 9;
            this.lbSpecialP.Text = "--special";
            // 
            // CheckUpperCaseP
            // 
            this.CheckUpperCaseP.AutoSize = true;
            this.CheckUpperCaseP.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckUpperCaseP.Location = new System.Drawing.Point(131, 152);
            this.CheckUpperCaseP.Name = "CheckUpperCaseP";
            this.CheckUpperCaseP.Size = new System.Drawing.Size(18, 17);
            this.CheckUpperCaseP.TabIndex = 8;
            this.CheckUpperCaseP.UseVisualStyleBackColor = true;
            // 
            // lbUppercP
            // 
            this.lbUppercP.AutoSize = true;
            this.lbUppercP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUppercP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbUppercP.Location = new System.Drawing.Point(7, 144);
            this.lbUppercP.Name = "lbUppercP";
            this.lbUppercP.Size = new System.Drawing.Size(118, 25);
            this.lbUppercP.TabIndex = 7;
            this.lbUppercP.Text = "--uppercase";
            // 
            // CountLettersP
            // 
            this.CountLettersP.Location = new System.Drawing.Point(94, 106);
            this.CountLettersP.Multiline = true;
            this.CountLettersP.Name = "CountLettersP";
            this.CountLettersP.Size = new System.Drawing.Size(100, 29);
            this.CountLettersP.TabIndex = 6;
            // 
            // lbLettersP
            // 
            this.lbLettersP.AutoSize = true;
            this.lbLettersP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLettersP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLettersP.Location = new System.Drawing.Point(6, 106);
            this.lbLettersP.Name = "lbLettersP";
            this.lbLettersP.Size = new System.Drawing.Size(90, 25);
            this.lbLettersP.TabIndex = 5;
            this.lbLettersP.Text = "--letters=";
            // 
            // CountNumberP
            // 
            this.CountNumberP.Location = new System.Drawing.Point(94, 70);
            this.CountNumberP.Multiline = true;
            this.CountNumberP.Name = "CountNumberP";
            this.CountNumberP.Size = new System.Drawing.Size(100, 29);
            this.CountNumberP.TabIndex = 4;
            // 
            // LenPasP
            // 
            this.LenPasP.Location = new System.Drawing.Point(94, 35);
            this.LenPasP.Multiline = true;
            this.LenPasP.Name = "LenPasP";
            this.LenPasP.Size = new System.Drawing.Size(100, 29);
            this.LenPasP.TabIndex = 3;
            // 
            // lbDigitsP
            // 
            this.lbDigitsP.AutoSize = true;
            this.lbDigitsP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDigitsP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDigitsP.Location = new System.Drawing.Point(6, 71);
            this.lbDigitsP.Name = "lbDigitsP";
            this.lbDigitsP.Size = new System.Drawing.Size(83, 25);
            this.lbDigitsP.TabIndex = 2;
            this.lbDigitsP.Text = "--digits=";
            // 
            // lbLenghtP
            // 
            this.lbLenghtP.AutoSize = true;
            this.lbLenghtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLenghtP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLenghtP.Location = new System.Drawing.Point(6, 35);
            this.lbLenghtP.Name = "lbLenghtP";
            this.lbLenghtP.Size = new System.Drawing.Size(91, 25);
            this.lbLenghtP.TabIndex = 0;
            this.lbLenghtP.Text = "--length=";
            // 
            // AllUSers
            // 
            this.AllUSers.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AllUSers.DisplayMember = "vdfd";
            this.AllUSers.FormattingEnabled = true;
            this.AllUSers.ItemHeight = 16;
            this.AllUSers.Location = new System.Drawing.Point(529, 76);
            this.AllUSers.Name = "AllUSers";
            this.AllUSers.Size = new System.Drawing.Size(233, 372);
            this.AllUSers.TabIndex = 3;
            this.AllUSers.SelectedIndexChanged += new System.EventHandler(this.AllUSers_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(524, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "AllUsers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Создать user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupbox1
            // 
            this.groupbox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupbox1.Controls.Add(this.rbntypeUser);
            this.groupbox1.Controls.Add(this.rbntypeAdmin);
            this.groupbox1.Location = new System.Drawing.Point(123, 221);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(134, 71);
            this.groupbox1.TabIndex = 7;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Тип user";
            // 
            // rbntypeUser
            // 
            this.rbntypeUser.AutoSize = true;
            this.rbntypeUser.Location = new System.Drawing.Point(6, 42);
            this.rbntypeUser.Name = "rbntypeUser";
            this.rbntypeUser.Size = new System.Drawing.Size(105, 20);
            this.rbntypeUser.TabIndex = 1;
            this.rbntypeUser.Text = "Regular user";
            this.rbntypeUser.UseVisualStyleBackColor = true;
            this.rbntypeUser.CheckedChanged += new System.EventHandler(this.rbntypeUser_CheckedChanged);
            // 
            // rbntypeAdmin
            // 
            this.rbntypeAdmin.AutoSize = true;
            this.rbntypeAdmin.Location = new System.Drawing.Point(6, 17);
            this.rbntypeAdmin.Name = "rbntypeAdmin";
            this.rbntypeAdmin.Size = new System.Drawing.Size(66, 20);
            this.rbntypeAdmin.TabIndex = 0;
            this.rbntypeAdmin.Text = "Admin";
            this.rbntypeAdmin.UseVisualStyleBackColor = true;
            this.rbntypeAdmin.CheckedChanged += new System.EventHandler(this.rbntypeAdmin_CheckedChanged);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(12, 287);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(105, 75);
            this.btnRemoveUser.TabIndex = 8;
            this.btnRemoveUser.Text = "Удалить выбранного user";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AllUSers);
            this.Controls.Add(this.ParametrsPass);
            this.Controls.Add(this.saveIn);
            this.Controls.Add(this.firstGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.firstGroup.ResumeLayout(false);
            this.firstGroup.PerformLayout();
            this.ParametrsPass.ResumeLayout(false);
            this.ParametrsPass.PerformLayout();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox firstGroup;
        private System.Windows.Forms.TextBox NameU;
        private System.Windows.Forms.TextBox PasswordU;
        private System.Windows.Forms.TextBox LoginU;
        private System.Windows.Forms.TextBox LastNameU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveIn;
        private System.Windows.Forms.GroupBox ParametrsPass;
        private System.Windows.Forms.TextBox LenPasP;
        private System.Windows.Forms.Label lbDigitsP;
        private System.Windows.Forms.Label lbLenghtP;
        private System.Windows.Forms.TextBox CountNumberP;
        private System.Windows.Forms.TextBox CountLettersP;
        private System.Windows.Forms.Label lbLettersP;
        private System.Windows.Forms.Label lbSpecialP;
        private System.Windows.Forms.CheckBox CheckUpperCaseP;
        private System.Windows.Forms.Label lbUppercP;
        private System.Windows.Forms.CheckBox CheckSpecialP;
        private System.Windows.Forms.ListBox AllUSers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button GenPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.RadioButton rbntypeUser;
        private System.Windows.Forms.RadioButton rbntypeAdmin;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Label label5;
    }
}

