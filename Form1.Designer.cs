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
            this.IsEncoding = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // decoded_textBox
            // 
            this.decoded_textBox.Location = new System.Drawing.Point(12, 40);
            this.decoded_textBox.Multiline = true;
            this.decoded_textBox.Name = "decoded_textBox";
            this.decoded_textBox.Size = new System.Drawing.Size(367, 338);
            this.decoded_textBox.TabIndex = 0;
            this.decoded_textBox.TextChanged += new System.EventHandler(this.Decoded_TextChanged);
            // 
            // encoded_textBox
            // 
            this.encoded_textBox.Location = new System.Drawing.Point(385, 40);
            this.encoded_textBox.Multiline = true;
            this.encoded_textBox.Name = "encoded_textBox";
            this.encoded_textBox.ReadOnly = true;
            this.encoded_textBox.Size = new System.Drawing.Size(403, 338);
            this.encoded_textBox.TabIndex = 1;
            // 
            // IsEncoding
            // 
            this.IsEncoding.AutoSize = true;
            this.IsEncoding.Checked = true;
            this.IsEncoding.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsEncoding.Location = new System.Drawing.Point(12, 12);
            this.IsEncoding.Name = "IsEncoding";
            this.IsEncoding.Size = new System.Drawing.Size(71, 17);
            this.IsEncoding.TabIndex = 2;
            this.IsEncoding.Text = "Encoding";
            this.IsEncoding.UseVisualStyleBackColor = true;
            this.IsEncoding.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IsEncoding);
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
        private System.Windows.Forms.CheckBox IsEncoding;
    }
}

