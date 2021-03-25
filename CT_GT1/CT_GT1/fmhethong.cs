using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class fmhethong : Form
    {
        public fmhethong()
        {
            InitializeComponent();
        }

        private void nhậpHầngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fmdangnhap f = new fmdangnhap();
            f.Show();
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmhang f = new fmhang();
            f.ShowDialog();
        }

        private void khoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmthongkensx f = new fmthongkensx();
            f.ShowDialog();
        }

        private void nhaCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmthongkencc f = new fmthongkencc();
            f.ShowDialog();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmthongkeNhap f = new fmthongkeNhap();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_phieunhap f = new fm_phieunhap();
            f.ShowDialog();
        }

        private void cTPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmnhaphang f = new fmnhaphang();
            f.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmncc f = new fmncc();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_hoadon f = new fm_hoadon();
            f.ShowDialog();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_CThoadon f = new fm_CThoadon();
            f.ShowDialog();
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmthongkensx f = new fmthongkensx();
            f.ShowDialog();
        }

        private void giảiTríToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();

        public void getdatacot()
        {
            SeriesCollection series = new SeriesCollection();
            string tv = "select tenLH,count(maHG) as soluong from hang,loaiHG where hang.maLH = loaiHG.maLH group by loaiHG.tenLH ";
            //DataSet ds = new DataSet();
            //string tv = "select * from hang";
            DataTable dt = db.laydata(tv);
            //ds = db.getdata(tv, "n");
            foreach (DataRow row in dt.Rows)
            {
                series.Add(new PieSeries() { Title = row[0].ToString(), Values = new ChartValues<int> { int.Parse(row[1].ToString()) }, DataLabels = true, });
                pc1.Series = series;
            }
        }
      

        private void fmhethong_Load(object sender, EventArgs e)
        {
            //getcot();
            getdatacot();
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
        private void fmhethong_Load_1(object sender, EventArgs e)
        {
            getdatacot();
            getcot();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_kho f = new fm_kho();
            f.ShowDialog();
        }
    }
}
