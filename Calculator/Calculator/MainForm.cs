using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        Calculator calc;
        Dictionary<char, Func<int>> op;
        public MainForm()
        {
            InitializeComponent();

            calc = new Calculator();
            op = new Dictionary<char, Func<int>>();
            op['+'] = calc.GetSum;
            op['-'] = calc.GetDifference;
            op['*'] = calc.GetProduct;
            op['/'] = calc.GetQuotient;
            op['%'] = calc.GetRest;

            KeyPreview = true;
        }

        private void KeyOp(char keyChar)
        {
            oplabel.Text = keyChar.ToString();
            Resultlabel.Text = "";

            if (XtextBox.Focused)
                YtextBox.Focus();
        }
        private void KeyResult()
        {
            if (!int.TryParse(XtextBox.Text, out calc.X) ||
               !int.TryParse(YtextBox.Text, out calc.Y) ||
               oplabel.Text == "" ||
               (oplabel.Text == "/" || oplabel.Text == "%") &&
                 calc.Y == 0)
            {
                Resultlabel.Text = "Ошибка";
                return;
            }
            Resultlabel.Text = op[char.Parse(oplabel.Text)]().ToString();
            Resultlabel.Focus();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (op.ContainsKey(e.KeyChar))
                KeyOp(e.KeyChar);
            else if (e.KeyChar == '=')
                KeyResult();

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                XtextBox.Text = "";
                YtextBox.Text = "";
                oplabel.Text = "";
                Resultlabel.Text = "";
                XtextBox.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
                KeyResult();
        }
    }
}
