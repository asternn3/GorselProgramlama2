using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int btn1X = 350, btn1Y = 140;
        int btn2X = 400, btn2Y = 140;
        int btn3X = 350, btn3Y = 190;
        int btn4X = 400, btn4Y = 190;
        Timer timer = new Timer();
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);
            btn1.SetBounds(btn1X, btn1Y, 50, 50);
            btn2.SetBounds(btn2X, btn2Y, 50, 50);
            btn3.SetBounds(btn3X, btn3Y, 50, 50);
            btn4.SetBounds(btn4X, btn4Y, 50, 50);
            timer.Tick += Timer_Tick;
            timer.Start(); 
        }
        bool control = false;
        private void Timer_Tick(object sender, EventArgs e)
        {
            btn1.SetBounds(btn1X, btn1Y, 50, 50);
            btn2.SetBounds(btn2X, btn2Y, 50, 50);
            btn3.SetBounds(btn3X, btn3Y, 50, 50);
            btn4.SetBounds(btn4X, btn4Y, 50, 50);
            if (control == false)
            {
                btn1X -= 10;
                btn1Y -= 10;
                btn2X += 10;
                btn2Y -= 10;
                btn3X -= 10;
                btn3Y += 10;
                btn4X += 10;
                btn4Y += 10;
            }
            
            if(btn1Y == -10)
            {
                control = true;
            }

            if(control == true)
            {
                btn1X += 10;
                btn1Y += 10;
                btn2X -= 10;
                btn2Y += 10;
                btn3X += 10;
                btn3Y -= 10;
                btn4X -= 10;
                btn4Y -= 10;
            }

            if (btn1Y == 140)
            {
                control = false;
            }
        }
    }
}
