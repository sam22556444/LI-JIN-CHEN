namespace hw2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.tb_persent = new System.Windows.Forms.TextBox();
            this.tb_firstmoney = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.btn_mp = new System.Windows.Forms.Button();
            this.btn_allpay = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(55, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "利率(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(55, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "期限(年)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(55, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "頭期款";
            // 
            // tb_money
            // 
            this.tb_money.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_money.Location = new System.Drawing.Point(306, 36);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(174, 41);
            this.tb_money.TabIndex = 4;
            this.tb_money.Text = "100000";
            this.tb_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_persent
            // 
            this.tb_persent.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_persent.Location = new System.Drawing.Point(306, 202);
            this.tb_persent.Name = "tb_persent";
            this.tb_persent.Size = new System.Drawing.Size(174, 41);
            this.tb_persent.TabIndex = 5;
            this.tb_persent.Text = "10";
            this.tb_persent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_firstmoney
            // 
            this.tb_firstmoney.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_firstmoney.Location = new System.Drawing.Point(306, 285);
            this.tb_firstmoney.Name = "tb_firstmoney";
            this.tb_firstmoney.Size = new System.Drawing.Size(174, 41);
            this.tb_firstmoney.TabIndex = 6;
            this.tb_firstmoney.Text = "0";
            this.tb_firstmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_time
            // 
            this.tb_time.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_time.Location = new System.Drawing.Point(306, 119);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(174, 41);
            this.tb_time.TabIndex = 7;
            this.tb_time.Text = "1";
            this.tb_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_mp
            // 
            this.btn_mp.Location = new System.Drawing.Point(86, 364);
            this.btn_mp.Name = "btn_mp";
            this.btn_mp.Size = new System.Drawing.Size(141, 53);
            this.btn_mp.TabIndex = 8;
            this.btn_mp.Text = "月付";
            this.btn_mp.UseVisualStyleBackColor = true;
            this.btn_mp.Click += new System.EventHandler(this.btn_mp_Click);
            // 
            // btn_allpay
            // 
            this.btn_allpay.Location = new System.Drawing.Point(294, 364);
            this.btn_allpay.Name = "btn_allpay";
            this.btn_allpay.Size = new System.Drawing.Size(141, 53);
            this.btn_allpay.TabIndex = 9;
            this.btn_allpay.Text = "總額";
            this.btn_allpay.UseVisualStyleBackColor = true;
            this.btn_allpay.Click += new System.EventHandler(this.btn_allpay_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_allpay);
            this.Controls.Add(this.btn_mp);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.tb_firstmoney);
            this.Controls.Add(this.tb_persent);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.TextBox tb_persent;
        private System.Windows.Forms.TextBox tb_firstmoney;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Button btn_mp;
        private System.Windows.Forms.Button btn_allpay;
        private System.Windows.Forms.Button button3;
    }
}

