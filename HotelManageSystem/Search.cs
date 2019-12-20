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

namespace QWQ
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        //整表查询语句，查询函数参数添加条件
        private string sqlString = @"select room_id, name, price, is_full, deposit from Room,Room_type 
                                              where Room_type.room_type_id=Room.type_id ";

        /// <summary>
        /// 查询函数. 
        /// 带默认参数，默认查询整张表
        /// 参数为查询条件
        /// </summary>
        /// <param name="queryString"></param>
        private void queryAll(string queryString = " ")
        {
            if (queryString == " ")
                queryString = sqlString;
            string connString = @"Data Source=BOI\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Pooling=False";

            ///
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(queryString, conn);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            this.dgvRoomData.DataSource = dataSet.Tables[0];
            conn.Close();
            ///
        }

        /// <summary>
        /// 按条件查询空房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void affirmSearchEmpty_Click(object sender, EventArgs e)
        {
            string sqlStr = sqlString;
            sqlStr += "AND Room.is_full = 0";
            sqlStr += (comboBox1.Text == "所有房间" || comboBox1.Text == "") ? "" : " AND Room_type.name ='" + comboBox1.Text + "'";
            queryAll(sqlStr);
        }

        /// <summary>
        /// 按条件查询所有房间，包括空房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void affirmSearchAll_Click(object sender, EventArgs e)
        {
            string sqlStr = sqlString;
            sqlStr += (comboBox1.Text == "所有房间" || comboBox1.Text == "") ? "" : " AND Room_type.name ='" + comboBox1.Text + "'";
            queryAll(sqlStr);
        }

        //窗体加载
        private void Search_Load(object sender, EventArgs e)
        {
            dgvRoomData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            queryAll();
        }

        /// <summary>
        /// 鼠标右键选中整行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRoomData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgvRoomData.ClearSelection();
                    dgvRoomData.Rows[e.RowIndex].Selected = true;
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
            {
                MessageBox.Show("房间已有人入住，不可预定", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow transDataRow = dgvRoomData.CurrentRow;
                //MessageBox.Show(transDataRow.Cells[0].Value.ToString());
                OrderRoom orderRoom = new OrderRoom(transDataRow);
                orderRoom.ShowDialog();
            }
        }

        //关闭窗体，结束整个程序
        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
