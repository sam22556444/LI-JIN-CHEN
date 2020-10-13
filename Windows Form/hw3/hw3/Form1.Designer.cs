namespace hw3
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
            this.酒 = new System.Windows.Forms.Button();
            this.漢堡 = new System.Windows.Forms.Button();
            this.薯條 = new System.Windows.Forms.Button();
            this.allmoney = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.allclear = new System.Windows.Forms.Button();
            this.paymoney = new System.Windows.Forms.Button();
            this.paycridi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalmoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_red = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 酒
            // 
            this.酒.Location = new System.Drawing.Point(9, 54);
            this.酒.Margin = new System.Windows.Forms.Padding(4);
            this.酒.Name = "酒";
            this.酒.Size = new System.Drawing.Size(129, 93);
            this.酒.TabIndex = 0;
            this.酒.Text = "啤酒\r\nNT100\r\n";
            this.酒.UseVisualStyleBackColor = true;
            this.酒.Click += new System.EventHandler(this.酒_Click);
            // 
            // 漢堡
            // 
            this.漢堡.Location = new System.Drawing.Point(172, 54);
            this.漢堡.Margin = new System.Windows.Forms.Padding(4);
            this.漢堡.Name = "漢堡";
            this.漢堡.Size = new System.Drawing.Size(129, 93);
            this.漢堡.TabIndex = 2;
            this.漢堡.Text = "漢堡\r\nNT200\r\n";
            this.漢堡.UseVisualStyleBackColor = true;
            this.漢堡.Click += new System.EventHandler(this.漢堡_Click);
            // 
            // 薯條
            // 
            this.薯條.Location = new System.Drawing.Point(10, 194);
            this.薯條.Margin = new System.Windows.Forms.Padding(4);
            this.薯條.Name = "薯條";
            this.薯條.Size = new System.Drawing.Size(129, 93);
            this.薯條.TabIndex = 3;
            this.薯條.Text = "薯條\r\nNT150\r\n";
            this.薯條.UseVisualStyleBackColor = true;
            this.薯條.Click += new System.EventHandler(this.薯條_Click);
            // 
            // allmoney
            // 
            this.allmoney.AutoSize = true;
            this.allmoney.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.allmoney.Location = new System.Drawing.Point(4, 0);
            this.allmoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allmoney.Name = "allmoney";
            this.allmoney.Size = new System.Drawing.Size(147, 32);
            this.allmoney.TabIndex = 4;
            this.allmoney.Text = "尚未點餐";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.allmoney);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(629, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 313);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // allclear
            // 
            this.allclear.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.allclear.Location = new System.Drawing.Point(799, 382);
            this.allclear.Name = "allclear";
            this.allclear.Size = new System.Drawing.Size(163, 55);
            this.allclear.TabIndex = 7;
            this.allclear.Text = "清除清單";
            this.allclear.UseVisualStyleBackColor = true;
            this.allclear.Click += new System.EventHandler(this.allclear_Click);
            // 
            // paymoney
            // 
            this.paymoney.Location = new System.Drawing.Point(15, 37);
            this.paymoney.Name = "paymoney";
            this.paymoney.Size = new System.Drawing.Size(114, 108);
            this.paymoney.TabIndex = 8;
            this.paymoney.Text = "現金支付";
            this.paymoney.UseVisualStyleBackColor = true;
            this.paymoney.Click += new System.EventHandler(this.paymoney_Click);
            // 
            // paycridi
            // 
            this.paycridi.Location = new System.Drawing.Point(148, 39);
            this.paycridi.Name = "paycridi";
            this.paycridi.Size = new System.Drawing.Size(122, 105);
            this.paycridi.TabIndex = 9;
            this.paycridi.Text = "信用卡支付";
            this.paycridi.UseVisualStyleBackColor = true;
            this.paycridi.Click += new System.EventHandler(this.paycridi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(160, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "打9折！";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_red);
            this.groupBox1.Controls.Add(this.薯條);
            this.groupBox1.Controls.Add(this.漢堡);
            this.groupBox1.Controls.Add(this.酒);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(24, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(316, 368);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "餐點選項";
            // 
            // totalmoney
            // 
            this.totalmoney.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalmoney.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalmoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalmoney.Location = new System.Drawing.Point(105, 37);
            this.totalmoney.Name = "totalmoney";
            this.totalmoney.Size = new System.Drawing.Size(151, 37);
            this.totalmoney.TabIndex = 5;
            this.totalmoney.Text = "0";
            this.totalmoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalmoney.Click += new System.EventHandler(this.totalmoney_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(-1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "總額:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.totalmoney);
            this.panel1.Location = new System.Drawing.Point(347, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 91);
            this.panel1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.paycridi);
            this.groupBox2.Controls.Add(this.paymoney);
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(347, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 171);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "結帳";
            // 
            // btn_red
            // 
            this.btn_red.Location = new System.Drawing.Point(172, 194);
            this.btn_red.Margin = new System.Windows.Forms.Padding(4);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(129, 93);
            this.btn_red.TabIndex = 4;
            this.btn_red.Text = "紅茶\r\nNT50";
            this.btn_red.UseVisualStyleBackColor = true;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.allclear);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 酒;
        private System.Windows.Forms.Button 漢堡;
        private System.Windows.Forms.Button 薯條;
        private System.Windows.Forms.Label allmoney;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button allclear;
        private System.Windows.Forms.Button paymoney;
        private System.Windows.Forms.Button paycridi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalmoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_red;
    }
}

