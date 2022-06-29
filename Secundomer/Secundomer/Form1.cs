using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secundomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Timelabel.Text = "00:00.0";
            timer2.Interval = 1;
        }
        public int min, sec, ms;
        private void StartStop(object sender, EventArgs e)
        {
            if(timer2.Enabled)
            {
                min = 0;
                sec = 0;
                ms = 0;
                timer2.Enabled = false;
                SSbutton.Text = "СТОП";
                Resbutton.Enabled = true;
            }
            else
            {
                timer2.Enabled = true;
                SSbutton.Text = "СТАРТ";
                Resbutton.Enabled = true;
            }
        }

        
        private void SSbutton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
        private void Resert(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            min = 0;
            sec = 0;
            ms = 0;
            Timelabel.Text = min+":"+sec+"."+ms;
            timer2.Enabled=false;
        }
        private void Timelabel_Click(object sender, EventArgs e)
        {
            ms += 1;
            if (ms == 10)
            {
                ms = 0;
                sec += 1;
            }
            if (sec == 60)
            {
                sec = 0;
                min += 1;
            }
            if (min == 60)
                min = 0;
            Timelabel.Text = min + ":" + sec + "." + ms;
        }
 

    }
}
