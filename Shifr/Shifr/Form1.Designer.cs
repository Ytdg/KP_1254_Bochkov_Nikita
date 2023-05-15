namespace Shifr
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
            this.tbxwrite = new System.Windows.Forms.TextBox();
            this.lbxtype_shifr = new System.Windows.Forms.ListBox();
            this.lbxselect_type = new System.Windows.Forms.ListBox();
            this.btnclear_select = new System.Windows.Forms.Button();
            this.btngoEncrypt = new System.Windows.Forms.Button();
            this.tbxresult = new System.Windows.Forms.TextBox();
            this.bntUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.tbxKeyShifr = new System.Windows.Forms.TextBox();
            this.btngoDecrypt = new System.Windows.Forms.Button();
            this.tbxDecryptedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxwrite
            // 
            this.tbxwrite.Location = new System.Drawing.Point(112, 12);
            this.tbxwrite.Multiline = true;
            this.tbxwrite.Name = "tbxwrite";
            this.tbxwrite.Size = new System.Drawing.Size(389, 83);
            this.tbxwrite.TabIndex = 0;
            this.tbxwrite.TextChanged += new System.EventHandler(this.tbxwrite_TextChanged);
            // 
            // lbxtype_shifr
            // 
            this.lbxtype_shifr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxtype_shifr.FormattingEnabled = true;
            this.lbxtype_shifr.ItemHeight = 29;
            this.lbxtype_shifr.Location = new System.Drawing.Point(112, 101);
            this.lbxtype_shifr.Name = "lbxtype_shifr";
            this.lbxtype_shifr.Size = new System.Drawing.Size(143, 120);
            this.lbxtype_shifr.TabIndex = 1;
            this.lbxtype_shifr.SelectedIndexChanged += new System.EventHandler(this.lbxtype_shifr_SelectedIndexChanged);
            // 
            // lbxselect_type
            // 
            this.lbxselect_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxselect_type.FormattingEnabled = true;
            this.lbxselect_type.ItemHeight = 29;
            this.lbxselect_type.Location = new System.Drawing.Point(358, 101);
            this.lbxselect_type.Name = "lbxselect_type";
            this.lbxselect_type.Size = new System.Drawing.Size(143, 120);
            this.lbxselect_type.TabIndex = 2;
            // 
            // btnclear_select
            // 
            this.btnclear_select.Location = new System.Drawing.Point(261, 172);
            this.btnclear_select.Name = "btnclear_select";
            this.btnclear_select.Size = new System.Drawing.Size(91, 49);
            this.btnclear_select.TabIndex = 3;
            this.btnclear_select.Text = "очистить";
            this.btnclear_select.UseVisualStyleBackColor = true;
            this.btnclear_select.Click += new System.EventHandler(this.btnclear_select_Click);
            // 
            // btngoEncrypt
            // 
            this.btngoEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btngoEncrypt.Location = new System.Drawing.Point(222, 227);
            this.btngoEncrypt.Name = "btngoEncrypt";
            this.btngoEncrypt.Size = new System.Drawing.Size(162, 43);
            this.btngoEncrypt.TabIndex = 4;
            this.btngoEncrypt.Text = "шифровать";
            this.btngoEncrypt.UseVisualStyleBackColor = true;
            this.btngoEncrypt.Click += new System.EventHandler(this.btngo_shifr_Click);
            // 
            // tbxresult
            // 
            this.tbxresult.Location = new System.Drawing.Point(112, 276);
            this.tbxresult.Multiline = true;
            this.tbxresult.Name = "tbxresult";
            this.tbxresult.Size = new System.Drawing.Size(389, 83);
            this.tbxresult.TabIndex = 5;
            this.tbxresult.TextChanged += new System.EventHandler(this.tbxwrite_TextChanged);
            // 
            // bntUp
            // 
            this.bntUp.Location = new System.Drawing.Point(507, 101);
            this.bntUp.Name = "bntUp";
            this.bntUp.Size = new System.Drawing.Size(75, 57);
            this.bntUp.TabIndex = 6;
            this.bntUp.Text = "up";
            this.bntUp.UseVisualStyleBackColor = true;
            this.bntUp.Click += new System.EventHandler(this.bntReverse_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(507, 164);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 57);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.bntReverse_Click);
            // 
            // tbxKeyShifr
            // 
            this.tbxKeyShifr.Location = new System.Drawing.Point(112, 365);
            this.tbxKeyShifr.Multiline = true;
            this.tbxKeyShifr.Name = "tbxKeyShifr";
            this.tbxKeyShifr.Size = new System.Drawing.Size(389, 45);
            this.tbxKeyShifr.TabIndex = 8;
            this.tbxKeyShifr.TextChanged += new System.EventHandler(this.tbxKeyShifr_TextChanged);
            // 
            // btngoDecrypt
            // 
            this.btngoDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btngoDecrypt.Location = new System.Drawing.Point(198, 416);
            this.btngoDecrypt.Name = "btngoDecrypt";
            this.btngoDecrypt.Size = new System.Drawing.Size(217, 43);
            this.btngoDecrypt.TabIndex = 9;
            this.btngoDecrypt.Text = "расшифровать";
            this.btngoDecrypt.UseVisualStyleBackColor = true;
            this.btngoDecrypt.Click += new System.EventHandler(this.btngoDecrypt_Click);
            // 
            // tbxDecryptedText
            // 
            this.tbxDecryptedText.Enabled = false;
            this.tbxDecryptedText.Location = new System.Drawing.Point(112, 465);
            this.tbxDecryptedText.Multiline = true;
            this.tbxDecryptedText.Name = "tbxDecryptedText";
            this.tbxDecryptedText.Size = new System.Drawing.Size(389, 115);
            this.tbxDecryptedText.TabIndex = 10;
            this.tbxDecryptedText.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(507, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "шифруемый текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(504, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "зашифрованый текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(507, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "расшифрованный текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(507, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "ключ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(857, 644);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDecryptedText);
            this.Controls.Add(this.btngoDecrypt);
            this.Controls.Add(this.tbxKeyShifr);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.bntUp);
            this.Controls.Add(this.tbxresult);
            this.Controls.Add(this.btngoEncrypt);
            this.Controls.Add(this.btnclear_select);
            this.Controls.Add(this.lbxselect_type);
            this.Controls.Add(this.lbxtype_shifr);
            this.Controls.Add(this.tbxwrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxwrite;
        private System.Windows.Forms.ListBox lbxtype_shifr;
        private System.Windows.Forms.ListBox lbxselect_type;
        private System.Windows.Forms.Button btnclear_select;
        private System.Windows.Forms.Button btngoEncrypt;
        private System.Windows.Forms.TextBox tbxresult;
        private System.Windows.Forms.Button bntUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.TextBox tbxKeyShifr;
        private System.Windows.Forms.Button btngoDecrypt;
        private System.Windows.Forms.TextBox tbxDecryptedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

