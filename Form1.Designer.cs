namespace Цезарь____
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encryption = new System.Windows.Forms.Button();
            this.decryption = new System.Windows.Forms.Button();
            this.checkBox_ru = new System.Windows.Forms.CheckBox();
            this.checkBox_en = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(52, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(508, 53);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(52, 144);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(508, 53);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox3.Location = new System.Drawing.Point(52, 245);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(508, 53);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox4.Location = new System.Drawing.Point(52, 344);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(508, 53);
            this.richTextBox4.TabIndex = 0;
            this.richTextBox4.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ключ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Криптограмма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Расшифрованный текст";
            // 
            // encryption
            // 
            this.encryption.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.encryption.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.encryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryption.Location = new System.Drawing.Point(634, 169);
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(128, 28);
            this.encryption.TabIndex = 2;
            this.encryption.Text = "Зашифровать";
            this.encryption.UseVisualStyleBackColor = false;
            this.encryption.Click += new System.EventHandler(this.encryption_Click);
            // 
            // decryption
            // 
            this.decryption.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.decryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryption.Location = new System.Drawing.Point(634, 270);
            this.decryption.Name = "decryption";
            this.decryption.Size = new System.Drawing.Size(128, 28);
            this.decryption.TabIndex = 2;
            this.decryption.Text = "Расшифровать";
            this.decryption.UseVisualStyleBackColor = false;
            this.decryption.Click += new System.EventHandler(this.decryption_Click);
            // 
            // checkBox_ru
            // 
            this.checkBox_ru.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_ru.AutoSize = true;
            this.checkBox_ru.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox_ru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ru.Location = new System.Drawing.Point(559, 3);
            this.checkBox_ru.Name = "checkBox_ru";
            this.checkBox_ru.Size = new System.Drawing.Size(34, 26);
            this.checkBox_ru.TabIndex = 4;
            this.checkBox_ru.Text = "Ru";
            this.checkBox_ru.UseVisualStyleBackColor = false;
            this.checkBox_ru.CheckedChanged += new System.EventHandler(this.checkBox_ru_CheckedChanged);
            // 
            // checkBox_en
            // 
            this.checkBox_en.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_en.AutoSize = true;
            this.checkBox_en.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox_en.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_en.Location = new System.Drawing.Point(610, 3);
            this.checkBox_en.Name = "checkBox_en";
            this.checkBox_en.Size = new System.Drawing.Size(33, 26);
            this.checkBox_en.TabIndex = 4;
            this.checkBox_en.Text = "En";
            this.checkBox_en.UseVisualStyleBackColor = false;
            this.checkBox_en.CheckedChanged += new System.EventHandler(this.checkBox_en_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 448);
            this.Controls.Add(this.checkBox_en);
            this.Controls.Add(this.checkBox_ru);
            this.Controls.Add(this.decryption);
            this.Controls.Add(this.encryption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Шифр Цезаря";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button encryption;
        private System.Windows.Forms.Button decryption;
        private System.Windows.Forms.CheckBox checkBox_ru;
        private System.Windows.Forms.CheckBox checkBox_en;
    }
}

