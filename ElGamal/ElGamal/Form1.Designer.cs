namespace ElGamal
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
            this.Start = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encrypdetText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.decrypdetText = new System.Windows.Forms.TextBox();
            this.pLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(152, 302);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(293, 34);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(39, 55);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(151, 109);
            this.inputText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted text:";
            // 
            // encrypdetText
            // 
            this.encrypdetText.Location = new System.Drawing.Point(227, 55);
            this.encrypdetText.Multiline = true;
            this.encrypdetText.Name = "encrypdetText";
            this.encrypdetText.Size = new System.Drawing.Size(151, 109);
            this.encrypdetText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Decrypted text:";
            // 
            // decrypdetText
            // 
            this.decrypdetText.Location = new System.Drawing.Point(418, 55);
            this.decrypdetText.Multiline = true;
            this.decrypdetText.Name = "decrypdetText";
            this.decrypdetText.Size = new System.Drawing.Size(151, 109);
            this.decrypdetText.TabIndex = 5;
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(36, 187);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(46, 17);
            this.pLabel.TabIndex = 7;
            this.pLabel.Text = "label4";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(36, 227);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(46, 17);
            this.gLabel.TabIndex = 8;
            this.gLabel.Text = "label5";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(36, 264);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(46, 17);
            this.xLabel.TabIndex = 9;
            this.xLabel.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decrypdetText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encrypdetText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "El Gamal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encrypdetText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decrypdetText;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label xLabel;
    }
}

