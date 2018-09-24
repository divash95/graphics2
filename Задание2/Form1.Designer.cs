namespace Задание2
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
            this.openBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eqGreyBtn = new System.Windows.Forms.Button();
            this.difGreyBtn = new System.Windows.Forms.Button();
            this.eqDifGreyBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.redBtn = new System.Windows.Forms.Button();
            this.greenBtn = new System.Windows.Forms.Button();
            this.blueBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.hsvBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(13, 4);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Открыть";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(94, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(13, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 520);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оттенки серого";
            // 
            // eqGreyBtn
            // 
            this.eqGreyBtn.Location = new System.Drawing.Point(850, 42);
            this.eqGreyBtn.Name = "eqGreyBtn";
            this.eqGreyBtn.Size = new System.Drawing.Size(140, 23);
            this.eqGreyBtn.TabIndex = 4;
            this.eqGreyBtn.Text = "С равными весами";
            this.eqGreyBtn.UseVisualStyleBackColor = true;
            this.eqGreyBtn.Click += new System.EventHandler(this.eqGreyBtn_Click);
            // 
            // difGreyBtn
            // 
            this.difGreyBtn.Location = new System.Drawing.Point(850, 71);
            this.difGreyBtn.Name = "difGreyBtn";
            this.difGreyBtn.Size = new System.Drawing.Size(140, 23);
            this.difGreyBtn.TabIndex = 5;
            this.difGreyBtn.Text = "С разными весами";
            this.difGreyBtn.UseVisualStyleBackColor = true;
            this.difGreyBtn.Click += new System.EventHandler(this.difGreyBtn_Click);
            // 
            // eqDifGreyBtn
            // 
            this.eqDifGreyBtn.Location = new System.Drawing.Point(850, 100);
            this.eqDifGreyBtn.Name = "eqDifGreyBtn";
            this.eqDifGreyBtn.Size = new System.Drawing.Size(140, 23);
            this.eqDifGreyBtn.TabIndex = 6;
            this.eqDifGreyBtn.Text = "Разность";
            this.eqDifGreyBtn.UseVisualStyleBackColor = true;
            this.eqDifGreyBtn.Click += new System.EventHandler(this.eqDifGreyBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(879, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Каналы RGB";
            // 
            // redBtn
            // 
            this.redBtn.Location = new System.Drawing.Point(850, 142);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(43, 23);
            this.redBtn.TabIndex = 8;
            this.redBtn.Text = "R";
            this.redBtn.UseVisualStyleBackColor = true;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // greenBtn
            // 
            this.greenBtn.Location = new System.Drawing.Point(899, 142);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(43, 23);
            this.greenBtn.TabIndex = 9;
            this.greenBtn.Text = "G";
            this.greenBtn.UseVisualStyleBackColor = true;
            this.greenBtn.Click += new System.EventHandler(this.greenBtn_Click);
            // 
            // blueBtn
            // 
            this.blueBtn.Location = new System.Drawing.Point(948, 142);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(43, 23);
            this.blueBtn.TabIndex = 10;
            this.blueBtn.Text = "B";
            this.blueBtn.UseVisualStyleBackColor = true;
            this.blueBtn.Click += new System.EventHandler(this.blueBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(831, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "dH(0,360)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(831, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "dS(0,100)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(831, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "dV(0,100)";
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(850, 320);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(140, 23);
            this.restoreBtn.TabIndex = 17;
            this.restoreBtn.Text = "Отменить изменения";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(917, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(917, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(917, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 20);
            this.textBox3.TabIndex = 20;
            // 
            // hsvBtn
            // 
            this.hsvBtn.Location = new System.Drawing.Point(850, 267);
            this.hsvBtn.Name = "hsvBtn";
            this.hsvBtn.Size = new System.Drawing.Size(140, 23);
            this.hsvBtn.TabIndex = 21;
            this.hsvBtn.Text = "HSV";
            this.hsvBtn.UseVisualStyleBackColor = true;
            this.hsvBtn.Click += new System.EventHandler(this.hsvBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 575);
            this.Controls.Add(this.hsvBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blueBtn);
            this.Controls.Add(this.greenBtn);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eqDifGreyBtn);
            this.Controls.Add(this.difGreyBtn);
            this.Controls.Add(this.eqGreyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eqGreyBtn;
        private System.Windows.Forms.Button difGreyBtn;
        private System.Windows.Forms.Button eqDifGreyBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button greenBtn;
        private System.Windows.Forms.Button blueBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button hsvBtn;
    }
}

