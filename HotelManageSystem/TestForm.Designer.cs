namespace HotelManageSystem
{
    partial class TestForm
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
            this.DataView = new System.Windows.Forms.DataGridView();
            this.DatePickStart = new System.Windows.Forms.DateTimePicker();
            this.Query = new System.Windows.Forms.Button();
            this.updateData = new System.Windows.Forms.Button();
            this.DatePickEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(12, 138);
            this.DataView.MultiSelect = false;
            this.DataView.Name = "DataView";
            this.DataView.RowHeadersWidth = 51;
            this.DataView.RowTemplate.Height = 27;
            this.DataView.Size = new System.Drawing.Size(673, 302);
            this.DataView.TabIndex = 0;
            // 
            // DatePickStart
            // 
            this.DatePickStart.Location = new System.Drawing.Point(12, 29);
            this.DatePickStart.Name = "DatePickStart";
            this.DatePickStart.Size = new System.Drawing.Size(200, 25);
            this.DatePickStart.TabIndex = 1;
            // 
            // Query
            // 
            this.Query.Location = new System.Drawing.Point(513, 73);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(106, 43);
            this.Query.TabIndex = 2;
            this.Query.Text = "Query";
            this.Query.UseVisualStyleBackColor = true;
            this.Query.Click += new System.EventHandler(this.Query_Click);
            // 
            // updateData
            // 
            this.updateData.Location = new System.Drawing.Point(513, 12);
            this.updateData.Name = "updateData";
            this.updateData.Size = new System.Drawing.Size(106, 42);
            this.updateData.TabIndex = 3;
            this.updateData.Text = "update";
            this.updateData.UseVisualStyleBackColor = true;
            this.updateData.Click += new System.EventHandler(this.updateData_Click);
            // 
            // DatePickEnd
            // 
            this.DatePickEnd.Location = new System.Drawing.Point(12, 91);
            this.DatePickEnd.Name = "DatePickEnd";
            this.DatePickEnd.Size = new System.Drawing.Size(200, 25);
            this.DatePickEnd.TabIndex = 1;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 452);
            this.Controls.Add(this.updateData);
            this.Controls.Add(this.Query);
            this.Controls.Add(this.DatePickEnd);
            this.Controls.Add(this.DatePickStart);
            this.Controls.Add(this.DataView);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.DateTimePicker DatePickStart;
        private System.Windows.Forms.Button Query;
        private System.Windows.Forms.Button updateData;
        private System.Windows.Forms.DateTimePicker DatePickEnd;
    }
}