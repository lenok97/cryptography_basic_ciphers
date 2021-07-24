namespace MultiplicativeCiphers
{
    partial class MainForm
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
            this.DecodeButton = new System.Windows.Forms.Button();
            this.CodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(230, 67);
            this.DecodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(139, 36);
            this.DecodeButton.TabIndex = 4;
            this.DecodeButton.Text = "Расшифровать";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // CodeButton
            // 
            this.CodeButton.Location = new System.Drawing.Point(42, 67);
            this.CodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodeButton.Name = "CodeButton";
            this.CodeButton.Size = new System.Drawing.Size(139, 36);
            this.CodeButton.TabIndex = 3;
            this.CodeButton.Text = "Шифровать";
            this.CodeButton.UseVisualStyleBackColor = true;
            this.CodeButton.Click += new System.EventHandler(this.CodeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 148);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.CodeButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Multiplicative Cipher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Button CodeButton;
    }
}

