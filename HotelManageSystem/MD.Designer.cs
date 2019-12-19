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
            this.searchRoomNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchRoomType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sureToSearch = new System.Windows.Forms.Button();
            this.showRoomInformation = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.deleteRoomNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sureToDelete = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addRoomNumber = new System.Windows.Forms.TextBox();
            this.addRoomType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sureToAdd = new System.Windows.Forms.Button();
            this.staffManage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.deleteStaffNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sureToDeleteStaff = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameStaffAdd = new System.Windows.Forms.TextBox();
            this.ageStaffAdd = new System.Windows.Forms.TextBox();
            this.sexStaffAdd = new System.Windows.Forms.TextBox();
            this.phoneNumberStaff = new System.Windows.Forms.TextBox();
            this.addStaffType = new System.Windows.Forms.TextBox();
            this.addStaffNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sureToAddStaff = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.searchStaffNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sureToSearchStaff = new System.Windows.Forms.Button();
            this.showStaff = new System.Windows.Forms.DataGridView();
            this.billManage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showBillMD = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBillTime = new System.Windows.Forms.Button();
            this.billEndTimeMD = new System.Windows.Forms.DateTimePicker();
            this.billBeginTimeMD = new System.Windows.Forms.DateTimePicker();
            this.manageMD.SuspendLayout();
            this.roomManage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomInformation)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.staffManage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
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
            this.groupBox6.Controls.Add(this.searchRoomNumber);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.searchRoomType);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.sureToSearch);
            this.groupBox6.Location = new System.Drawing.Point(741, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(315, 152);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "房间查询";
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
            this.label7.Location = new System.Drawing.Point(21, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "房间号";
            // 
            // searchRoomType
            // 
            this.searchRoomType.FormattingEnabled = true;
            this.searchRoomType.Location = new System.Drawing.Point(112, 77);
            this.searchRoomType.Name = "searchRoomType";
            this.searchRoomType.Size = new System.Drawing.Size(121, 23);
            this.searchRoomType.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "房间类型";
            // 
            // sureToSearch
            // 
            this.sureToSearch.Location = new System.Drawing.Point(234, 111);
            this.sureToSearch.Name = "sureToSearch";
            this.sureToSearch.Size = new System.Drawing.Size(75, 33);
            this.sureToSearch.TabIndex = 5;
            this.sureToSearch.Text = "确认";
            this.sureToSearch.UseVisualStyleBackColor = true;
            // 
            // showRoomInformation
            // 
            this.showRoomInformation.AllowUserToAddRows = false;
            this.showRoomInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showRoomInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showRoomInformation.Location = new System.Drawing.Point(29, 191);
            this.showRoomInformation.Name = "showRoomInformation";
            this.showRoomInformation.RowHeadersWidth = 51;
            this.showRoomInformation.RowTemplate.Height = 27;
            this.showRoomInformation.Size = new System.Drawing.Size(1027, 369);
            this.showRoomInformation.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.deleteRoomNumber);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.sureToDelete);
            this.groupBox5.Location = new System.Drawing.Point(431, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 161);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "删除房间";
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
            this.label5.Location = new System.Drawing.Point(23, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "房间号";
            // 
            // sureToDelete
            // 
            this.sureToDelete.Location = new System.Drawing.Point(208, 120);
            this.sureToDelete.Name = "sureToDelete";
            this.sureToDelete.Size = new System.Drawing.Size(75, 33);
            this.sureToDelete.TabIndex = 1;
            this.sureToDelete.Text = "确定";
            this.sureToDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addRoomNumber);
            this.groupBox4.Controls.Add(this.addRoomType);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.sureToAdd);
            this.groupBox4.Location = new System.Drawing.Point(29, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 161);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "添加房间";
            // 
            // addRoomNumber
            // 
            this.addRoomNumber.Location = new System.Drawing.Point(115, 39);
            this.addRoomNumber.Name = "addRoomNumber";
            this.addRoomNumber.Size = new System.Drawing.Size(121, 25);
            this.addRoomNumber.TabIndex = 4;
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
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "房间号";
            // 
            // sureToAdd
            // 
            this.sureToAdd.Location = new System.Drawing.Point(301, 120);
            this.sureToAdd.Name = "sureToAdd";
            this.sureToAdd.Size = new System.Drawing.Size(75, 33);
            this.sureToAdd.TabIndex = 0;
            this.sureToAdd.Text = "确认";
            this.sureToAdd.UseVisualStyleBackColor = true;
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
            this.groupBox3.Controls.Add(this.groupBox9);
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
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.deleteStaffNumber);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.sureToDeleteStaff);
            this.groupBox9.Location = new System.Drawing.Point(31, 108);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(353, 80);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "开除员工";
            // 
            // deleteStaffNumber
            // 
            this.deleteStaffNumber.Location = new System.Drawing.Point(86, 30);
            this.deleteStaffNumber.Name = "deleteStaffNumber";
            this.deleteStaffNumber.Size = new System.Drawing.Size(140, 25);
            this.deleteStaffNumber.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "员工号";
            // 
            // sureToDeleteStaff
            // 
            this.sureToDeleteStaff.Location = new System.Drawing.Point(245, 24);
            this.sureToDeleteStaff.Name = "sureToDeleteStaff";
            this.sureToDeleteStaff.Size = new System.Drawing.Size(102, 37);
            this.sureToDeleteStaff.TabIndex = 1;
            this.sureToDeleteStaff.Text = "确定";
            this.sureToDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.age);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.nameStaffAdd);
            this.groupBox8.Controls.Add(this.ageStaffAdd);
            this.groupBox8.Controls.Add(this.sexStaffAdd);
            this.groupBox8.Controls.Add(this.phoneNumberStaff);
            this.groupBox8.Controls.Add(this.addStaffType);
            this.groupBox8.Controls.Add(this.addStaffNumber);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.sureToAddStaff);
            this.groupBox8.Location = new System.Drawing.Point(402, 24);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(658, 164);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "添加员工";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(445, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "电话";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(445, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "性别";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(253, 87);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(37, 15);
            this.age.TabIndex = 10;
            this.age.Text = "年龄";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(261, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "姓名";
            // 
            // nameStaffAdd
            // 
            this.nameStaffAdd.Location = new System.Drawing.Point(322, 33);
            this.nameStaffAdd.Name = "nameStaffAdd";
            this.nameStaffAdd.Size = new System.Drawing.Size(100, 25);
            this.nameStaffAdd.TabIndex = 8;
            // 
            // ageStaffAdd
            // 
            this.ageStaffAdd.Location = new System.Drawing.Point(322, 77);
            this.ageStaffAdd.Name = "ageStaffAdd";
            this.ageStaffAdd.Size = new System.Drawing.Size(100, 25);
            this.ageStaffAdd.TabIndex = 7;
            // 
            // sexStaffAdd
            // 
            this.sexStaffAdd.Location = new System.Drawing.Point(523, 36);
            this.sexStaffAdd.Name = "sexStaffAdd";
            this.sexStaffAdd.Size = new System.Drawing.Size(100, 25);
            this.sexStaffAdd.TabIndex = 6;
            // 
            // phoneNumberStaff
            // 
            this.phoneNumberStaff.Location = new System.Drawing.Point(523, 77);
            this.phoneNumberStaff.Name = "phoneNumberStaff";
            this.phoneNumberStaff.Size = new System.Drawing.Size(100, 25);
            this.phoneNumberStaff.TabIndex = 5;
            // 
            // addStaffType
            // 
            this.addStaffType.Location = new System.Drawing.Point(103, 74);
            this.addStaffType.Name = "addStaffType";
            this.addStaffType.Size = new System.Drawing.Size(117, 25);
            this.addStaffType.TabIndex = 4;
            // 
            // addStaffNumber
            // 
            this.addStaffNumber.Location = new System.Drawing.Point(103, 33);
            this.addStaffNumber.Name = "addStaffNumber";
            this.addStaffNumber.Size = new System.Drawing.Size(117, 25);
            this.addStaffNumber.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "员工种类";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "员工号";
            // 
            // sureToAddStaff
            // 
            this.sureToAddStaff.Location = new System.Drawing.Point(523, 114);
            this.sureToAddStaff.Name = "sureToAddStaff";
            this.sureToAddStaff.Size = new System.Drawing.Size(100, 44);
            this.sureToAddStaff.TabIndex = 0;
            this.sureToAddStaff.Text = "添加";
            this.sureToAddStaff.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.searchStaffNumber);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.sureToSearchStaff);
            this.groupBox7.Location = new System.Drawing.Point(31, 24);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(353, 71);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "员工搜索";
            // 
            // searchStaffNumber
            // 
            this.searchStaffNumber.Location = new System.Drawing.Point(86, 30);
            this.searchStaffNumber.Name = "searchStaffNumber";
            this.searchStaffNumber.Size = new System.Drawing.Size(140, 25);
            this.searchStaffNumber.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "员工号";
            // 
            // sureToSearchStaff
            // 
            this.sureToSearchStaff.Location = new System.Drawing.Point(245, 24);
            this.sureToSearchStaff.Name = "sureToSearchStaff";
            this.sureToSearchStaff.Size = new System.Drawing.Size(102, 37);
            this.sureToSearchStaff.TabIndex = 2;
            this.sureToSearchStaff.Text = "确定";
            this.sureToSearchStaff.UseVisualStyleBackColor = true;
            // 
            // showStaff
            // 
            this.showStaff.AllowUserToAddRows = false;
            this.showStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showStaff.Location = new System.Drawing.Point(31, 194);
            this.showStaff.Name = "showStaff";
            this.showStaff.RowHeadersWidth = 51;
            this.showStaff.RowTemplate.Height = 27;
            this.showStaff.Size = new System.Drawing.Size(1029, 367);
            this.showStaff.TabIndex = 0;
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.showBillMD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchBillTime);
            this.groupBox1.Controls.Add(this.billEndTimeMD);
            this.groupBox1.Controls.Add(this.billBeginTimeMD);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 586);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "时间段选择账单";
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
            this.showBillMD.Location = new System.Drawing.Point(6, 168);
            this.showBillMD.Name = "showBillMD";
            this.showBillMD.RowHeadersWidth = 51;
            this.showBillMD.RowTemplate.Height = 27;
            this.showBillMD.Size = new System.Drawing.Size(1069, 412);
            this.showBillMD.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "—";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchBillTime
            // 
            this.searchBillTime.Location = new System.Drawing.Point(875, 109);
            this.searchBillTime.Name = "searchBillTime";
            this.searchBillTime.Size = new System.Drawing.Size(147, 41);
            this.searchBillTime.TabIndex = 2;
            this.searchBillTime.Text = "查询";
            this.searchBillTime.UseVisualStyleBackColor = true;
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
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
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
        private System.Windows.Forms.ComboBox searchRoomType;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.TextBox deleteStaffNumber;
        private System.Windows.Forms.TextBox addStaffType;
        private System.Windows.Forms.TextBox addStaffNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameStaffAdd;
        private System.Windows.Forms.TextBox ageStaffAdd;
        private System.Windows.Forms.TextBox sexStaffAdd;
        private System.Windows.Forms.TextBox phoneNumberStaff;
    }
}