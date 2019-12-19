using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (this.userText.Text.Trim() == "" || this.psdText.Text.Trim() == "")
            {
                MessageBox.Show("用户名和密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.userText.Text.Trim() == "root" && this.psdText.Text.Trim() == "root")
            {
                MD md = new MD();
                md.Show();
                this.Visible = false;
            }
            else if (this.userText.Text.Trim() == "cxk" && this.psdText.Text.Trim() == "jntm")
            {
                Search search = new Search();
                search.Show();
                this.Visible = false;
            }
            else if (this.userText.Text.Trim() == "user" && this.psdText.Text.Trim() == "psd")
            {
                Accountant accountant = new Accountant();
                accountant.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void verInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("更新了滑稽图标", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
