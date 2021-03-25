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
    public partial class fmthongkencc : Form
    {
        public fmthongkencc()
        {
            InitializeComponent();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();
        void getncc()
        {
            string tv = "select * from NCC";
            DataSet ds = db.getdata(tv, "ncc");
            cmbncc.DataSource = ds.Tables["ncc"];
            cmbncc.DisplayMember = "tenNCC";
            cmbncc.ValueMember = "maNCC";

        }
        public void getdata()
        { 
            string tv = "select * from hang";
            DataSet ds = db.getdata(tv, "h");
            dgvnhacc.DataSource = ds.Tables["h"];
        }

        private void fmthongkencc_Load(object sender, EventArgs e)
        {
            getdata();
            getncc();

        }

        private void btnthongkencc_Click(object sender, EventArgs e)
        {
            string tv = "exec ncchang1 "+cmbncc.SelectedValue.ToString()+"";
            DataSet ds = db.getdata(tv, "h");
            dgvnhacc.DataSource = ds.Tables["h"];
        }
    }
}
