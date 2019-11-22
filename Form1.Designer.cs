namespace ReplacementCipher
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
            this.decoded_textBox = new System.Windows.Forms.TextBox();
            this.encoded_textBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // decoded_textBox
            // 
            this.decoded_textBox.Location = new System.Drawing.Point(12, 40);
            this.decoded_textBox.Multiline = true;
            this.decoded_textBox.Name = "decoded_textBox";
            this.decoded_textBox.Size = new System.Drawing.Size(367, 398);
            this.decoded_textBox.TabIndex = 0;
            this.decoded_textBox.TextChanged += new System.EventHandler(this.Decoded_TextChanged);
            // 
            // encoded_textBox
            // 
            this.encoded_textBox.Location = new System.Drawing.Point(385, 40);
            this.encoded_textBox.Multiline = true;
            this.encoded_textBox.Name = "encoded_textBox";
            this.encoded_textBox.ReadOnly = true;
            this.encoded_textBox.Size = new System.Drawing.Size(403, 398);
            this.encoded_textBox.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Encoding";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.encoded_textBox);
            this.Controls.Add(this.decoded_textBox);
            this.Name = "Form1";
            this.Text = "Шифр простой замены";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox decoded_textBox;
        private System.Windows.Forms.TextBox encoded_textBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

