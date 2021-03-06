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
    public partial class fm_CThoadon : Form
    {
        public fm_CThoadon()
        {
            InitializeComponent();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();
        public void getdata()
        {
            string tv = "select * from hoadon";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            dgvpn.DataSource = ds.Tables["n"];

        }
        public void getct()
        {
            string tv = "select * from CThoadon";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            dgvctpn.DataSource = ds.Tables["n"];

        }
        public void gethang()
        {
            string tv = "select * from hang";
            DataSet ds = db.getdata(tv, "n");
            cmbhang.DataSource = ds.Tables["n"];
            cmbhang.DisplayMember = "tenHG";
            cmbhang.ValueMember = "maHG";
        }
        public void chonk(object sender, EventArgs e)
        {
            string mak = ((sender as Button).Tag.ToString());

            txtmak.Text = mak;

        }

        public void getkho()
        {
            string tv = "select mak,tenkho,thetich,thetichDD from kho";
            DataTable dt = db.laydata(tv);
            flpkho.Controls.Clear();

            foreach (DataRow r in dt.Rows)
            {
                Button btn = new Button() { Width = 80, Height = 50 };
                //int trong = (int)r[2] - (int)r[3];
                //int trong = 0;
                btn.Text = "Mã kho: " + r[0].ToString() + "  Tên:" + r[1].ToString();
                btn.Click += chonk;
                btn.Tag = r[0];

                flpkho.Controls.Add(btn);
            }

        }
        public void chonhg(object sender, EventArgs e)
        {
            string mak = ((sender as Button).Tag.ToString());

            cmbhang.SelectedValue = mak;

        }

        public void gethg()
        {
            string tv = "select maHG ,tenHG,gia  from hang";
            DataTable dt = db.laydata(tv);
            flphang.Controls.Clear();

            foreach (DataRow r in dt.Rows)
            {
                Button btn = new Button() { Width = 80, Height = 50 };
                //int trong = (int)r[2] - (int)r[3];
                //int trong = 0;
                btn.Text = "Mã hàng: " + r[0].ToString() + "  Tên:" + r[1].ToString();
                btn.Click += chonhg;
                btn.Tag = r[0];

                flphang.Controls.Add(btn);
            }

        }
        public void getlh()
        {
            string tv = "select * from loaiHG";
            DataSet ds = db.getdata(tv, "loaihang");
            cbloaihang.DataSource = ds.Tables["loaihang"];
            cbloaihang.DisplayMember = "tenLH";
            cbloaihang.ValueMember = "maLH";

        }
        public void getcot()
        {
            string tv = "select mak,tenkho,thetich,thetichDD from kho";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            chart1.DataSource = ds.Tables["n"];
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã kho:";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Thể tích:";
            chart1.Series["Thể tích"].XValueMember = "mak";
            chart1.Series["Thể tích"].YValueMembers = "thetich";
            chart1.Series["Thể tích đã dùng"].YValueMembers = "thetichDD";

            //dgvPN.DataSource = ds.Tables["n"];

        }
        void getncc()
        {
            string tv = "select * from kh";
            DataSet ds = db.getdata(tv, "ncc");
            cbncc.DataSource = ds.Tables["ncc"];
            cbncc.DisplayMember = "tenkh";
            cbncc.ValueMember = "makH";

        }

        private void fm_CThoadon_Load(object sender, EventArgs e)
        {
            getdata();
            getct();
            gethang();
            getkho();
            gethg();
            getlh();
            getcot();
            getncc();
        }

        private void dgvpn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if (vt >= 0)
            {
                txtmapn.Text = dgvpn.Rows[vt].Cells["maHD"].Value.ToString();


            }
        }

        private void btntao_Click(object sender, EventArgs e)
        {
            string mapn = txtma.Text.ToString();

            string ncc = cbncc.SelectedValue.ToString();
            string tv = "insert into hoadon(maHD,maKH) values ('" + mapn + "','" + ncc + "')";
            db.executeNonQuery(tv);
            getdata();
            getcot();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmactpn.Text = txtmapn.Text;
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            string mapn = txtmactpn.Text.ToString();
            string hang = cmbhang.SelectedValue.ToString();
            //int gia = (int)nubgia.Value;
            string mak = txtmak.Text.ToString();
            int soluong = (int)nubsoluong.Value;

            string tv = "insert into CThoadon(maHD,maHG,mak,soluong,giaban,thanhtien) values ('" + mapn + "','" + hang + "','" + mak + "'," + soluong + ",0,0)";
            db.executeNonQuery(tv);
            getct();
            getcot();
        }
    }
}
