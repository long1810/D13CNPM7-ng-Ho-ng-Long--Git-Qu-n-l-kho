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
    public partial class fm_hoadon : Form
    {
        public fm_hoadon()
        {
            InitializeComponent();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();
        public void getdata()
        {
            string tv = "select * from hoadon";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            dgvhd.DataSource = ds.Tables["n"];

        }
        void getkh()
        {
            string tv = "select * from kh";
            DataSet ds = db.getdata(tv, "kh");
            cmbkh.DataSource = ds.Tables["kh"];
            cmbkh.DisplayMember = "tenkh";
            cmbkh.ValueMember = "maKH";

        }
        public void getcot()
        {
            string tv = "select * from hoadon";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            chart1.DataSource = ds.Tables["n"];
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã Hóa đơn";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tiền :";
            chart1.Series["Tiền nhập"].XValueMember = "maHD";
            chart1.Series["Tiền nhập"].YValueMembers = "thanhtoan";

            //dgvPN.DataSource = ds.Tables["n"];

        }
        private void fm_hoadon_Load(object sender, EventArgs e)
        {
            getdata();
            getkh();
            getcot();
            nudthanhtien.Enabled = false;
            btnXoa.Enabled = false;
            //button3.Enabled = false;
        }

        private void dgvhd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if (vt >= 0)
            {
                txtma.Text = dgvhd.Rows[vt].Cells["maHD"].Value.ToString();
                nudthanhtien.Value = int.Parse(dgvhd.Rows[vt].Cells["thanhtoan"].Value.ToString());
                dtpngaynhap.Text = dgvhd.Rows[vt].Cells["ngayban"].Value.ToString();
                cmbkh.SelectedValue = dgvhd.Rows[vt].Cells["maKH"].Value.ToString();

            }
            btnXoa.Enabled = true;
            //button3.Enabled = true;
            nudthanhtien.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void cleartxt()
        {
            nudthanhtien.Value = 0;
            txtma.Text = "";
            cmbkh.SelectedValue = "";

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
          
        
            string t = txtma.Text.ToString();
            string ncc = cmbkh.SelectedValue.ToString();
            string date = dtpngaynhap.Value.ToString("MM/dd/yyyy");
            string tv = "insert into hoadon(maHD,ngayban,maKH) values ('"+t+"','"+date+"','"+ncc+"')";
            db.executeNonQuery(tv);
            getdata();
            cleartxt();
            //getcot();
        
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cleartxt();
            btnXoa.Enabled = false;
            nudthanhtien.Enabled = false;

            //button3.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tv = "delete from hoadon where maHD ='" + txtma.Text.ToString() + "'";
            db.executeNonQuery(tv);
            getdata();
            btnXoa.Enabled = false;
            nudthanhtien.Enabled = true;

            //button3.Enabled = false;
        }

        private void bnttim_Click(object sender, EventArgs e)
        {
            string tim = txttim.Text.ToString();
            string tv = "select * from hoadon where mahD ='" + tim + "'";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            dgvhd.DataSource = ds.Tables["n"];
        }
    }
}
