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
    public partial class fmncc : Form
    {
        public fmncc()
        {
            InitializeComponent();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void getdata()
        {
            string tv = "select * from NCC";
            DataSet ds = db.getdata(tv, "ncc");
            đgvncc.DataSource = ds.Tables["ncc"];

        }
        public void  cleartxt()
        {
            txtdc.Text ="";
            txtma.Text = "";
            txtsdt.Text = "";
            txttennncc.Text = "";
            txtma.Enabled = true;
            btnthem.Enabled = true;
        }
        private void fmncc_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cleartxt();
        }

        private void đgvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if(vt>=0)
            {
                txtma.Text = đgvncc.Rows[vt].Cells["maNCC"].Value.ToString();
                txttennncc.Text =đgvncc.Rows[vt].Cells["tenNCC"].Value.ToString();
                txtsdt.Text = đgvncc.Rows[vt].Cells["dienthoai"].Value.ToString();
                txtdc.Text = đgvncc.Rows[vt].Cells["diachi"].Value.ToString();

            }
            txtma.Enabled = false;
            btnthem.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string ten = txttennncc.Text;
            string dt = txtsdt.Text;
            string dc = txtdc.Text;

            string tv = "insert into NCC values ('"+ma+"','"+ten+"','"+dt+" ','"+dc+"')";

            db.executeNonQuery(tv);
            getdata();
            cleartxt();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string tv = "delete from NCC where maNCC ='"+ma+"'";
            db.executeNonQuery(tv);
            cleartxt();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
