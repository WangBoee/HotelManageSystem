using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWQ
{
    //public DataRow rowDataFrom = null;
    public partial class OrderRoom : Form
    {
        public OrderRoom()
        {
            InitializeComponent();
        }

        public void queryAll()
        {
            ;
        }

        public OrderRoom(DataGridViewRow dataRow)
        {
            InitializeComponent();
            this.roomType.Text = dataRow.Cells["type_name"].Value.ToString();
            this.roomId.Text = dataRow.Cells["room_id"].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
