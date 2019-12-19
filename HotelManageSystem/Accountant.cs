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

        private void btSearch_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=BOI\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Pooling=False";
            try
            {
                SqlConnection acctConn = new SqlConnection(connString); //实例化数据库连接对象
                acctConn.Open();    //连接

                //SqlCommand sqlCommand = acctConn.CreateCommand();
                //sqlCommand.CommandType = CommandType.Text;
                //sqlCommand.CommandText = "select * from Staff";

                SqlDataAdapter sda = new SqlDataAdapter("select * from Staff", acctConn);
                DataSet dataSet = new DataSet(); 
                sda.Fill(dataSet);
                this.dgvBillData.DataSource = dataSet.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void Accountant_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
