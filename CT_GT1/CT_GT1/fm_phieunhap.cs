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
    public partial class fm_phieunhap : Form
    {
        public fm_phieunhap()
        {
            InitializeComponent();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();
        public void getdata()
        {
            string tv = "select * from phieunhap";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            dgvPN.DataSource = ds.Tables["n"];

        }
        public void getcot()
        {
            string tv = "select * from phieunhap";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            chart1.DataSource = ds.Tables["n"];
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã phiếu nhập";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tiền :";
            chart1.Series["Tiền nhập"].XValueMember = "maPN";
            chart1.Series["Tiền nhập"].YValueMembers = "tienNhap";

            //dgvPN.DataSource = ds.Tables["n"];

        }
        void getncc()
        {
            string tv = "select * from NCC";
            DataSet ds = db.getdata(tv, "ncc");
            cmbncc.DataSource = ds.Tables["ncc"];
            cmbncc.DisplayMember = "tenNCC";
            cmbncc.ValueMember = "maNCC";

        }
        public string layngay()
        {

            DateTime date = dtpngaynhap.Value;
            string t = date.ToString("MM/dd/yyyy");
            return t;
        }
        private void fm_phieunhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ct2DataSet.phieunhap' table. You can move, or remove it, as needed.
            this.phieunhapTableAdapter.Fill(this.ct2DataSet.phieunhap);
            //this.chart1.Series["long"].Points.AddXY("long", 100);
            //this.chart1.Series["long"].Points.AddXY("ly", 100);
            getcot();
            getdata();
            getncc();


        }

        public void cleartxt()
        {
            nudthanhtien.Value = 0;
            txtma.Text = "";
            cmbncc.SelectedValue = "";

          
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cleartxt();
        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if (vt >= 0)
            {
                txtma.Text = dgvPN.Rows[vt].Cells["maPN"].Value.ToString();
                nudthanhtien.Value = int.Parse(dgvPN.Rows[vt].Cells["tienNhap"].Value.ToString());    
                dtpngaynhap.Text = dgvPN.Rows[vt].Cells["ngaynhap"].Value.ToString();
                cmbncc.SelectedValue = dgvPN.Rows[vt].Cells["maNCC"].Value.ToString();

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string t = txtma.Text.ToString();
            string ncc = cmbncc.SelectedValue.ToString();
            string date = dtpngaynhap.Value.ToString("MM/dd/yyyy");
            string tv = "insert into phieunhap(maPN,ngaynhap,maNCC) values ('"+t+"','"+date+"','"+ncc+"')";
            db.executeNonQuery(tv);
            getdata();
            cleartxt();
            getcot();
        }

        private void btn_cậpnhật_Click(object sender, EventArgs e)
        {
            string tv = "update phieunhap set tiennhap = (select sum(thanhtien) from phieunhap,ChiTietPN where phieunhap.maPN = CHiTietPN.maPN)";
            db.executeNonQuery(tv);
            getdata();
        
        }

        private void bnttim_Click(object sender, EventArgs e)
        {
            string tim = txttim.Text.ToString();
            string tv = "select * from phieunhap where maPN ='"+tim+"'";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            dgvPN.DataSource = ds.Tables["n"];

        }

        private void Nha_Enter(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tv = "delete from phieunhap where maPN ='"+txtma.Text.ToString()+"'";
            db.executeNonQuery(tv);
            getdata();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string t = txtma.Text.ToString();
            string ncc = cmbncc.SelectedValue.ToString();
            string date = dtpngaynhap.Value.ToString("MM/dd/yyyy");
            string tv = "insert into phieunhap(maPN,ngaynhap,maNCC) values ('" + t + "','" + date + "','" + ncc + "')";
            db.executeNonQuery(tv);
            getdata();
            cleartxt();
            getcot();
        }
    }
}
