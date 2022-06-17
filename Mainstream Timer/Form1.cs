using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mainstream_Timer
{
    public partial class Form1 : Form
    {
        int second = 0, minute = 0;
        bool start = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(start == false)
            {
                tmrTimer.Enabled = true;
            }
            else
            {
                tmrTimer.Enabled = false;
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            second++;
            
            if(second == 60)
            {
                second = 0;
                minute++;
            }

            lblTimer.Text = minute.ToString() + " : " + second.ToString();
        }
    }
}
