namespace hw5
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
            System.Windows.Forms.ColumnHeader math1;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_english = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_math = new System.Windows.Forms.TextBox();
            this.tb_chinese = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_ran = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lb_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_math = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_english = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_chinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_tot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_max = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ran20 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_clear = new System.Windows.Forms.Button();
            math1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // math1
            // 
            math1.Text = "            數學";
            math1.Width = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(52, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "數學";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(52, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(52, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "中文";
            // 
            // tb_english
            // 
            this.tb_english.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_english.Location = new System.Drawing.Point(231, 207);
            this.tb_english.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_english.Name = "tb_english";
            this.tb_english.Size = new System.Drawing.Size(148, 45);
            this.tb_english.TabIndex = 4;
            this.tb_english.Text = "0";
            this.tb_english.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_name.Location = new System.Drawing.Point(231, 60);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(148, 45);
            this.tb_name.TabIndex = 5;
            this.tb_name.Text = "0";
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_math
            // 
            this.tb_math.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_math.Location = new System.Drawing.Point(231, 134);
            this.tb_math.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_math.Name = "tb_math";
            this.tb_math.Size = new System.Drawing.Size(148, 45);
            this.tb_math.TabIndex = 6;
            this.tb_math.Text = "0";
            this.tb_math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_chinese
            // 
            this.tb_chinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_chinese.Location = new System.Drawing.Point(231, 280);
            this.tb_chinese.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_chinese.Name = "tb_chinese";
            this.tb_chinese.Size = new System.Drawing.Size(148, 45);
            this.tb_chinese.TabIndex = 7;
            this.tb_chinese.Text = "0";
            this.tb_chinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(60, 358);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 63);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "加入學生";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_ran
            // 
            this.btn_ran.Location = new System.Drawing.Point(60, 430);
            this.btn_ran.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ran.Name = "btn_ran";
            this.btn_ran.Size = new System.Drawing.Size(123, 54);
            this.btn_ran.TabIndex = 10;
            this.btn_ran.Text = "隨機加入";
            this.btn_ran.UseVisualStyleBackColor = true;
            this.btn_ran.Click += new System.EventHandler(this.btn_ran_Click);
            // 
            // btn_total
            // 
            this.btn_total.Enabled = false;
            this.btn_total.Location = new System.Drawing.Point(59, 492);
            this.btn_total.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(123, 60);
            this.btn_total.TabIndex = 12;
            this.btn_total.Text = "統計資料";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lb_name,
            this.lb_math,
            this.lb_english,
            this.lb_chinese,
            this.lb_tot,
            this.lb_max,
            this.lb_min});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(495, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(514, 334);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lb_name
            // 
            this.lb_name.Text = "姓名";
            this.lb_name.Width = 40;
            // 
            // lb_math
            // 
            this.lb_math.Text = "數學";
            this.lb_math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lb_math.Width = 40;
            // 
            // lb_english
            // 
            this.lb_english.Text = "英文";
            this.lb_english.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lb_english.Width = 40;
            // 
            // lb_chinese
            // 
            this.lb_chinese.Text = "中文";
            this.lb_chinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lb_chinese.Width = 40;
            // 
            // lb_tot
            // 
            this.lb_tot.Text = "總分";
            this.lb_tot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lb_tot.Width = 45;
            // 
            // lb_max
            // 
            this.lb_max.Text = "最高分";
            this.lb_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_min
            // 
            this.lb_min.Text = "最低分";
            this.lb_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ran20
            // 
            this.btn_ran20.Location = new System.Drawing.Point(218, 430);
            this.btn_ran20.Name = "btn_ran20";
            this.btn_ran20.Size = new System.Drawing.Size(128, 54);
            this.btn_ran20.TabIndex = 14;
            this.btn_ran20.Text = "隨機加入*20";
            this.btn_ran20.UseVisualStyleBackColor = true;
            this.btn_ran20.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            math1,
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(492, 382);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(517, 175);
            this.listView2.TabIndex = 16;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "英文";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "中文";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 115;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(218, 492);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(128, 60);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "重設資料";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 567);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btn_ran20);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.btn_ran);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_chinese);
            this.Controls.Add(this.tb_math);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_english);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox tb_english;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_math;
        private System.Windows.Forms.TextBox tb_chinese;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_ran;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lb_english;
        private System.Windows.Forms.ColumnHeader lb_chinese;
        private System.Windows.Forms.ColumnHeader lb_name;
        private System.Windows.Forms.ColumnHeader lb_tot;
        private System.Windows.Forms.ColumnHeader lb_max;
        private System.Windows.Forms.ColumnHeader lb_min;
        private System.Windows.Forms.Button btn_ran20;
        private System.Windows.Forms.ColumnHeader lb_math;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_clear;
    }
}

