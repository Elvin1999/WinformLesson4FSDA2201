using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        private string username;

        public string Username
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }

        private string name;

        public string Name
        {
            get { return  textBox1.Text; }
            set { textBox1.Text = value; }
        }


        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
