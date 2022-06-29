using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void ChangeFontStyle(object sender, EventArgs e)
        {
            var fontstyle = FontStyle.Regular;

            if (boldCheckBox.Checked)
                fontstyle |= FontStyle.Bold;

            if (italCheckBox.Checked)
                fontstyle |= FontStyle.Underline;

            label1.Font = new Font(
                label1.Font.FontFamily,
                label1.Font.Size,
                fontstyle);

        }
    }
}
