using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secundomer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int min, sec, ms;
        private void StartStop_Click(object sender, EventArgs e)
        {
            StartStop.Text = "Пуск";
            timer1.Enabled = true;
            StartStop.Enabled = false;
            Resert.Enabled = true;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //labelTime.Text = 
        }
    }
}
