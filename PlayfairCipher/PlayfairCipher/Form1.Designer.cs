namespace PlayfairCipher
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
            this.StartCode = new System.Windows.Forms.Button();
            this.StartDecode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyWord = new System.Windows.Forms.TextBox();
            this.matrix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartCode
            // 
            this.StartCode.Location = new System.Drawing.Point(313, 53);
            this.StartCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartCode.Name = "StartCode";
            this.StartCode.Size = new System.Drawing.Size(171, 38);
            this.StartCode.TabIndex = 0;
            this.StartCode.Text = "Code";
            this.StartCode.UseVisualStyleBackColor = true;
            this.StartCode.Click += new System.EventHandler(this.StartCode_Click);
            // 
            // StartDecode
            // 
            this.StartDecode.Location = new System.Drawing.Point(313, 127);
            this.StartDecode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartDecode.Name = "StartDecode";
            this.StartDecode.Size = new System.Drawing.Size(171, 38);
            this.StartDecode.TabIndex = 1;
            this.StartDecode.Text = "Decode";
            this.StartDecode.UseVisualStyleBackColor = true;
            this.StartDecode.Click += new System.EventHandler(this.StartDecode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key word:";
            // 
            // keyWord
            // 
            this.keyWord.Location = new System.Drawing.Point(36, 96);
            this.keyWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keyWord.Name = "keyWord";
            this.keyWord.Size = new System.Drawing.Size(229, 22);
            this.keyWord.TabIndex = 3;
            this.keyWord.Text = "QWERTY";
            // 
            // matrix
            // 
            this.matrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrix.Location = new System.Drawing.Point(568, 15);
            this.matrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrix.Multiline = true;
            this.matrix.Name = "matrix";
            this.matrix.ReadOnly = true;
            this.matrix.Size = new System.Drawing.Size(245, 190);
            this.matrix.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 220);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.keyWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartDecode);
            this.Controls.Add(this.StartCode);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Playfair cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartCode;
        private System.Windows.Forms.Button StartDecode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyWord;
        private System.Windows.Forms.TextBox matrix;
    }
}

