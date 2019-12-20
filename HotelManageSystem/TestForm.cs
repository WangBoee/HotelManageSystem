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
            string datePick = $" where testDate='{ this.DatePick.Value.ToString("yyyy/MM/dd")}'";
            query(datePick);
        }
    }
}
