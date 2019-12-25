using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QWQ
{
    public partial class MD : Form
    {
        public MD()
        {
            InitializeComponent();
        }

        string connString = HotelManageSystem.Properties.Settings.Default.ConnectionString;

        string sqlRoomString = @"select room_id, name, price, is_full from Room,Room_type 
                                              where Room_type.room_type_id=Room.type_id ";

        string sqlStaffString = @"select * from Staff";

        string sqlOrdersString = @"select order_id,book_time,room_id,customer_id,in_time,out_time,(price+other_money) as prices from Orders";

        private void MD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void queryAll(string queryString = " ", int type = 0)
        {
            if (queryString == " ")
                queryString = sqlRoomString; //若调用时未给参数，则以默认方式查询
            SqlConnection queryConn = new SqlConnection(connString);    //创建并实例化数据库连接对象,此对象用于查询数据
            try
            {
                queryConn.Open();   //开启连接
                SqlDataAdapter sda = new SqlDataAdapter(queryString, queryConn);    //执行查询语句
                DataSet dataSet = new DataSet();    //创建并实例化数据集对象(本地微型数据库), 用于存储查询返回的数据
                sda.Fill(dataSet);  //查询结果填充到dataSet中
                //根据参数确定更新的数据
                switch (type)
                {
                    case 0:
                        this.showRoomInformation.DataSource = dataSet.Tables[0];    //列出返回的数据
                        break;
                    case 1:
                        this.showStaff.DataSource = dataSet.Tables[0];
                        break;
                    case 2:
                        this.showBillMD.DataSource = dataSet.Tables[0];
                        break;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                queryConn.Close();  //关闭连接
            }
        }

        private void MD_Load(object sender, EventArgs e)
        {
            this.addStaffSex.SelectedIndex = 0;
            this.addStaffPos.SelectedIndex = 0;
            queryAll();
            queryAll(sqlStaffString, 1);
            queryAll(sqlOrdersString, 2);
            /*
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlString, conn);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            this.showRoomInformation.DataSource = dataSet.Tables[0];
            conn.Close();
            */
        }

        private void sureToDelete_Click(object sender, EventArgs e)
        {
            int roomId = Int32.Parse(this.deleteRoomNumber.Text.Trim());
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = $@"delete from Room where room_id={roomId}";
            try
            {
                conn.Open();
                SqlCommand sqlDeleteRoom = new SqlCommand(sqlString);
                sqlDeleteRoom.Connection = conn;
                if (sqlDeleteRoom.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("房间 " + this.deleteRoomNumber.Text.Trim() + "删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    queryAll();
                    //MD_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("房间 " + this.deleteRoomNumber.Text.Trim() + "删除失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "info");
            }
            finally
            {
                conn.Close();
            }
        }

        private void sureToAdd_Click(object sender, EventArgs e)
        {
            int roomType = this.addRoomType.SelectedIndex;
            //MessageBox.Show(roomType.ToString());   //test
            int roomId = Int32.Parse(this.addRoomNumber.Text.Trim());
            if (this.addRoomType.Text == "")
            {
                MessageBox.Show("请选择房间类型!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sqlString = $@"insert Room values('{roomId}',{roomType},0)";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand insertCmd = new SqlCommand(sqlString);
                insertCmd.Connection = conn;
                if (insertCmd.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("房间 " + roomId.ToString() + " 添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MD_Load(sender, e);
                }
            }
        }

        private void sureToSearch_Click(object sender, EventArgs e)
        {
            int roomId = Int32.Parse(this.searchRoomNumber.Text.Trim());
            string queryString = sqlRoomString + $"and room_id={roomId}";
            queryAll(queryString);
            /*
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(queryString, conn);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);
                this.showRoomInformation.DataSource = dataSet.Tables[0];
            }
            catch (Exception)
            {
                throw;
            }
            */
        }

        private void queryRoom_Click(object sender, EventArgs e)
        {
            queryAll();
        }

        //private void groupBox3_Enter(object sender, EventArgs e)
        //{
        //    //int staffId = Int32.Parse(this.searchStaffNumber.Text.Trim());
        //    //this.addStaffSex.SelectedIndex = 0;
        //    //this.addStaffPos.SelectedIndex = 0;
        //    //string queryStaff = sqlStaffString;
        //    //queryAll(queryStaff, 1);
        //}

        private void showAllStaff_Click(object sender, EventArgs e)
        {
            queryAll(sqlStaffString, 1);
        }

        private void sureToSearchStaff_Click(object sender, EventArgs e)
        {
            int staffId = Int32.Parse(this.searchStaffNumber.Text.Trim());
            string queryStaff = sqlStaffString + $" where staff_id = {staffId}";
            queryAll(queryStaff, 1);
        }

        private void sureToDeleteStaff_Click(object sender, EventArgs e)
        {
            int staffId = Int32.Parse(this.searchStaffNumber.Text.Trim());
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = $@"delete from Staff where staff_id={staffId}";
            try
            {
                conn.Open();
                SqlCommand sqlDeleteRoom = new SqlCommand(sqlString);
                sqlDeleteRoom.Connection = conn;
                if (sqlDeleteRoom.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("员工 " + this.searchStaffNumber.Text.Trim() + "删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    queryAll(sqlStaffString, 1);
                }
                else
                {
                    MessageBox.Show("员工 " + this.deleteRoomNumber.Text.Trim() + "删除失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "info");
            }
            finally
            {
                conn.Close();
            }
        }

        private void sureToAddStaff_Click(object sender, EventArgs e)
        {
            int staffId = Int32.Parse(this.addStaffNumber.Text.Trim());
            int staffSex = this.addStaffSex.SelectedIndex;
            int staffAge = Int32.Parse(this.addStaffAge.Text.Trim());
            string staffName = this.addStaffName.Text.Trim();
            string staffPos = this.addStaffPos.Text;
            string staffPhone = this.addStaffPhone.Text.Trim();

            if (this.addStaffNumber.Text == "" || this.addStaffAge.Text == "" || this.addStaffName.Text == "" || this.addStaffPhone.Text == "")
            {
                MessageBox.Show("请输入完整数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sqlString = $@"insert Staff values({staffId},'{staffName}',{staffSex},'{staffPos}',{staffAge},'{staffPhone}')";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand insertCmd = new SqlCommand(sqlString);
                insertCmd.Connection = conn;
                if (insertCmd.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("员工添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    queryAll(sqlStaffString, 1);
                }
            }
        }

        private void busearchBillAll_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(connString);
            //conn.Open();
            //SqlDataAdapter sda = new SqlDataAdapter(sqlOrdersString, conn);
            //DataTable table = new DataTable();
            //sda.Fill(table);
            //this.showBillMD.DataSource = table;
            queryAll(sqlOrdersString, 2);
        }

        private void searchBillTime_Click(object sender, EventArgs e)
        {

        }

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{
        //    queryAll(sqlOrdersString, 2);
        //}
    }
}
