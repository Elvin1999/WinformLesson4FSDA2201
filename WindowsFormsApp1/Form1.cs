using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Increment = 0.25M;

            toolTip1.SetToolTip(pictureBox1, "Winform Picture Box");

            List<string> students = new List<string>
            {
                "Elvin",
                "Tural",
                "Ismayil"
            };
            int x = 0;
            int y = 0;
            foreach (var item in students)
            {
                UserControl1 userControl1 = new UserControl1();
                userControl1.Username = item;
                userControl1.Name = item;
                userControl1.Location = new Point(x, y);
                this.Controls.Add(userControl1);
                y += 50;
            }



        }
        Timer timer = new Timer();
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = progressBar1.Value.ToString();
            progressBar1.PerformStep();
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer.Stop();
                MessageBox.Show("Finish");
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }
        int scroll2 = 0;
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (scroll2 >= vScrollBar1.Value)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 8);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 8);
            }
            scroll2 = vScrollBar1.Value;
        }
        int scroll = 0;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (scroll >= hScrollBar1.Value)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 9, pictureBox1.Location.Y);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 9, pictureBox1.Location.Y);
            }
            scroll = hScrollBar1.Value;
        }
    }
}
