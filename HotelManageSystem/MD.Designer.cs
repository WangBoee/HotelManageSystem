namespace QWQ
{
    partial class MD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MD));
            this.manageMD = new System.Windows.Forms.TabControl();
            this.roomManage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.queryRoom = new System.Windows.Forms.Button();
            this.sureToSearch = new System.Windows.Forms.Button();
            this.searchRoomNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showRoomInformation = new System.Windows.Forms.DataGridView();
            this.roomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_full = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sureToDelete = new System.Windows.Forms.Button();
            this.deleteRoomNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sureToAdd = new System.Windows.Forms.Button();
            this.addRoomType = new System.Windows.Forms.ComboBox();
            this.addRoomNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.staffManage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.addStaffPos = new System.Windows.Forms.ComboBox();
            this.addStaffSex = new System.Windows.Forms.ComboBox();
            this.sureToAddStaff = new System.Windows.Forms.Button();
            this.addStaffPhone = new System.Windows.Forms.TextBox();
            this.addStaffAge = new System.Windows.Forms.TextBox();
            this.addStaffName = new System.Windows.Forms.TextBox();
            this.addStaffNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.showAllStaff = new System.Windows.Forms.Button();
            this.sureToDeleteStaff = new System.Windows.Forms.Button();
            this.sureToSearchStaff = new System.Windows.Forms.Button();
            this.searchStaffNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.showStaff = new System.Windows.Forms.DataGridView();
            this.staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billManage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.busearchBillAll = new System.Windows.Forms.Button();
            this.searchBillTime = new System.Windows.Forms.Button();
            this.billEndTimeMD = new System.Windows.Forms.DateTimePicker();
            this.billBeginTimeMD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.showBillMD = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.allBill = new System.Windows.Forms.Label();
            this.allCounts = new System.Windows.Forms.Label();
            this.manageMD.SuspendLayout();
            this.roomManage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomInformation)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.staffManage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showStaff)).BeginInit();
            this.billManage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showBillMD)).BeginInit();
            this.SuspendLayout();
            // 
            // manageMD
            // 
            this.manageMD.Controls.Add(this.roomManage);
            this.manageMD.Controls.Add(this.staffManage);
            this.manageMD.Controls.Add(this.billManage);
            this.manageMD.Location = new System.Drawing.Point(-1, 0);
            this.manageMD.Name = "manageMD";
            this.manageMD.SelectedIndex = 0;
            this.manageMD.Size = new System.Drawing.Size(1108, 630);
            this.manageMD.TabIndex = 0;
            // 
            // roomManage
            // 
            this.roomManage.Controls.Add(this.groupBox2);
            this.roomManage.Location = new System.Drawing.Point(4, 25);
            this.roomManage.Name = "roomManage";
            this.roomManage.Padding = new System.Windows.Forms.Padding(3);
            this.roomManage.Size = new System.Drawing.Size(1100, 601);
            this.roomManage.TabIndex = 0;
            this.roomManage.Text = "房间管理";
            this.roomManage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.showRoomInformation);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1091, 589);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "房间管理";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.queryRoom);
            this.groupBox6.Controls.Add(this.sureToSearch);
            this.groupBox6.Controls.Add(this.searchRoomNumber);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(741, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(315, 161);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "房间查询";
            // 
            // queryRoom
            // 
            this.queryRoom.Location = new System.Drawing.Point(101, 107);
            this.queryRoom.Name = "queryRoom";
            this.queryRoom.Size = new System.Drawing.Size(94, 43);
            this.queryRoom.TabIndex = 10;
            this.queryRoom.Text = "查询全部";
            this.queryRoom.UseVisualStyleBackColor = true;
            this.queryRoom.Click += new System.EventHandler(this.queryRoom_Click);
            // 
            // sureToSearch
            // 
            this.sureToSearch.Location = new System.Drawing.Point(212, 107);
            this.sureToSearch.Name = "sureToSearch";
            this.sureToSearch.Size = new System.Drawing.Size(88, 43);
            this.sureToSearch.TabIndex = 5;
            this.sureToSearch.Text = "确认";
            this.sureToSearch.UseVisualStyleBackColor = true;
            this.sureToSearch.Click += new System.EventHandler(this.sureToSearch_Click);
            // 
            // searchRoomNumber
            // 
            this.searchRoomNumber.Location = new System.Drawing.Point(112, 32);
            this.searchRoomNumber.Name = "searchRoomNumber";
            this.searchRoomNumber.Size = new System.Drawing.Size(121, 25);
            this.searchRoomNumber.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "房间号";
            // 
            // showRoomInformation
            // 
            this.showRoomInformation.AllowUserToAddRows = false;
            this.showRoomInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showRoomInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showRoomInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomID,
            this.roomType,
            this.roomPrice,
            this.is_full});
            this.showRoomInformation.Location = new System.Drawing.Point(29, 191);
            this.showRoomInformation.Name = "showRoomInformation";
            this.showRoomInformation.RowHeadersWidth = 51;
            this.showRoomInformation.RowTemplate.Height = 27;
            this.showRoomInformation.Size = new System.Drawing.Size(1027, 369);
            this.showRoomInformation.TabIndex = 2;
            // 
            // roomID
            // 
            this.roomID.DataPropertyName = "room_id";
            this.roomID.HeaderText = "房号";
            this.roomID.MinimumWidth = 6;
            this.roomID.Name = "roomID";
            // 
            // roomType
            // 
            this.roomType.DataPropertyName = "name";
            this.roomType.HeaderText = "房间类型";
            this.roomType.MinimumWidth = 6;
            this.roomType.Name = "roomType";
            // 
            // roomPrice
            // 
            this.roomPrice.DataPropertyName = "price";
            this.roomPrice.HeaderText = "房间价格";
            this.roomPrice.MinimumWidth = 6;
            this.roomPrice.Name = "roomPrice";
            // 
            // is_full
            // 
            this.is_full.DataPropertyName = "is_full";
            this.is_full.HeaderText = "是否空房";
            this.is_full.MinimumWidth = 6;
            this.is_full.Name = "is_full";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sureToDelete);
            this.groupBox5.Controls.Add(this.deleteRoomNumber);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(431, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 161);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "删除房间";
            // 
            // sureToDelete
            // 
            this.sureToDelete.Location = new System.Drawing.Point(189, 107);
            this.sureToDelete.Name = "sureToDelete";
            this.sureToDelete.Size = new System.Drawing.Size(82, 44);
            this.sureToDelete.TabIndex = 1;
            this.sureToDelete.Text = "确定";
            this.sureToDelete.UseVisualStyleBackColor = true;
            this.sureToDelete.Click += new System.EventHandler(this.sureToDelete_Click);
            // 
            // deleteRoomNumber
            // 
            this.deleteRoomNumber.Location = new System.Drawing.Point(104, 42);
            this.deleteRoomNumber.Name = "deleteRoomNumber";
            this.deleteRoomNumber.Size = new System.Drawing.Size(100, 25);
            this.deleteRoomNumber.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "房间号";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sureToAdd);
            this.groupBox4.Controls.Add(this.addRoomType);
            this.groupBox4.Controls.Add(this.addRoomNumber);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(29, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 161);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "添加房间";
            // 
            // sureToAdd
            // 
            this.sureToAdd.Location = new System.Drawing.Point(280, 108);
            this.sureToAdd.Name = "sureToAdd";
            this.sureToAdd.Size = new System.Drawing.Size(85, 44);
            this.sureToAdd.TabIndex = 0;
            this.sureToAdd.Text = "确认";
            this.sureToAdd.UseVisualStyleBackColor = true;
            this.sureToAdd.Click += new System.EventHandler(this.sureToAdd_Click);
            // 
            // addRoomType
            // 
            this.addRoomType.FormattingEnabled = true;
            this.addRoomType.Items.AddRange(new object[] {
            "单人间",
            "标准间",
            "豪华间",
            "商务间",
            "行政间"});
            this.addRoomType.Location = new System.Drawing.Point(115, 94);
            this.addRoomType.Name = "addRoomType";
            this.addRoomType.Size = new System.Drawing.Size(121, 23);
            this.addRoomType.TabIndex = 3;
            // 
            // addRoomNumber
            // 
            this.addRoomNumber.Location = new System.Drawing.Point(115, 39);
            this.addRoomNumber.Name = "addRoomNumber";
            this.addRoomNumber.Size = new System.Drawing.Size(121, 25);
            this.addRoomNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "房间类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "房间号";
            // 
            // staffManage
            // 
            this.staffManage.Controls.Add(this.groupBox3);
            this.staffManage.Location = new System.Drawing.Point(4, 25);
            this.staffManage.Name = "staffManage";
            this.staffManage.Padding = new System.Windows.Forms.Padding(3);
            this.staffManage.Size = new System.Drawing.Size(1100, 601);
            this.staffManage.TabIndex = 1;
            this.staffManage.Text = "职工管理";
            this.staffManage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.showStaff);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1091, 592);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "职工管理";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.addStaffPos);
            this.groupBox8.Controls.Add(this.addStaffSex);
            this.groupBox8.Controls.Add(this.sureToAddStaff);
            this.groupBox8.Controls.Add(this.addStaffPhone);
            this.groupBox8.Controls.Add(this.addStaffAge);
            this.groupBox8.Controls.Add(this.addStaffName);
            this.groupBox8.Controls.Add(this.addStaffNumber);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.age);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(402, 24);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(658, 164);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "添加员工";
            // 
            // addStaffPos
            // 
            this.addStaffPos.FormattingEnabled = true;
            this.addStaffPos.Items.AddRange(new object[] {
            "前台",
            "会计",
            "总经理"});
            this.addStaffPos.Location = new System.Drawing.Point(103, 79);
            this.addStaffPos.Name = "addStaffPos";
            this.addStaffPos.Size = new System.Drawing.Size(107, 23);
            this.addStaffPos.TabIndex = 2;
            // 
            // addStaffSex
            // 
            this.addStaffSex.FormattingEnabled = true;
            this.addStaffSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.addStaffSex.Location = new System.Drawing.Point(502, 32);
            this.addStaffSex.Name = "addStaffSex";
            this.addStaffSex.Size = new System.Drawing.Size(136, 23);
            this.addStaffSex.TabIndex = 2;
            // 
            // sureToAddStaff
            // 
            this.sureToAddStaff.Location = new System.Drawing.Point(523, 114);
            this.sureToAddStaff.Name = "sureToAddStaff";
            this.sureToAddStaff.Size = new System.Drawing.Size(100, 44);
            this.sureToAddStaff.TabIndex = 2;
            this.sureToAddStaff.Text = "添加";
            this.sureToAddStaff.UseVisualStyleBackColor = true;
            this.sureToAddStaff.Click += new System.EventHandler(this.sureToAddStaff_Click);
            // 
            // addStaffPhone
            // 
            this.addStaffPhone.Location = new System.Drawing.Point(502, 77);
            this.addStaffPhone.Name = "addStaffPhone";
            this.addStaffPhone.Size = new System.Drawing.Size(136, 25);
            this.addStaffPhone.TabIndex = 2;
            // 
            // addStaffAge
            // 
            this.addStaffAge.Location = new System.Drawing.Point(305, 77);
            this.addStaffAge.Name = "addStaffAge";
            this.addStaffAge.Size = new System.Drawing.Size(100, 25);
            this.addStaffAge.TabIndex = 2;
            // 
            // addStaffName
            // 
            this.addStaffName.Location = new System.Drawing.Point(305, 33);
            this.addStaffName.Name = "addStaffName";
            this.addStaffName.Size = new System.Drawing.Size(100, 25);
            this.addStaffName.TabIndex = 2;
            // 
            // addStaffNumber
            // 
            this.addStaffNumber.Location = new System.Drawing.Point(103, 33);
            this.addStaffNumber.Name = "addStaffNumber";
            this.addStaffNumber.Size = new System.Drawing.Size(107, 25);
            this.addStaffNumber.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(442, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "电话";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(442, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "性别";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(244, 87);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(37, 15);
            this.age.TabIndex = 10;
            this.age.Text = "年龄";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(244, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "姓名";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "员工种类";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "员工号";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.showAllStaff);
            this.groupBox7.Controls.Add(this.sureToDeleteStaff);
            this.groupBox7.Controls.Add(this.sureToSearchStaff);
            this.groupBox7.Controls.Add(this.searchStaffNumber);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(31, 24);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(353, 164);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "员工操作";
            // 
            // showAllStaff
            // 
            this.showAllStaff.Location = new System.Drawing.Point(233, 104);
            this.showAllStaff.Name = "showAllStaff";
            this.showAllStaff.Size = new System.Drawing.Size(102, 37);
            this.showAllStaff.TabIndex = 2;
            this.showAllStaff.Text = "显示全部";
            this.showAllStaff.UseVisualStyleBackColor = true;
            this.showAllStaff.Click += new System.EventHandler(this.showAllStaff_Click);
            // 
            // sureToDeleteStaff
            // 
            this.sureToDeleteStaff.Location = new System.Drawing.Point(125, 104);
            this.sureToDeleteStaff.Name = "sureToDeleteStaff";
            this.sureToDeleteStaff.Size = new System.Drawing.Size(102, 37);
            this.sureToDeleteStaff.TabIndex = 2;
            this.sureToDeleteStaff.Text = "删除";
            this.sureToDeleteStaff.UseVisualStyleBackColor = true;
            this.sureToDeleteStaff.Click += new System.EventHandler(this.sureToDeleteStaff_Click);
            // 
            // sureToSearchStaff
            // 
            this.sureToSearchStaff.Location = new System.Drawing.Point(17, 104);
            this.sureToSearchStaff.Name = "sureToSearchStaff";
            this.sureToSearchStaff.Size = new System.Drawing.Size(102, 37);
            this.sureToSearchStaff.TabIndex = 2;
            this.sureToSearchStaff.Text = "搜索";
            this.sureToSearchStaff.UseVisualStyleBackColor = true;
            this.sureToSearchStaff.Click += new System.EventHandler(this.sureToSearchStaff_Click);
            // 
            // searchStaffNumber
            // 
            this.searchStaffNumber.Location = new System.Drawing.Point(106, 36);
            this.searchStaffNumber.Name = "searchStaffNumber";
            this.searchStaffNumber.Size = new System.Drawing.Size(192, 25);
            this.searchStaffNumber.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "员工号";
            // 
            // showStaff
            // 
            this.showStaff.AllowUserToAddRows = false;
            this.showStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staff_id,
            this.name,
            this.sex,
            this.position,
            this.staffAge,
            this.phone});
            this.showStaff.Location = new System.Drawing.Point(31, 194);
            this.showStaff.Name = "showStaff";
            this.showStaff.RowHeadersWidth = 51;
            this.showStaff.RowTemplate.Height = 27;
            this.showStaff.Size = new System.Drawing.Size(1029, 367);
            this.showStaff.TabIndex = 0;
            // 
            // staff_id
            // 
            this.staff_id.DataPropertyName = "staff_id";
            this.staff_id.HeaderText = "员工号";
            this.staff_id.MinimumWidth = 6;
            this.staff_id.Name = "staff_id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "职位";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            // 
            // staffAge
            // 
            this.staffAge.DataPropertyName = "age";
            this.staffAge.HeaderText = "年龄";
            this.staffAge.MinimumWidth = 6;
            this.staffAge.Name = "staffAge";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "电话号码";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // billManage
            // 
            this.billManage.Controls.Add(this.groupBox1);
            this.billManage.Location = new System.Drawing.Point(4, 25);
            this.billManage.Name = "billManage";
            this.billManage.Size = new System.Drawing.Size(1100, 601);
            this.billManage.TabIndex = 2;
            this.billManage.Text = "账单管理";
            this.billManage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allCounts);
            this.groupBox1.Controls.Add(this.allBill);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.busearchBillAll);
            this.groupBox1.Controls.Add(this.searchBillTime);
            this.groupBox1.Controls.Add(this.billEndTimeMD);
            this.groupBox1.Controls.Add(this.billBeginTimeMD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.showBillMD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 586);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "时间段选择账单";
            // 
            // busearchBillAll
            // 
            this.busearchBillAll.Location = new System.Drawing.Point(928, 113);
            this.busearchBillAll.Name = "busearchBillAll";
            this.busearchBillAll.Size = new System.Drawing.Size(147, 41);
            this.busearchBillAll.TabIndex = 2;
            this.busearchBillAll.Text = "查询全部";
            this.busearchBillAll.UseVisualStyleBackColor = true;
            this.busearchBillAll.Click += new System.EventHandler(this.busearchBillAll_Click);
            // 
            // searchBillTime
            // 
            this.searchBillTime.Location = new System.Drawing.Point(766, 113);
            this.searchBillTime.Name = "searchBillTime";
            this.searchBillTime.Size = new System.Drawing.Size(147, 41);
            this.searchBillTime.TabIndex = 2;
            this.searchBillTime.Text = "查询";
            this.searchBillTime.UseVisualStyleBackColor = true;
            this.searchBillTime.Click += new System.EventHandler(this.searchBillTime_Click);
            // 
            // billEndTimeMD
            // 
            this.billEndTimeMD.Location = new System.Drawing.Point(329, 106);
            this.billEndTimeMD.Name = "billEndTimeMD";
            this.billEndTimeMD.Size = new System.Drawing.Size(200, 25);
            this.billEndTimeMD.TabIndex = 1;
            // 
            // billBeginTimeMD
            // 
            this.billBeginTimeMD.Location = new System.Drawing.Point(40, 106);
            this.billBeginTimeMD.Name = "billBeginTimeMD";
            this.billBeginTimeMD.Size = new System.Drawing.Size(200, 25);
            this.billBeginTimeMD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "时间段选择";
            // 
            // showBillMD
            // 
            this.showBillMD.AllowUserToAddRows = false;
            this.showBillMD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showBillMD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showBillMD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.book_time,
            this.room_id,
            this.customer_id,
            this.in_time,
            this.out_time,
            this.prices});
            this.showBillMD.Location = new System.Drawing.Point(6, 168);
            this.showBillMD.Name = "showBillMD";
            this.showBillMD.ReadOnly = true;
            this.showBillMD.RowHeadersWidth = 51;
            this.showBillMD.RowTemplate.Height = 27;
            this.showBillMD.Size = new System.Drawing.Size(1069, 412);
            this.showBillMD.TabIndex = 5;
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
            this.book_time.HeaderText = "订单生成日期";
            this.book_time.MinimumWidth = 6;
            this.book_time.Name = "book_time";
            this.book_time.ReadOnly = true;
            // 
            // room_id
            // 
            this.room_id.DataPropertyName = "room_id";
            this.room_id.HeaderText = "房号";
            this.room_id.MinimumWidth = 6;
            this.room_id.Name = "room_id";
            this.room_id.ReadOnly = true;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "顾客身份证";
            this.customer_id.MinimumWidth = 6;
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            // 
            // in_time
            // 
            this.in_time.DataPropertyName = "in_time";
            this.in_time.HeaderText = "入住日期";
            this.in_time.MinimumWidth = 6;
            this.in_time.Name = "in_time";
            this.in_time.ReadOnly = true;
            // 
            // out_time
            // 
            this.out_time.DataPropertyName = "out_time";
            this.out_time.HeaderText = "离店日期";
            this.out_time.MinimumWidth = 6;
            this.out_time.Name = "out_time";
            this.out_time.ReadOnly = true;
            // 
            // prices
            // 
            this.prices.DataPropertyName = "prices";
            this.prices.HeaderText = "所有消费";
            this.prices.MinimumWidth = 6;
            this.prices.Name = "prices";
            this.prices.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "—";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(738, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "  总收入：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(738, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 26);
            this.label12.TabIndex = 8;
            this.label12.Text = "总订单数：";
            // 
            // allBill
            // 
            this.allBill.AutoSize = true;
            this.allBill.Font = new System.Drawing.Font("微软雅黑", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allBill.Location = new System.Drawing.Point(838, 21);
            this.allBill.Name = "allBill";
            this.allBill.Size = new System.Drawing.Size(83, 26);
            this.allBill.TabIndex = 9;
            this.allBill.Text = "label13";
            // 
            // allCounts
            // 
            this.allCounts.AutoSize = true;
            this.allCounts.Font = new System.Drawing.Font("微软雅黑", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allCounts.Location = new System.Drawing.Point(838, 59);
            this.allCounts.Name = "allCounts";
            this.allCounts.Size = new System.Drawing.Size(83, 26);
            this.allCounts.TabIndex = 9;
            this.allCounts.Text = "label13";
            // 
            // MD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1103, 631);
            this.Controls.Add(this.manageMD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MD";
            this.Text = "全局管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MD_FormClosed);
            this.Load += new System.EventHandler(this.MD_Load);
            this.manageMD.ResumeLayout(false);
            this.roomManage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomInformation)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.staffManage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showStaff)).EndInit();
            this.billManage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showBillMD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl manageMD;
        private System.Windows.Forms.TabPage roomManage;
        private System.Windows.Forms.TabPage staffManage;
        private System.Windows.Forms.TabPage billManage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBillTime;
        private System.Windows.Forms.DateTimePicker billEndTimeMD;
        private System.Windows.Forms.DateTimePicker billBeginTimeMD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView showBillMD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox searchRoomNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sureToSearch;
        private System.Windows.Forms.DataGridView showRoomInformation;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox deleteRoomNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sureToDelete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox addRoomNumber;
        private System.Windows.Forms.ComboBox addRoomType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sureToAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button sureToDeleteStaff;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button sureToAddStaff;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox searchStaffNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sureToSearchStaff;
        private System.Windows.Forms.DataGridView showStaff;
        private System.Windows.Forms.TextBox addStaffNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addStaffName;
        private System.Windows.Forms.TextBox addStaffAge;
        private System.Windows.Forms.TextBox addStaffPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_full;
        private System.Windows.Forms.Button queryRoom;
        private System.Windows.Forms.Button showAllStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.ComboBox addStaffSex;
        private System.Windows.Forms.ComboBox addStaffPos;
        private System.Windows.Forms.Button busearchBillAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn in_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn out_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn prices;
        private System.Windows.Forms.Label allCounts;
        private System.Windows.Forms.Label allBill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
    }
}