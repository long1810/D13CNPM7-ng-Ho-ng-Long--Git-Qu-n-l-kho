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
    public partial class testing : Form
    {
        public testing()
        {
            InitializeComponent();
        }
        public float product(float x, float y)
        {
            float p = 0;
            p = x * y;
            if (p == 42) p = 0;
            return p;
        }

        public void ko_test()
        {
            float x = float.Parse(txt_x.Text);
            float y = float.Parse(txt_y.Text);
            float kq = product(x, y);
            labkq.Text = kq.ToString();
        }
        public void co_test()
        {
            try
            {
                float x = float.Parse(txt_x.Text);
                float y = float.Parse(txt_y.Text);
                float kq = product(x, y);
                labkq.Text = kq.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"loi");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            co_test();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void testing_Load(object sender, EventArgs e)
        {

        }
    }
}
