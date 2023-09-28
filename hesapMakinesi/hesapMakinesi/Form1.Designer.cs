namespace hesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sonuç:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.rakamOlay);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.rakamOlay);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.rakamOlay);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(254, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 46);
            this.button4.TabIndex = 2;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.islemOlay);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(339, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 46);
            this.button5.TabIndex = 2;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CE);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 171);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 46);
            this.button6.TabIndex = 2;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.rakamOlay);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(93, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 46);
            this.button7.TabIndex = 2;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.rakamOlay);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(172, 171);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 46);
            this.button8.TabIndex = 2;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.rakamOlay);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(254, 171);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 46);
            this.button9.TabIndex = 2;
            this.button9.Text = "*";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.islemOlay);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(339, 171);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(58, 46);
            this.button10.TabIndex = 2;
            this.button10.Text = "C";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.C);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(15, 233);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(58, 46);
            this.button11.TabIndex = 2;
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.rakamOlay);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(93, 233);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(58, 46);
            this.button12.TabIndex = 2;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.rakamOlay);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(172, 233);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(58, 46);
            this.button13.TabIndex = 2;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.rakamOlay);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(254, 233);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(58, 46);
            this.button14.TabIndex = 2;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.islemOlay);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(339, 233);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(58, 107);
            this.button15.TabIndex = 2;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.esit);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(15, 294);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(136, 46);
            this.button16.TabIndex = 2;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.rakamOlay);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(172, 294);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(58, 46);
            this.button18.TabIndex = 2;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.nokta);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(254, 294);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(58, 46);
            this.button19.TabIndex = 2;
            this.button19.Text = "-";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.islemOlay);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
    }
}

