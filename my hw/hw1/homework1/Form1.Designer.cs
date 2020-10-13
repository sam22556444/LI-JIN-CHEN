namespace homework1
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
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_egname = new System.Windows.Forms.TextBox();
            this.cb_male = new System.Windows.Forms.ComboBox();
            this.btn_hello = new System.Windows.Forms.Button();
            this.cb_star = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name.Location = new System.Drawing.Point(49, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(111, 40);
            this.name.TabIndex = 0;
            this.name.Text = "name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(49, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "english name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(49, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "性別:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(49, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "星座:";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_name.Location = new System.Drawing.Point(324, 25);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(211, 51);
            this.tb_name.TabIndex = 4;
            // 
            // tb_egname
            // 
            this.tb_egname.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_egname.Location = new System.Drawing.Point(324, 93);
            this.tb_egname.Name = "tb_egname";
            this.tb_egname.Size = new System.Drawing.Size(211, 51);
            this.tb_egname.TabIndex = 6;
            // 
            // cb_male
            // 
            this.cb_male.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_male.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_male.FormattingEnabled = true;
            this.cb_male.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cb_male.Location = new System.Drawing.Point(324, 164);
            this.cb_male.Name = "cb_male";
            this.cb_male.Size = new System.Drawing.Size(211, 44);
            this.cb_male.TabIndex = 6;
            this.cb_male.SelectedIndexChanged += new System.EventHandler(this.cb_male_SelectedIndexChanged);
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(103, 322);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(176, 62);
            this.btn_hello.TabIndex = 7;
            this.btn_hello.Text = "hello";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // cb_star
            // 
            this.cb_star.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_star.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_star.FormattingEnabled = true;
            this.cb_star.Items.AddRange(new object[] {
            "水瓶座",
            "雙魚座",
            "牧羊座",
            "金牛座",
            "雙子座",
            "巨蟹座",
            "獅子座",
            "處女座",
            "天秤座",
            "天蠍座",
            "射手座",
            "摩羯座"});
            this.cb_star.Location = new System.Drawing.Point(324, 232);
            this.cb_star.Name = "cb_star";
            this.cb_star.Size = new System.Drawing.Size(211, 44);
            this.cb_star.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "你好";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_star);
            this.Controls.Add(this.btn_hello);
            this.Controls.Add(this.cb_male);
            this.Controls.Add(this.tb_egname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_egname;
        private System.Windows.Forms.ComboBox cb_male;
        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.ComboBox cb_star;
        private System.Windows.Forms.Button button1;
    }
}

