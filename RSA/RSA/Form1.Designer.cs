namespace RSA
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
            this.gLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qValue = new System.Windows.Forms.TextBox();
            this.pValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eValue = new System.Windows.Forms.Label();
            this.nValue = new System.Windows.Forms.Label();
            this.dValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(325, 257);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(28, 17);
            this.gLabel.TabIndex = 8;
            this.gLabel.Text = "n =";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(421, 216);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(28, 17);
            this.xLabel.TabIndex = 9;
            this.xLabel.Text = "d =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "q =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "p =";
            // 
            // qValue
            // 
            this.qValue.Location = new System.Drawing.Point(58, 240);
            this.qValue.Name = "qValue";
            this.qValue.Size = new System.Drawing.Size(113, 22);
            this.qValue.TabIndex = 15;
            this.qValue.Text = "199";
            this.qValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qValue_KeyPress);
            // 
            // pValue
            // 
            this.pValue.Location = new System.Drawing.Point(58, 197);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(113, 22);
            this.pValue.TabIndex = 14;
            this.pValue.Text = "103";
            this.pValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pValue_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "e =";
            // 
            // eValue
            // 
            this.eValue.AutoSize = true;
            this.eValue.Location = new System.Drawing.Point(253, 215);
            this.eValue.Name = "eValue";
            this.eValue.Size = new System.Drawing.Size(16, 17);
            this.eValue.TabIndex = 17;
            this.eValue.Text = "e";
            // 
            // nValue
            // 
            this.nValue.AutoSize = true;
            this.nValue.Location = new System.Drawing.Point(351, 257);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(16, 17);
            this.nValue.TabIndex = 18;
            this.nValue.Text = "n";
            // 
            // dValue
            // 
            this.dValue.AutoSize = true;
            this.dValue.Location = new System.Drawing.Point(448, 217);
            this.dValue.Name = "dValue";
            this.dValue.Size = new System.Drawing.Size(16, 17);
            this.dValue.TabIndex = 19;
            this.dValue.Text = "d";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Открытый ключ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Закрытый ключ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dValue);
            this.Controls.Add(this.nValue);
            this.Controls.Add(this.eValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qValue);
            this.Controls.Add(this.pValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decrypdetText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encrypdetText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "RSA";
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
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qValue;
        private System.Windows.Forms.TextBox pValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label eValue;
        private System.Windows.Forms.Label nValue;
        private System.Windows.Forms.Label dValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

