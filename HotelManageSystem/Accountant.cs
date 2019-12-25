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

namespace Manager
{
    public partial class Accountant : Form
    {
        public Accountant()
        {
            InitializeComponent();
        }

        string connString = HotelManageSystem.Properties.Settings.Default.ConnectionString;
        string queryString = "select order_id,book_time,price,deposit,other_money from Orders";

        private void query(string queryStr = " ")
        {
                queryStr = queryString+queryStr;
            ///
            SqlConnection queryConn = new SqlConnection(connString);    //创建并实例化数据库连接对象,此对象用于查询数据
            queryConn.Open();   //开启连接
            SqlDataAdapter sda = new SqlDataAdapter(queryStr, queryConn);    //执行查询语句
            DataSet dataSet = new DataSet();    //创建并实例化数据集对象(本地微型数据库), 用于存储查询返回的数据
            sda.Fill(dataSet);  //查询结果填充到dataSet中
            //dataSet中的第一张表即为返回的数据表，作为数据表显示控件的数据源
            this.dgvBillData.DataSource = dataSet.Tables[0];    //列出返回的数据
            queryConn.Close();  //关闭连接
            ///
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string str=  $" where book_time between '{ this.dtpStartTime.Value.ToString("yyyy/MM/dd")}' and '{ this.dtpEndTime.Value.ToString("yyyy/MM/dd")}'";
            query(str);
        }

        private void Accountant_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Accountant_Load(object sender, EventArgs e)
        {
            query();
            string str = "select count(order_id) from Orders";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(str, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                this.counts.Text = reader.GetInt32(0).ToString();
            cmd.CommandText = "select sum(price+other_money) from Orders";
            reader.Close();
            reader = cmd.ExecuteReader();
            if (reader.Read())
                this.allBill.Text = reader.GetSqlDouble(0).ToString();
        }
    }
}
