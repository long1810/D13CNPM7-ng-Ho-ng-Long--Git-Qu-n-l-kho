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
    public partial class fmdangnhap : Form
    {
        public fmdangnhap()
        {
            InitializeComponent();
        }
        Controller.SqlDataProvider db = new Controller.SqlDataProvider();
        private void button1_Click(object sender, EventArgs e)
        {
            string tk = txttaikhoan.Text;
            string mk = txtmatkhau.Text;
            string tv = "select COUNT(*) from tk where tk = '"+tk+"' and mk = '"+mk+"' ";
            int kt = int.Parse(db.executeScalar(tv));
            if (kt == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                fmhethong f = new fmhethong();
                f.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Đăng nhập Thất bại");

            }
        }

        private void fmdangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
