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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random pes = new Random();
        public int score = 0;
        public void totalscore()
        {
            textBox1.Text = score.ToString();
        }
        public void linemove(int speed)
        {
            if (pictureBox1.Top > 485) pictureBox1.Top = 0;
            else pictureBox1.Top += speed;
            if (pictureBox2.Top > 485) pictureBox2.Top = 0;
            else pictureBox2.Top += speed;
            if (pictureBox3.Top > 485) pictureBox3.Top = 0;
            else pictureBox3.Top += speed;
            //e1
            if (enemy1.Top > 485)
            {
                score++;
                enemy1.Top = 0;
                enemy1.Left = pes.Next(0, 100);
                enemy1.Top = pes.Next(0, 40);
            }
            else enemy1.Top += speed;
            //e2
            if (enemy2.Top > 485)
            {
                enemy2.Top = 0;
                enemy2.Left = pes.Next(100, 200);
                enemy2.Top = pes.Next(0, 40);
            }
            else enemy2.Top += speed;
            //e3
            if (enemy3.Top > 485)
            {
                enemy3.Top = 0;
                enemy3.Left = pes.Next(225, 500);
                enemy3.Top = pes.Next(0, 40);
            }
            else enemy3.Top += speed;
            //e4
            if (enemy4.Top > 485)
            {
                enemy4.Top = 0;
                enemy4.Left = pes.Next(225, 300);
                enemy4.Top = pes.Next(0, 40);
            }
            else enemy4.Top += speed;




        }
        int carspeed = 3;

        private void timer1_Tick(object sender, EventArgs e)
        {
            linemove(carspeed);
            gameover();
            totalscore();
        }
        void gameover()
        {
            if (myCar.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("DO you  want play agian ?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (go)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        timer1.Enabled = true;
                        score = 0;
                        enemy1.Top = 0;
                        enemy1.Left = pes.Next(100, 200);
                        enemy2.Top = 0;
                        enemy2.Left = pes.Next(100, 200);
                        enemy3.Top = 0;
                        enemy3.Left = pes.Next(100, 200);
                        enemy4.Top = 0;
                        enemy4.Left = pes.Next(100, 200);



                        break;

                    case System.Windows.Forms.DialogResult.No:
                        this.Close();
                        break;
                }
            }
            if (myCar.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("DO you  want play agian ?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (go)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        timer1.Enabled = true;
                        score = 0;
                        enemy1.Top = 0;
                        enemy1.Left = pes.Next(100, 200);
                        enemy2.Top = 0;
                        enemy2.Left = pes.Next(100, 200);
                        enemy3.Top = 0;
                        enemy3.Left = pes.Next(100, 200);
                        enemy4.Top = 0;
                        enemy4.Left = pes.Next(100, 200);



                        break;

                    case System.Windows.Forms.DialogResult.No:
                        this.Close();
                        break;
                }
            }
            if (myCar.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("DO you  want play agian ?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (go)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        timer1.Enabled = true;
                        score = 0;
                        enemy1.Top = 0;
                        enemy1.Left = pes.Next(100, 200);
                        enemy2.Top = 0;
                        enemy2.Left = pes.Next(100, 200);
                        enemy3.Top = 0;
                        enemy3.Left = pes.Next(100, 200);
                        enemy4.Top = 0;
                        enemy4.Left = pes.Next(100, 200);



                        break;

                    case System.Windows.Forms.DialogResult.No:
                        this.Close();
                        break;
                }
            }
            if (myCar.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("DO you  want play agian ?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (go)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        timer1.Enabled = true;
                        score = 0;
                        enemy1.Top = 0;
                        enemy1.Left = pes.Next(100, 200);
                        enemy2.Top = 0;
                        enemy2.Left = pes.Next(100, 200);
                        enemy3.Top = 0;
                        enemy3.Left = pes.Next(100, 200);
                        enemy4.Top = 0;
                        enemy4.Left = pes.Next(100, 200);



                        break;

                    case System.Windows.Forms.DialogResult.No:
                        this.Close();
                        break;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && myCar.Left > 0) myCar.Left -= 10;

            if (e.KeyCode == Keys.Right && myCar.Left < 562) myCar.Left += 10;


            if (e.KeyCode == Keys.Up && carspeed > 0) carspeed += 1;
            if (e.KeyCode == Keys.Down && carspeed > 0) carspeed -= 1;

        }
    }
}
