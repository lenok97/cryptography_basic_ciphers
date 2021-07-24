namespace CaesarCipher
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
            this.CodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shiftValue = new System.Windows.Forms.TextBox();
            this.openCodedFile = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CodeButton
            // 
            this.CodeButton.Location = new System.Drawing.Point(74, 80);
            this.CodeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodeButton.Name = "CodeButton";
            this.CodeButton.Size = new System.Drawing.Size(104, 29);
            this.CodeButton.TabIndex = 0;
            this.CodeButton.Text = "Шифровать";
            this.CodeButton.UseVisualStyleBackColor = true;
            this.CodeButton.Click += new System.EventHandler(this.CodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(74, 130);
            this.DecodeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(104, 29);
            this.DecodeButton.TabIndex = 2;
            this.DecodeButton.Text = "Расшифровать";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сдвиг:";
            // 
            // shiftValue
            // 
            this.shiftValue.Location = new System.Drawing.Point(116, 51);
            this.shiftValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shiftValue.MaxLength = 3;
            this.shiftValue.Name = "shiftValue";
            this.shiftValue.Size = new System.Drawing.Size(63, 20);
            this.shiftValue.TabIndex = 4;
            this.shiftValue.Text = "3";
            this.shiftValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // openCodedFile
            // 
            this.openCodedFile.AutoSize = true;
            this.openCodedFile.Location = new System.Drawing.Point(163, 88);
            this.openCodedFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.openCodedFile.Name = "openCodedFile";
            this.openCodedFile.Size = new System.Drawing.Size(0, 13);
            this.openCodedFile.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 207);
            this.Controls.Add(this.openCodedFile);
            this.Controls.Add(this.shiftValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.CodeButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Auto Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shiftValue;
        private System.Windows.Forms.LinkLabel openCodedFile;
    }
}

