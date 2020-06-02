namespace Счетчик
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.Value4 = new System.Windows.Forms.TextBox();
            this.Value3 = new System.Windows.Forms.TextBox();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start1 = new System.Windows.Forms.Button();
            this.start2 = new System.Windows.Forms.Button();
            this.start3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.TextBox();
            this.time1 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Постояная";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(17, 37);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 20);
            this.text1.TabIndex = 1;
            this.text1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(204, 37);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(100, 20);
            this.Value.TabIndex = 3;
            this.Value.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Счетчик по часовой";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Руб/час";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(17, 117);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 20);
            this.text2.TabIndex = 6;
            this.text2.Text = "0";
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(17, 143);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(100, 20);
            this.text4.TabIndex = 7;
            this.text4.Text = "0";
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(17, 169);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(100, 20);
            this.text3.TabIndex = 8;
            this.text3.Text = "0";
            // 
            // Value4
            // 
            this.Value4.Location = new System.Drawing.Point(306, 169);
            this.Value4.Name = "Value4";
            this.Value4.Size = new System.Drawing.Size(100, 20);
            this.Value4.TabIndex = 11;
            this.Value4.Text = "0";
            // 
            // Value3
            // 
            this.Value3.Location = new System.Drawing.Point(306, 143);
            this.Value3.Name = "Value3";
            this.Value3.Size = new System.Drawing.Size(100, 20);
            this.Value3.TabIndex = 10;
            this.Value3.Text = "0";
            this.Value3.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Value2
            // 
            this.Value2.Location = new System.Drawing.Point(306, 117);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(100, 20);
            this.Value2.TabIndex = 9;
            this.Value2.Text = "0";
            this.Value2.TextChanged += new System.EventHandler(this.Value2_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start1
            // 
            this.start1.Location = new System.Drawing.Point(123, 116);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(75, 20);
            this.start1.TabIndex = 12;
            this.start1.Text = "Старт/стоп";
            this.start1.UseVisualStyleBackColor = true;
            this.start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // start2
            // 
            this.start2.Location = new System.Drawing.Point(123, 143);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(75, 20);
            this.start2.TabIndex = 13;
            this.start2.Text = "Старт/стоп";
            this.start2.UseVisualStyleBackColor = true;
            this.start2.Click += new System.EventHandler(this.start2_Click);
            // 
            // start3
            // 
            this.start3.Location = new System.Drawing.Point(123, 169);
            this.start3.Name = "start3";
            this.start3.Size = new System.Drawing.Size(75, 20);
            this.start3.TabIndex = 14;
            this.start3.Text = "Старт/стоп";
            this.start3.UseVisualStyleBackColor = true;
            this.start3.Click += new System.EventHandler(this.start3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(412, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 20);
            this.button5.TabIndex = 15;
            this.button5.Text = "Сброс";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(412, 143);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 20);
            this.button6.TabIndex = 16;
            this.button6.Text = "Сброс";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(412, 169);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 20);
            this.button7.TabIndex = 17;
            this.button7.Text = "Сброс";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(84, 210);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 20);
            this.Sum.TabIndex = 19;
            this.Sum.Text = "0";
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(224, 120);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(43, 13);
            this.time1.TabIndex = 20;
            this.time1.Text = "0 : 0 : 0";
            this.time1.Click += new System.EventHandler(this.label5_Click);
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Location = new System.Drawing.Point(224, 147);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(43, 13);
            this.time2.TabIndex = 21;
            this.time2.Text = "0 : 0 : 0";
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.Location = new System.Drawing.Point(224, 173);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(43, 13);
            this.time3.TabIndex = 22;
            this.time3.Text = "0 : 0 : 0";
            this.time3.Click += new System.EventHandler(this.time3_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Итог:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Экспорт в EXEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(329, 37);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(137, 20);
            this.date.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 238);
            this.Controls.Add(this.date);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.start3);
            this.Controls.Add(this.start2);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.Value4);
            this.Controls.Add(this.Value3);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Счетчик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.TextBox Value4;
        private System.Windows.Forms.TextBox Value3;
        private System.Windows.Forms.TextBox Value2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start1;
        private System.Windows.Forms.Button start2;
        private System.Windows.Forms.Button start3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker date;
    }
}

