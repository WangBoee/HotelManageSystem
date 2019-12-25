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
    //public DataRow rowDataFrom = null;
    public partial class OrderRoom : Form
    {
        public OrderRoom()
        {
            InitializeComponent();
        }
        Search sr;
        public DataGridViewRow dataViewRow;
        /// <summary>
        /// 重载构造函数
        /// 通过上一窗体传入的单行数据确定此窗体控件属性
        /// </summary>
        /// <param name="dataRow"></param>
        public OrderRoom(DataGridViewRow dataRow,Search order)
        {
            InitializeComponent();
            dataViewRow = dataRow;
            sr = order;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   //按下返回按钮退出窗体
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int roomId = Int32.Parse(this.roomId.Text); //获取房号
            int id = Int32.Parse(this.newIDNumber.Text.Trim());   //获取输入顾客身份证
            int isVIP = this.isVIP.Checked ? 1 : 0; //是否VIP
            int days = this.checkOutTime.Value.DayOfYear - this.checkInTime.Value.DayOfYear;    //获取入住时长，日期相减
            float otherMoney = Convert.ToSingle(this.otherMoney.Text.Trim());   //获取输入其他消费金额
            float roomPrice = Single.Parse(this.roomPrice.Text) * days;    //获取住房总房费
            float desposit = Single.Parse(this.deposit.Text);   //获取押金
            MessageBox.Show(roomPrice.ToString(),days.ToString());
            string name = this.newPredeterminationName.Text.Trim(); //获取输入顾客姓名
            string phone = this.newPhoneNumber.Text.Trim(); //获取输入顾客手机号
            string checkInTime = this.checkInTime.Text; //获取输入入住日期
            string checkOutTime = this.checkOutTime.Text;   //获取输入离店日期

            //MessageBox.Show(isVIP);   //test
            //数据库连接字串
            string connString = HotelManageSystem.Properties.Settings.Default.ConnectionString;
            //sql语句，向Customer表插入新增顾客信息
            string insert2Cusromers = $@"insert Customer(customer_id, name, phone, is_vip) values({id},'{name}','{phone}',{isVIP})";
            //sql语句，向Orders表插入订单信息
            string insert2Orders = $@"insert Orders(book_time, in_time, out_time, customer_id, room_id, price, deposit, other_money) values(getdate(), '{checkInTime}','{checkOutTime}',{id},{roomId},{roomPrice},{desposit},{otherMoney})";

            try
            {
                SqlConnection insertConn = new SqlConnection(connString); //创建并实例化数据库连接对象,此对象用于添加数据
                insertConn.Open();    //开启连接
                string sqlcom = insert2Cusromers + "; " + insert2Orders;    //合并SQL语句
                SqlCommand insertCmd = new SqlCommand(sqlcom);     //初始化并执行SQL语句
                insertCmd.Connection = insertConn;   //将SQL命令对象绑定到conn连接对象
                                                     //SQL语句成功返回值大于0
                if (insertCmd.ExecuteNonQuery() > 0)
                {   //添加数据成功，更新数据
                    insertConn.Close();
                    try
                    {
                        sqlcom = $@" update Room set is_full=1 where room_id={roomId};";  //sql语句，更新Room中对应房号状态(is_full)
                        SqlConnection updateConn = new SqlConnection(connString); //创建并实例化数据库连接对象,此对象用于修改数据
                        updateConn.Open();  //开启连接
                        SqlCommand updateCmd = new SqlCommand(sqlcom);  //初始化并执行SQL语句
                        updateCmd.Connection = updateConn;   //将SQL命令对象绑定到conn连接对象
                        if (updateCmd.ExecuteNonQuery() > 0)
                        {   //成功修改房间状态
                            MessageBox.Show("success", "info");  //信息窗口提示
                            OrderRoom_Load(sender, e);
                        }
                        updateConn.Close(); //断开数据库连接
                    }
                    catch (Exception ee)
                    {   //捕获异常, 弹窗提示异常信息
                        MessageBox.Show(ee.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    insertConn.Close(); //断开数据库连接
                }
            }
            catch (Exception ee)
            {   //捕获异常, 弹窗提示异常信息
                MessageBox.Show(ee.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sr.Ord_updateQue();
        }

        private void OrderRoom_Load(object sender, EventArgs e)
        {
            this.roomType.Text = dataViewRow.Cells["type_name"].Value.ToString();   //获取选中房间类型
            this.roomId.Text = dataViewRow.Cells["room_id"].Value.ToString();   //获取选中房间房号
            this.roomPrice.Text = dataViewRow.Cells["price"].Value.ToString();  //获取选中房间价格
            this.deposit.Text = dataViewRow.Cells["deposit"].Value.ToString();  //获取选中房间押金
        }
    }
}
