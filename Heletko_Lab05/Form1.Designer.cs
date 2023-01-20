namespace Heletko_Lab05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iFileTextBox = new System.Windows.Forms.TextBox();
            this.oFileTextBox = new System.Windows.Forms.TextBox();
            this.iFileOpenButton = new System.Windows.Forms.Button();
            this.oFileSaveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sha512RadioButton = new System.Windows.Forms.RadioButton();
            this.sha384RadioButton = new System.Windows.Forms.RadioButton();
            this.sha256RadioButton = new System.Windows.Forms.RadioButton();
            this.sha1RadioButton = new System.Windows.Forms.RadioButton();
            this.md5RadioButton = new System.Windows.Forms.RadioButton();
            this.ripeRadioButton = new System.Windows.Forms.RadioButton();
            this.hashRadioButton = new System.Windows.Forms.RadioButton();
            this.crcRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iFileSizeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.oFileSizeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.execButton = new System.Windows.Forms.Button();
            this.clrButton = new System.Windows.Forms.Button();
            this.aLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.totTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вхідний файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вихідний файл";
            // 
            // iFileTextBox
            // 
            this.iFileTextBox.Location = new System.Drawing.Point(93, 12);
            this.iFileTextBox.Name = "iFileTextBox";
            this.iFileTextBox.Size = new System.Drawing.Size(225, 20);
            this.iFileTextBox.TabIndex = 2;
            // 
            // oFileTextBox
            // 
            this.oFileTextBox.Location = new System.Drawing.Point(93, 40);
            this.oFileTextBox.Name = "oFileTextBox";
            this.oFileTextBox.Size = new System.Drawing.Size(225, 20);
            this.oFileTextBox.TabIndex = 3;
            // 
            // iFileOpenButton
            // 
            this.iFileOpenButton.Location = new System.Drawing.Point(324, 9);
            this.iFileOpenButton.Name = "iFileOpenButton";
            this.iFileOpenButton.Size = new System.Drawing.Size(47, 23);
            this.iFileOpenButton.TabIndex = 4;
            this.iFileOpenButton.Text = "...";
            this.iFileOpenButton.UseVisualStyleBackColor = true;
            this.iFileOpenButton.Click += new System.EventHandler(this.iFileOpenButton_Click);
            // 
            // oFileSaveButton
            // 
            this.oFileSaveButton.Location = new System.Drawing.Point(324, 38);
            this.oFileSaveButton.Name = "oFileSaveButton";
            this.oFileSaveButton.Size = new System.Drawing.Size(47, 23);
            this.oFileSaveButton.TabIndex = 5;
            this.oFileSaveButton.Text = "...";
            this.oFileSaveButton.UseVisualStyleBackColor = true;
            this.oFileSaveButton.Click += new System.EventHandler(this.oFSaveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sha512RadioButton);
            this.groupBox1.Controls.Add(this.sha384RadioButton);
            this.groupBox1.Controls.Add(this.sha256RadioButton);
            this.groupBox1.Controls.Add(this.sha1RadioButton);
            this.groupBox1.Controls.Add(this.md5RadioButton);
            this.groupBox1.Controls.Add(this.ripeRadioButton);
            this.groupBox1.Controls.Add(this.hashRadioButton);
            this.groupBox1.Controls.Add(this.crcRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 116);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим роботи";
            // 
            // sha512RadioButton
            // 
            this.sha512RadioButton.AutoSize = true;
            this.sha512RadioButton.Location = new System.Drawing.Point(98, 88);
            this.sha512RadioButton.Name = "sha512RadioButton";
            this.sha512RadioButton.Size = new System.Drawing.Size(68, 17);
            this.sha512RadioButton.TabIndex = 14;
            this.sha512RadioButton.TabStop = true;
            this.sha512RadioButton.Text = "SHA-512";
            this.sha512RadioButton.UseVisualStyleBackColor = true;
            // 
            // sha384RadioButton
            // 
            this.sha384RadioButton.AutoSize = true;
            this.sha384RadioButton.Location = new System.Drawing.Point(98, 65);
            this.sha384RadioButton.Name = "sha384RadioButton";
            this.sha384RadioButton.Size = new System.Drawing.Size(68, 17);
            this.sha384RadioButton.TabIndex = 13;
            this.sha384RadioButton.TabStop = true;
            this.sha384RadioButton.Text = "SHA-384";
            this.sha384RadioButton.UseVisualStyleBackColor = true;
            // 
            // sha256RadioButton
            // 
            this.sha256RadioButton.AutoSize = true;
            this.sha256RadioButton.Location = new System.Drawing.Point(98, 42);
            this.sha256RadioButton.Name = "sha256RadioButton";
            this.sha256RadioButton.Size = new System.Drawing.Size(68, 17);
            this.sha256RadioButton.TabIndex = 12;
            this.sha256RadioButton.TabStop = true;
            this.sha256RadioButton.Text = "SHA-256";
            this.sha256RadioButton.UseVisualStyleBackColor = true;
            // 
            // sha1RadioButton
            // 
            this.sha1RadioButton.AutoSize = true;
            this.sha1RadioButton.Location = new System.Drawing.Point(98, 19);
            this.sha1RadioButton.Name = "sha1RadioButton";
            this.sha1RadioButton.Size = new System.Drawing.Size(56, 17);
            this.sha1RadioButton.TabIndex = 11;
            this.sha1RadioButton.TabStop = true;
            this.sha1RadioButton.Text = "SHA-1";
            this.sha1RadioButton.UseVisualStyleBackColor = true;
            // 
            // md5RadioButton
            // 
            this.md5RadioButton.AutoSize = true;
            this.md5RadioButton.Location = new System.Drawing.Point(8, 88);
            this.md5RadioButton.Name = "md5RadioButton";
            this.md5RadioButton.Size = new System.Drawing.Size(48, 17);
            this.md5RadioButton.TabIndex = 10;
            this.md5RadioButton.TabStop = true;
            this.md5RadioButton.Text = "MD5";
            this.md5RadioButton.UseVisualStyleBackColor = true;
            // 
            // ripeRadioButton
            // 
            this.ripeRadioButton.AutoSize = true;
            this.ripeRadioButton.Location = new System.Drawing.Point(8, 65);
            this.ripeRadioButton.Name = "ripeRadioButton";
            this.ripeRadioButton.Size = new System.Drawing.Size(85, 17);
            this.ripeRadioButton.TabIndex = 9;
            this.ripeRadioButton.TabStop = true;
            this.ripeRadioButton.Text = "RIPEMD160";
            this.ripeRadioButton.UseVisualStyleBackColor = true;
            // 
            // hashRadioButton
            // 
            this.hashRadioButton.AutoSize = true;
            this.hashRadioButton.Location = new System.Drawing.Point(8, 42);
            this.hashRadioButton.Name = "hashRadioButton";
            this.hashRadioButton.Size = new System.Drawing.Size(93, 17);
            this.hashRadioButton.TabIndex = 8;
            this.hashRadioButton.TabStop = true;
            this.hashRadioButton.Text = "HashAlgorithm";
            this.hashRadioButton.UseVisualStyleBackColor = true;
            // 
            // crcRadioButton
            // 
            this.crcRadioButton.AutoSize = true;
            this.crcRadioButton.Location = new System.Drawing.Point(8, 19);
            this.crcRadioButton.Name = "crcRadioButton";
            this.crcRadioButton.Size = new System.Drawing.Size(59, 17);
            this.crcRadioButton.TabIndex = 7;
            this.crcRadioButton.TabStop = true;
            this.crcRadioButton.Text = "CRC32";
            this.crcRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iFileSizeLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(193, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 57);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Розмір (Мбайт)";
            // 
            // iFileSizeLabel
            // 
            this.iFileSizeLabel.AutoSize = true;
            this.iFileSizeLabel.Location = new System.Drawing.Point(111, 25);
            this.iFileSizeLabel.Name = "iFileSizeLabel";
            this.iFileSizeLabel.Size = new System.Drawing.Size(25, 13);
            this.iFileSizeLabel.TabIndex = 12;
            this.iFileSizeLabel.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вхідного файлу:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.oFileSizeLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(193, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 51);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Розмір (байт)";
            // 
            // oFileSizeLabel
            // 
            this.oFileSizeLabel.AutoSize = true;
            this.oFileSizeLabel.Location = new System.Drawing.Point(111, 25);
            this.oFileSizeLabel.Name = "oFileSizeLabel";
            this.oFileSizeLabel.Size = new System.Drawing.Size(25, 13);
            this.oFileSizeLabel.TabIndex = 11;
            this.oFileSizeLabel.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вихідного файлу:";
            // 
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(85, 188);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(101, 33);
            this.execButton.TabIndex = 9;
            this.execButton.Text = "Виконати";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // clrButton
            // 
            this.clrButton.Location = new System.Drawing.Point(192, 188);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(100, 33);
            this.clrButton.TabIndex = 10;
            this.clrButton.Text = "Очистити";
            this.clrButton.UseVisualStyleBackColor = true;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // aLinkLabel
            // 
            this.aLinkLabel.AutoSize = true;
            this.aLinkLabel.Location = new System.Drawing.Point(281, 232);
            this.aLinkLabel.Name = "aLinkLabel";
            this.aLinkLabel.Size = new System.Drawing.Size(37, 13);
            this.aLinkLabel.TabIndex = 12;
            this.aLinkLabel.TabStop = true;
            this.aLinkLabel.Text = "Автор";
            this.aLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aLinkLabel_LinkClicked);
            // 
            // dLinkLabel
            // 
            this.dLinkLabel.AutoSize = true;
            this.dLinkLabel.Location = new System.Drawing.Point(329, 232);
            this.dLinkLabel.Name = "dLinkLabel";
            this.dLinkLabel.Size = new System.Drawing.Size(33, 13);
            this.dLinkLabel.TabIndex = 13;
            this.dLinkLabel.TabStop = true;
            this.dLinkLabel.Text = "Опис";
            this.dLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dLinkLabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Тривалість";
            // 
            // totTimeLabel
            // 
            this.totTimeLabel.AutoSize = true;
            this.totTimeLabel.Location = new System.Drawing.Point(175, 232);
            this.totTimeLabel.Name = "totTimeLabel";
            this.totTimeLabel.Size = new System.Drawing.Size(79, 13);
            this.totTimeLabel.TabIndex = 15;
            this.totTimeLabel.Text = "0:00:00:00.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 255);
            this.Controls.Add(this.totTimeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dLinkLabel);
            this.Controls.Add(this.aLinkLabel);
            this.Controls.Add(this.clrButton);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.oFileSaveButton);
            this.Controls.Add(this.iFileOpenButton);
            this.Controls.Add(this.oFileTextBox);
            this.Controls.Add(this.iFileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Циклічний надлишковий код (CRC)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iFileTextBox;
        private System.Windows.Forms.TextBox oFileTextBox;
        private System.Windows.Forms.Button iFileOpenButton;
        private System.Windows.Forms.Button oFileSaveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton md5RadioButton;
        private System.Windows.Forms.RadioButton ripeRadioButton;
        private System.Windows.Forms.RadioButton hashRadioButton;
        private System.Windows.Forms.RadioButton crcRadioButton;
        private System.Windows.Forms.RadioButton sha512RadioButton;
        private System.Windows.Forms.RadioButton sha384RadioButton;
        private System.Windows.Forms.RadioButton sha256RadioButton;
        private System.Windows.Forms.RadioButton sha1RadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label iFileSizeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label oFileSizeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button clrButton;
        private System.Windows.Forms.LinkLabel aLinkLabel;
        private System.Windows.Forms.LinkLabel dLinkLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totTimeLabel;
    }
}

