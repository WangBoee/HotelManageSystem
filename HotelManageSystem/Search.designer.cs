namespace QWQ
{
    partial class Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inquireDate = new System.Windows.Forms.DateTimePicker();
            this.affirmSearchAll = new System.Windows.Forms.Button();
            this.affirmSearchEmpty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRoomData = new System.Windows.Forms.DataGridView();
            this.room_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_full = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.订房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomData)).BeginInit();
            this.menuOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.inquireDate);
            this.groupBox1.Controls.Add(this.affirmSearchAll);
            this.groupBox1.Controls.Add(this.affirmSearchEmpty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "单人间",
            "标准间",
            "豪华间",
            "商务间",
            "行政间",
            "所有房间"});
            this.comboBox1.Location = new System.Drawing.Point(110, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // inquireDate
            // 
            this.inquireDate.Location = new System.Drawing.Point(282, 25);
            this.inquireDate.Name = "inquireDate";
            this.inquireDate.Size = new System.Drawing.Size(200, 25);
            this.inquireDate.TabIndex = 3;
            // 
            // affirmSearchAll
            // 
            this.affirmSearchAll.Location = new System.Drawing.Point(521, 19);
            this.affirmSearchAll.Name = "affirmSearchAll";
            this.affirmSearchAll.Size = new System.Drawing.Size(110, 36);
            this.affirmSearchAll.TabIndex = 2;
            this.affirmSearchAll.Text = "查询所有";
            this.affirmSearchAll.UseVisualStyleBackColor = true;
            this.affirmSearchAll.Click += new System.EventHandler(this.affirmSearchAll_Click);
            // 
            // affirmSearchEmpty
            // 
            this.affirmSearchEmpty.Location = new System.Drawing.Point(647, 19);
            this.affirmSearchEmpty.Name = "affirmSearchEmpty";
            this.affirmSearchEmpty.Size = new System.Drawing.Size(110, 36);
            this.affirmSearchEmpty.TabIndex = 2;
            this.affirmSearchEmpty.Text = "查询空房";
            this.affirmSearchEmpty.UseVisualStyleBackColor = true;
            this.affirmSearchEmpty.Click += new System.EventHandler(this.affirmSearchEmpty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "房间类型";
            // 
            // dgvRoomData
            // 
            this.dgvRoomData.AllowUserToAddRows = false;
            this.dgvRoomData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.room_id,
            this.is_full,
            this.type_name,
            this.price,
            this.deposit});
            this.dgvRoomData.ContextMenuStrip = this.menuOrder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoomData.Location = new System.Drawing.Point(13, 98);
            this.dgvRoomData.MultiSelect = false;
            this.dgvRoomData.Name = "dgvRoomData";
            this.dgvRoomData.RowHeadersWidth = 51;
            this.dgvRoomData.RowTemplate.Height = 27;
            this.dgvRoomData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomData.Size = new System.Drawing.Size(775, 340);
            this.dgvRoomData.TabIndex = 1;
            this.dgvRoomData.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoomData_CellMouseDown);
            // 
            // room_id
            // 
            this.room_id.DataPropertyName = "room_id";
            this.room_id.HeaderText = "房号";
            this.room_id.MinimumWidth = 6;
            this.room_id.Name = "room_id";
            this.room_id.ReadOnly = true;
            this.room_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // is_full
            // 
            this.is_full.DataPropertyName = "is_full";
            this.is_full.HeaderText = "入住状态";
            this.is_full.MinimumWidth = 6;
            this.is_full.Name = "is_full";
            this.is_full.ReadOnly = true;
            // 
            // type_name
            // 
            this.type_name.DataPropertyName = "name";
            this.type_name.HeaderText = "房间类型";
            this.type_name.MinimumWidth = 6;
            this.type_name.Name = "type_name";
            this.type_name.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "房间价格";
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
            // menuOrder
            // 
            this.menuOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.订房ToolStripMenuItem});
            this.menuOrder.Name = "menuOrder";
            this.menuOrder.Size = new System.Drawing.Size(109, 28);
            // 
            // 订房ToolStripMenuItem
            // 
            this.订房ToolStripMenuItem.Name = "订房ToolStripMenuItem";
            this.订房ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.订房ToolStripMenuItem.Text = "订房";
            this.订房ToolStripMenuItem.Click += new System.EventHandler(this.订房ToolStripMenuItem_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRoomData);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "房间查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Search_FormClosed);
            this.Load += new System.EventHandler(this.Search_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomData)).EndInit();
            this.menuOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker inquireDate;
        private System.Windows.Forms.Button affirmSearchEmpty;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvRoomData;
        private System.Windows.Forms.ContextMenuStrip menuOrder;
        private System.Windows.Forms.ToolStripMenuItem 订房ToolStripMenuItem;
        private System.Windows.Forms.Button affirmSearchAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_full;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit;
    }
}

