using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButonSurukle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool hareket;
        Point fareilk;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = true;
            fareilk = e.Location;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket)
            {
                button1.Location = new Point(button1.Left + e.X - fareilk.X, button1.Top + e.Y - fareilk.Y);
            }
            
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }
    }
}
