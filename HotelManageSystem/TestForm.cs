using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HotelManageSystem
{
    //---不用管前缀testForm文件的任何更改---//
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void query(string sqlCmd0 = "")
        {
            string sqlCmd = @"select * from testTable";
            string sqlStr = @"Data Source=BOI\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Pooling=False";
            if (sqlCmd0 != "")
                sqlCmd += sqlCmd0;

            SqlConnection sqlConnection = new SqlConnection(sqlStr);
            sqlConnection.Open();

            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd, sqlConnection);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            this.DataView.DataSource = dataSet.Tables[0];
            //string test = dataSet.Tables[0].Rows[0].ItemArray.Length.ToString();
            //MessageBox.Show(test,this.DatePick.Text);
            //sda = new SqlDataAdapter(sqlCmd, sqlConnection);
            //sda.Fill(dataSet);
            //this.DataView.DataSource = dataSet.Tables[0];

            sqlConnection.Close();

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            query();
        }

        private void Query_Click(object sender, EventArgs e)
        {
            //string datePick = $" where testDate='{ this.DatePick.Value.ToString("yyyy/MM/dd")}'"; //测试，单日查询
            //测试，日期区间查询
            string datePick = $" where testDateS between '{ this.DatePickStart.Value.ToString("yyyy/MM/dd")}' and '{ this.DatePickEnd.Value.ToString("yyyy/MM/dd")}'";
            query(datePick);
            //query();
        }

        private void updateData_Click(object sender, EventArgs e)
        {
            int num = 6;
            string sqlCmd = $@"update testTable set testBool=0 where testNum={num}";    //测试，带参查询

            string sqlStr = @"Data Source=BOI\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Pooling=False";

            SqlConnection sqlConnection = new SqlConnection(sqlStr);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(sqlCmd);
            sqlCommand.Connection = sqlConnection;
            int i = sqlCommand.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("ok");
                sqlCommand.CommandText = "update testTable set testBool=1 where testNum=10";    //test, query multi sql commands
                i = sqlCommand.ExecuteNonQuery();   //exe with the num of changed line(s)
                sqlCommand.Connection = sqlConnection;
                MessageBox.Show(i.ToString(), "info");
            }
            sqlConnection.Close();
        }
    }
}
