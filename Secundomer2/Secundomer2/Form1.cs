using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secundomer2
{
    public partial class Secundomer : Form
    {
        public Secundomer()
        {
            InitializeComponent();
        }

        private void Secundomer_Load(object sender, EventArgs e)
        {
            DateTime date = new DateTime(0, 0);
            date = date.AddMilliseconds(10);
            Timer.Text = date.ToString("mm:ss.f");
        }
        private void buttonSS_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                SSbutton.Text = "Стоп";
            }
            else
            {
                timer1.Enabled = false;
                SSbutton.Text = "Пуск";
            }
        }
        private void Resert_Click(object sender, EventArgs e)
            {
                timer1.Enabled = false;
                DateTime date = new DateTime(0, 0);
                Timer.Text = date.ToString("mm:ss.f");
                SSbutton.Text = "Пуск";
            }

        }
    }

