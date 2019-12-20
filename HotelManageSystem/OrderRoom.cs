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

        public OrderRoom(DataGridViewRow dataRow)
        {
            InitializeComponent();
            this.roomType.Text = dataRow.Cells["type_name"].Value.ToString();
            this.roomId.Text = dataRow.Cells["room_id"].Value.ToString();
            this.roomPrice.Text = dataRow.Cells["price"].Value.ToString();
            this.deposit.Text = dataRow.Cells["deposit"].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int roomId = Int32.Parse(this.roomId.Text); //获取房号
            int id = Int32.Parse(this.newIDNumber.Text.Trim());   //获取输入顾客身份证
            int isVIP = this.isVIP.Checked ? 1 : 0; //是否VIP

            float otherMoney = Convert.ToSingle(this.otherMoney.Text.Trim());   //获取输入其他消费金额
            float roomPrice = Single.Parse(this.roomPrice.Text);    //获取房间价格
            float desposit = Single.Parse(this.deposit.Text);   //获取押金

            string name = this.newPredeterminationName.Text.Trim(); //获取输入顾客姓名
            string phone = this.newPhoneNumber.Text.Trim(); //获取输入顾客手机号
            string checkInTime = this.checkInTime.Text; //获取输入入住日期
            string checkOutTime = this.checkOutTime.Text;   //获取输入离店日期

            //MessageBox.Show(isVIP);   //test
            string connString = @"Data Source=BOI\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Pooling=False";
           
            string insert2Cusromers = $@"insert Customer(customer_id, name, phone, is_vip)
                                                                values({id},'{name}','{phone}',{isVIP})";

            string insert2Orders = $@"insert Orders(book_time, in_time, out_time, customer_id, room_id, price, deposit, other_money)
                                            values(getdate(), '{checkInTime}','{checkOutTime}',{id},{roomId},{roomPrice},{desposit},{otherMoney})";
            
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sqlcom = insert2Cusromers + "; " + insert2Orders;
            SqlCommand sqlCommand = new SqlCommand(sqlcom);
            sqlCommand.Connection = conn;
            if (sqlCommand.ExecuteNonQuery() > 0)
                MessageBox.Show("insert success");
        }

        private void OrderRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
