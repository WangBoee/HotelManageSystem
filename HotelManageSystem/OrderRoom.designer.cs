namespace QWQ
{
    partial class OrderRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderRoom));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerPhone = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomType = new System.Windows.Forms.Label();
            this.roomId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newPredeterminationName = new System.Windows.Forms.TextBox();
            this.newPhoneNumber = new System.Windows.Forms.TextBox();
            this.newIDNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.checkOutTime = new System.Windows.Forms.DateTimePicker();
            this.checkInTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isVIP = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerPhone);
            this.groupBox1.Controls.Add(this.customerName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.roomType);
            this.groupBox1.Controls.Add(this.roomId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预定房间";
            // 
            // customerPhone
            // 
            this.customerPhone.AutoSize = true;
            this.customerPhone.Location = new System.Drawing.Point(622, 110);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(63, 15);
            this.customerPhone.TabIndex = 8;
            this.customerPhone.Text = "label12";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(622, 48);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(63, 15);
            this.customerName.TabIndex = 7;
            this.customerName.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "预留手机号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "预留姓名";
            // 
            // roomType
            // 
            this.roomType.AutoSize = true;
            this.roomType.Location = new System.Drawing.Point(143, 110);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(55, 15);
            this.roomType.TabIndex = 4;
            this.roomType.Text = "label6";
            // 
            // roomId
            // 
            this.roomId.AutoSize = true;
            this.roomId.Location = new System.Drawing.Point(143, 47);
            this.roomId.Name = "roomId";
            this.roomId.Size = new System.Drawing.Size(55, 15);
            this.roomId.TabIndex = 3;
            this.roomId.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "房型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "房号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.isVIP);
            this.groupBox2.Controls.Add(this.newPredeterminationName);
            this.groupBox2.Controls.Add(this.newPhoneNumber);
            this.groupBox2.Controls.Add(this.newIDNumber);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnOrder);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.checkOutTime);
            this.groupBox2.Controls.Add(this.checkInTime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新房间";
            // 
            // newPredeterminationName
            // 
            this.newPredeterminationName.Location = new System.Drawing.Point(167, 55);
            this.newPredeterminationName.Name = "newPredeterminationName";
            this.newPredeterminationName.Size = new System.Drawing.Size(263, 25);
            this.newPredeterminationName.TabIndex = 17;
            // 
            // newPhoneNumber
            // 
            this.newPhoneNumber.Location = new System.Drawing.Point(167, 109);
            this.newPhoneNumber.Name = "newPhoneNumber";
            this.newPhoneNumber.Size = new System.Drawing.Size(263, 25);
            this.newPhoneNumber.TabIndex = 16;
            // 
            // newIDNumber
            // 
            this.newIDNumber.Location = new System.Drawing.Point(167, 164);
            this.newIDNumber.Name = "newIDNumber";
            this.newIDNumber.Size = new System.Drawing.Size(263, 25);
            this.newIDNumber.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "身份证";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "手机号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "姓名";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(584, 234);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(122, 33);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "确定";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(738, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 33);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "返回";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "离店时间";
            // 
            // checkOutTime
            // 
            this.checkOutTime.Location = new System.Drawing.Point(597, 164);
            this.checkOutTime.Name = "checkOutTime";
            this.checkOutTime.Size = new System.Drawing.Size(200, 25);
            this.checkOutTime.TabIndex = 7;
            // 
            // checkInTime
            // 
            this.checkInTime.Location = new System.Drawing.Point(597, 81);
            this.checkInTime.Name = "checkInTime";
            this.checkInTime.Size = new System.Drawing.Size(200, 25);
            this.checkInTime.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "入住时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 0;
            // 
            // isVIP
            // 
            this.isVIP.AutoSize = true;
            this.isVIP.Location = new System.Drawing.Point(167, 234);
            this.isVIP.Name = "isVIP";
            this.isVIP.Size = new System.Drawing.Size(83, 19);
            this.isVIP.TabIndex = 18;
            this.isVIP.Text = "是否VIP";
            this.isVIP.UseVisualStyleBackColor = true;
            // 
            // OrderRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderRoom";
            this.Text = "订房";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roomType;
        private System.Windows.Forms.Label roomId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker checkOutTime;
        private System.Windows.Forms.DateTimePicker checkInTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label customerPhone;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPredeterminationName;
        private System.Windows.Forms.TextBox newPhoneNumber;
        private System.Windows.Forms.TextBox newIDNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.CheckBox isVIP;
    }
}