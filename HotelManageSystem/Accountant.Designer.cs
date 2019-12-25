namespace Manager
{
    partial class Accountant
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountant));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBillData = new System.Windows.Forms.DataGridView();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.searchDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchAll = new System.Windows.Forms.Button();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.counts = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.allBill = new System.Windows.Forms.Label();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(316, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "宾馆数据报表";
            // 
            // dgvBillData
            // 
            this.dgvBillData.AllowUserToAddRows = false;
            this.dgvBillData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.book_time,
            this.price,
            this.deposit,
            this.other_money});
            this.dgvBillData.Location = new System.Drawing.Point(6, 110);
            this.dgvBillData.MultiSelect = false;
            this.dgvBillData.Name = "dgvBillData";
            this.dgvBillData.RowHeadersWidth = 51;
            this.dgvBillData.RowTemplate.Height = 27;
            this.dgvBillData.Size = new System.Drawing.Size(842, 355);
            this.dgvBillData.TabIndex = 1;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Location = new System.Drawing.Point(40, 66);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(169, 25);
            this.dtpStartTime.TabIndex = 4;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Location = new System.Drawing.Point(282, 65);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(169, 25);
            this.dtpEndTime.TabIndex = 4;
            // 
            // searchDate
            // 
            this.searchDate.Location = new System.Drawing.Point(561, 47);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(115, 44);
            this.searchDate.TabIndex = 5;
            this.searchDate.Text = "日期查询";
            this.searchDate.UseVisualStyleBackColor = true;
            this.searchDate.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(232, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchAll);
            this.groupBox1.Controls.Add(this.searchDate);
            this.groupBox1.Controls.Add(this.dtpEndTime);
            this.groupBox1.Controls.Add(this.dtpStartTime);
            this.groupBox1.Controls.Add(this.dgvBillData);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 471);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(35, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "时间段选择:";
            // 
            // searchAll
            // 
            this.searchAll.Location = new System.Drawing.Point(711, 46);
            this.searchAll.Name = "searchAll";
            this.searchAll.Size = new System.Drawing.Size(115, 44);
            this.searchAll.TabIndex = 5;
            this.searchAll.Text = "查询全部";
            this.searchAll.UseVisualStyleBackColor = true;
            this.searchAll.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "总单数：";
            // 
            // counts
            // 
            this.counts.AutoSize = true;
            this.counts.Location = new System.Drawing.Point(123, 550);
            this.counts.Name = "counts";
            this.counts.Size = new System.Drawing.Size(55, 15);
            this.counts.TabIndex = 6;
            this.counts.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "总收入：";
            // 
            // allBill
            // 
            this.allBill.AutoSize = true;
            this.allBill.Location = new System.Drawing.Point(482, 550);
            this.allBill.Name = "allBill";
            this.allBill.Size = new System.Drawing.Size(55, 15);
            this.allBill.TabIndex = 8;
            this.allBill.Text = "label7";
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "订单号";
            this.order_id.MinimumWidth = 6;
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            // 
            // book_time
            // 
            this.book_time.DataPropertyName = "book_time";
            this.book_time.HeaderText = "订单生产日期";
            this.book_time.MinimumWidth = 6;
            this.book_time.Name = "book_time";
            this.book_time.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "总房费";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // deposit
            // 
            this.deposit.DataPropertyName = "deposit";
            this.deposit.HeaderText = "押金";
            this.deposit.MinimumWidth = 6;
            this.deposit.Name = "deposit";
            this.deposit.ReadOnly = true;
            // 
            // other_money
            // 
            this.other_money.DataPropertyName = "other_money";
            this.other_money.HeaderText = "其他消费";
            this.other_money.MinimumWidth = 6;
            this.other_money.Name = "other_money";
            this.other_money.ReadOnly = true;
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 589);
            this.Controls.Add(this.allBill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.counts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accountant";
            this.Text = "账单";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Accountant_FormClosed);
            this.Load += new System.EventHandler(this.Accountant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBillData;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Button searchDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.Button searchAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn other_money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label counts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label allBill;
    }
}

