using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT_GT1
{
    public partial class fmthongkensx : Form
    {
        public fmthongkensx()
        {
            InitializeComponent();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();

        public void getdata()
        {
            string tv = "select * from NSX";
            DataSet ds = db.getdata(tv, "h");
            dgvnsx.DataSource = ds.Tables["h"];
        }

        public void getnsx()
        {
            string tv = "select * from NSX";
            DataSet ds = db.getdata(tv, "g");
            cmbmansx.DataSource = ds.Tables["g"];
            cmbmansx.DisplayMember = "tenNSX";
            cmbmansx.ValueMember = "maNSX";

        }
        private void fmnsx_Load(object sender, EventArgs e)
        {
            getdata();
            getnsx();
        }

        private void btntknsx_Click(object sender, EventArgs e)
        {
            string tv = "select * from NSX,hang where hang.maNSX = NSX.maNSX and NSX.maNSX ='"+cmbmansx.SelectedValue.ToString()+"'";
            DataSet ds = db.getdata(tv, "h");
            dgvnsx.DataSource = ds.Tables["h"];
        }
    }
}
