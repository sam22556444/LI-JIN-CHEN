namespace hw7
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.btn_twi = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_tri2 = new System.Windows.Forms.Button();
            this.btn_Cc = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "number:";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_result.Location = new System.Drawing.Point(33, 374);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(85, 31);
            this.lb_result.TabIndex = 1;
            this.lb_result.Text = "result:";
            // 
            // tb_num
            // 
            this.tb_num.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_num.Location = new System.Drawing.Point(141, 44);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(154, 45);
            this.tb_num.TabIndex = 2;
            // 
            // btn_twi
            // 
            this.btn_twi.Location = new System.Drawing.Point(29, 114);
            this.btn_twi.Name = "btn_twi";
            this.btn_twi.Size = new System.Drawing.Size(128, 64);
            this.btn_twi.TabIndex = 3;
            this.btn_twi.Text = "奇數,偶數";
            this.btn_twi.UseVisualStyleBackColor = true;
            this.btn_twi.Click += new System.EventHandler(this.btn_twi_Click);
            // 
            // btn_max
            // 
            this.btn_max.Location = new System.Drawing.Point(29, 184);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(128, 64);
            this.btn_max.TabIndex = 4;
            this.btn_max.Text = "最大，最小";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_tri2
            // 
            this.btn_tri2.Location = new System.Drawing.Point(29, 254);
            this.btn_tri2.Name = "btn_tri2";
            this.btn_tri2.Size = new System.Drawing.Size(128, 64);
            this.btn_tri2.TabIndex = 5;
            this.btn_tri2.Text = "陣列奇數偶數";
            this.btn_tri2.UseVisualStyleBackColor = true;
            this.btn_tri2.Click += new System.EventHandler(this.btn_tri2_Click);
            // 
            // btn_Cc
            // 
            this.btn_Cc.Location = new System.Drawing.Point(204, 114);
            this.btn_Cc.Name = "btn_Cc";
            this.btn_Cc.Size = new System.Drawing.Size(128, 64);
            this.btn_Cc.TabIndex = 6;
            this.btn_Cc.Text = "陣列C,c個數";
            this.btn_Cc.UseVisualStyleBackColor = true;
            this.btn_Cc.Click += new System.EventHandler(this.btn_Cc_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(204, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 64);
            this.button5.TabIndex = 7;
            this.button5.Text = "陣列最長名子";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(435, 114);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 64);
            this.button6.TabIndex = 8;
            this.button6.Text = "[10,10]二維陣列-邊1,內0";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "[10,10]二維陣列-邊0,內1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 86);
            this.button2.TabIndex = 10;
            this.button2.Text = "[10,10]二維陣列\r\n101010\r\n010101\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 64);
            this.button3.TabIndex = 11;
            this.button3.Text = "swap[int int]\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(620, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 64);
            this.button4.TabIndex = 12;
            this.button4.Text = "Sum(陣列)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(794, 198);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 64);
            this.button7.TabIndex = 13;
            this.button7.Text = "Max(陣列)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(794, 114);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 64);
            this.button8.TabIndex = 14;
            this.button8.Text = "min(陣列)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(316, 44);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 51);
            this.button9.TabIndex = 15;
            this.button9.Text = "clear\r\n";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 701);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_Cc);
            this.Controls.Add(this.btn_tri2);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_twi);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Button btn_twi;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_tri2;
        private System.Windows.Forms.Button btn_Cc;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

