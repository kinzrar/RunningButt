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
        }
        Random random = new Random();
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(random.Next(0, this.Width - button1.Width), random.Next(0, this.Height - button1.Height));
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Location = new Point(random.Next(0, this.Width - button1.Width), random.Next(0, this.Height - button1.Height));

        }
    }
}
