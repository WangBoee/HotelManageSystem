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
using System.Configuration;
using QWQ;
using Manager;

namespace HotelManageSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = this.userText.Text.Trim();    //获取输入用户名
            string userPsd = this.psdText.Text.Trim();  //获取输入密码

            string connString = HotelManageSystem.Properties.Settings.Default.ConnectionString; //数据库连接字符串
            string cmdString = $"select level,userN,psd from Login where userN=N'{userName}' "; //查询用户名
            if (userName == "" || userPsd == "")
            {   //输入的用户名或密码为空
                MessageBox.Show("用户名和密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = new SqlConnection(connString); //创建连接对象
                SqlCommand cmd = new SqlCommand(cmdString, conn);   //创建sql命令对象
                conn.Open();    //打开连接
                SqlDataReader reader = cmd.ExecuteReader(); //执行sql语句，读一条数据
                if (reader.Read())
                {   //reader.Read() 返回值为bool类型，由此判断是否存在此用户
                    int level = reader.GetInt32(0); //获取用户级别
                    //string name = reader.GetString(1);   //获取用户名
                    string psd = reader.GetString(2);   //获取用户名密码
                    //MessageBox.Show(level.ToString()+name + " " + psd);
                    if (psd.Trim() == userPsd)
                    {   //用户名密码匹配
                        switch (level)
                        {   //根据用户等级确定显示窗口
                            case 0:
                                MD md = new MD();
                                md.Show();  //经理账户登录
                                this.Visible = false;   //登录窗口不可见
                                break;
                            case 1:
                                Search search = new Search();
                                search.Show();  //前台账户登录
                                this.Visible = false;
                                break;
                            case 2:
                                Accountant accountant = new Accountant();
                                accountant.Show();  //会计账户登录
                                this.Visible = false;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {   //密码错误
                        MessageBox.Show("密码错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {   //用户不存在
                    MessageBox.Show("用户名不存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
        }

        private void verInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   !!更新了滑稽图标!!\n\n   Author: Boi_Wong\n   Release Ver.1.0.1.3\n\n@Boi All Rights Reserved", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {   //退出应用
            Application.Exit();
        }
    }
}
