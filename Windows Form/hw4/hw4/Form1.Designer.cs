namespace hw4
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_chi = new System.Windows.Forms.TextBox();
            this.tb_english = new System.Windows.Forms.TextBox();
            this.tb_math = new System.Windows.Forms.TextBox();
            this.btn_stu = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_sc = new System.Windows.Forms.Label();
            this.bt_max = new System.Windows.Forms.Button();
            this.lb_max = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.成績 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.成績.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(71, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(71, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(71, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(71, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學:";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_name.Location = new System.Drawing.Point(210, 68);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(198, 50);
            this.tb_name.TabIndex = 4;
            this.tb_name.Text = "0";
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_chi
            // 
            this.tb_chi.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_chi.Location = new System.Drawing.Point(210, 140);
            this.tb_chi.Name = "tb_chi";
            this.tb_chi.Size = new System.Drawing.Size(198, 50);
            this.tb_chi.TabIndex = 5;
            this.tb_chi.Text = "0";
            this.tb_chi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_english
            // 
            this.tb_english.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_english.Location = new System.Drawing.Point(210, 212);
            this.tb_english.Name = "tb_english";
            this.tb_english.Size = new System.Drawing.Size(198, 50);
            this.tb_english.TabIndex = 6;
            this.tb_english.Text = "0";
            this.tb_english.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_math
            // 
            this.tb_math.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_math.Location = new System.Drawing.Point(210, 284);
            this.tb_math.Name = "tb_math";
            this.tb_math.Size = new System.Drawing.Size(198, 50);
            this.tb_math.TabIndex = 7;
            this.tb_math.Text = "0";
            this.tb_math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_stu
            // 
            this.btn_stu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_stu.Location = new System.Drawing.Point(47, 364);
            this.btn_stu.Name = "btn_stu";
            this.btn_stu.Size = new System.Drawing.Size(190, 74);
            this.btn_stu.TabIndex = 8;
            this.btn_stu.Text = "加入";
            this.btn_stu.UseVisualStyleBackColor = true;
            this.btn_stu.Click += new System.EventHandler(this.btn_stu_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_add.Location = new System.Drawing.Point(280, 364);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(202, 69);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "顯示";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_sc
            // 
            this.lb_sc.AutoSize = true;
            this.lb_sc.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_sc.Location = new System.Drawing.Point(3, 0);
            this.lb_sc.Name = "lb_sc";
            this.lb_sc.Size = new System.Drawing.Size(0, 36);
            this.lb_sc.TabIndex = 10;
            // 
            // bt_max
            // 
            this.bt_max.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_max.Location = new System.Drawing.Point(600, 364);
            this.bt_max.Name = "bt_max";
            this.bt_max.Size = new System.Drawing.Size(223, 69);
            this.bt_max.TabIndex = 11;
            this.bt_max.Text = "最高分與最低分";
            this.bt_max.UseVisualStyleBackColor = true;
            this.bt_max.Click += new System.EventHandler(this.bt_max_Click);
            // 
            // lb_max
            // 
            this.lb_max.AutoSize = true;
            this.lb_max.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_max.Location = new System.Drawing.Point(3, 0);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(0, 31);
            this.lb_max.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.lb_sc);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 193);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.lb_max);
            this.flowLayoutPanel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(19, 231);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(345, 84);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // 成績
            // 
            this.成績.Controls.Add(this.flowLayoutPanel2);
            this.成績.Controls.Add(this.flowLayoutPanel1);
            this.成績.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.成績.Location = new System.Drawing.Point(448, 30);
            this.成績.Name = "成績";
            this.成績.Size = new System.Drawing.Size(387, 334);
            this.成績.TabIndex = 15;
            this.成績.TabStop = false;
            this.成績.Text = "成績";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.成績);
            this.Controls.Add(this.bt_max);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_stu);
            this.Controls.Add(this.tb_math);
            this.Controls.Add(this.tb_english);
            this.Controls.Add(this.tb_chi);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.成績.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_chi;
        private System.Windows.Forms.TextBox tb_english;
        private System.Windows.Forms.TextBox tb_math;
        private System.Windows.Forms.Button btn_stu;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lb_sc;
        private System.Windows.Forms.Button bt_max;
        private System.Windows.Forms.Label lb_max;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox 成績;
    }
}

