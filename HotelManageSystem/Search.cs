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
using Manager;
using System.Configuration;

namespace QWQ
{
    public partial class Search : Form
    {   
        //默认构造函数
        public Search()
        {
            InitializeComponent();
        }

        //整表查询语句，查询函数参数添加条件
        private string sqlString = "select room_id, Room_type.name, price, is_full, deposit from Room, Room_type where Room_type.room_type_id=Room.type_id ";
        private string sqlConnStr= HotelManageSystem.Properties.Settings.Default.ConnectionString;
        /// <summary>
        /// 查询函数. 
        /// 带默认参数，默认查询整张表
        /// 参数为查询条件
        /// </summary>
        /// <param name="queryString"></param>
        private void queryAll(string queryString = " ")
        {
            if (queryString == " ")
                queryString = sqlString; //若调用时未给参数，则以默认方式查询
            //数据库连接字串
            string connString = sqlConnStr;
            ///
            SqlConnection queryConn = new SqlConnection(connString);    //创建并实例化数据库连接对象,此对象用于查询数据
            queryConn.Open();   //开启连接
            SqlDataAdapter sda = new SqlDataAdapter(queryString, queryConn);    //执行查询语句
            DataSet dataSet = new DataSet();    //创建并实例化数据集对象(本地微型数据库), 用于存储查询返回的数据
            sda.Fill(dataSet);  //查询结果填充到dataSet中
            //dataSet中的第一张表即为返回的数据表，作为数据表显示控件的数据源
            this.dgvRoomData.DataSource = dataSet.Tables[0];    //列出返回的数据
            queryConn.Close();  //关闭连接
            //
        }

        /// <summary>
        /// 按条件查询空房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void affirmSearchEmpty_Click(object sender, EventArgs e)
        {
            string sqlStr = sqlString;  //默认查询
            string sqlCond = this.comboBox1.Text;   //获取下拉框选中项作为查询条件的参数
            int i = this.comboBox1.SelectedIndex;
            sqlStr += "AND Room.is_full = 0 ";   //添加查询空房间条件
            //若下拉框选中"所有房间"或为空，则忽略此条件(即sqlStr=""), 否则添加查询条件
            sqlStr += (comboBox1.Text == "所有房间" || comboBox1.Text == "") ? " " : $" and Room_type.room_type_id= {i}";
            queryAll(sqlStr);   //调用条件查询函数
        }

        /// <summary>
        /// 按条件查询所有房间，包括空房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void affirmSearchAll_Click(object sender, EventArgs e)
        {
            string sqlStr = sqlString;  //默认查询
            string sqlCond = this.comboBox1.Text;   //获取下拉框选中项作为查询条件的参数
            int i = this.comboBox1.SelectedIndex;
            sqlStr += (comboBox1.Text == "所有房间" || comboBox1.Text == "") ? " " : $" and Room_type.room_type_id= {i}";
            queryAll(sqlStr);   //调用条件查询函数
        }

        //窗体加载
        private void Search_Load(object sender, EventArgs e)
        {    //设置数据表选中方式为选中整行
            dgvRoomData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inquireDate.Visible = false;
            queryAll(); //默认条件查询
        }

        /// <summary>
        /// 鼠标右键选中整行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRoomData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {   //如果按下鼠标右键
                if (e.RowIndex >= 0)
                {   //数据表中有数据
                    dgvRoomData.ClearSelection();   //清除选中
                    dgvRoomData.Rows[e.RowIndex].Selected = true;   //鼠标所在行标记为选中
                }
            }
        }

        /// <summary>
        /// 右键选中菜单；订房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 订房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.dgvRoomData.CurrentRow.Cells["is_full"].Value) == 1)
            {   //判断房间状态
                MessageBox.Show("房间已有人入住，不可预定", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {   //空房
                DataGridViewRow transDataRow = dgvRoomData.CurrentRow;  //取出当前选中行数据
                //MessageBox.Show(transDataRow.Cells[0].Value.ToString());  //test
                OrderRoom orderRoom = new OrderRoom(transDataRow);  //创建并初始化下单窗体，并将当前行数据作为参数传给窗体
                orderRoom.ShowDialog(); //显示窗体
            }
        }

        //关闭窗体，结束整个程序
        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
