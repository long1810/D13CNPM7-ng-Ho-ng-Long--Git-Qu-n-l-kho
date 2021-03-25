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
    public partial class fm_kho : Form
    {
        public fm_kho()
        {
            InitializeComponent();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();
        public void chonk(object sender, EventArgs e)
        {
            string mak = ((sender as Button).Tag.ToString());

            txtmak.Text = mak;
            string tv = "select *from inventory where mak ='"+mak+"'";
            //string tv = "select * from hoadon";
            DataSet ds = new DataSet();
            ds = db.getdata(tv, "n");
            dgvkho.DataSource = ds.Tables["n"];


            string tv1 = "select mak,sum(soluong)as sl from inventory group by (mak) having mak ='" + mak + "'";
            DataTable dt = db.laydata(tv1);
            int sl;
            //int sl = int.Parse(dt.Rows[0].ToString());
            foreach (DataRow r in dt.Rows)
            {
                sl = int.Parse(r[1].ToString());
                nubsl.Value = sl;
            }
            

            




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
        private void fm_kho_Load(object sender, EventArgs e)
        {
            getkho();

        }
    }
}
