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
            this.DoubleBuffered = true;
            this.analogClock1.Visible = true;
            this.digitalClock1.Visible = false;
            changeColors();

        }

        private void Button_Digit_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string digit = button.Text;

            if (label_disp.Text == "0")
                {
                    label_disp.Text = digit;
                }
                else
                {
                    label_disp.Text += digit;
            }
        }

        private void Button_Operator_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string operatorSymbol = button.Text;

            if(!string.IsNullOrEmpty(label_disp.Text))
            {
                if (label_disp.Text.EndsWith("+") || label_disp.Text.EndsWith("-") || label_disp.Text.EndsWith("*") || label_disp.Text.EndsWith("/"))
                {
                    label_disp.Text = label_disp.Text.Substring(0, label_disp.Text.Length - 1) + operatorSymbol;
                }
                else
                    label_disp.Text += operatorSymbol;
            }
        }

        private void Button_Comma_Click(object sender, EventArgs e) {
            if (!label_disp.Text.Contains(","))
            {
                label_disp.Text += "0,";
            }
        }
        private string Convert_To_RPN(object sender, EventArgs e)
        {
            Label label = sender as Label;
            Stack<char> stack = new Stack<char>();
            string expression = label.Text;
            string output = null;

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (char.IsDigit(c) || c == ',')
                {
                    if (c == ',')
                    {
                        output += ',';
                    } else
                    output += c;
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    output += ' ';
                    while(stack.Count() > 0 && (stack.Peek() == '*' || stack.Peek() == '/'))
                    {
                        output += " " + stack.Pop() + " ";
                    }
                    stack.Push(c);
                }
            }

            while (stack.Count > 0)
            {
                output += " " + stack.Pop();
            }
            return output;
        }

        private float Solve_RPN(string rpn)
        {
            float result = 0;
            Stack<float> stack = new Stack<float>();
            string number = null;
            if (rpn == null) return 0;
            for (int i = 0; i < rpn.Length; i++)
            {
                char c = rpn[i];
                if (char.IsDigit(c) || c == ',')
                {
                    number += c;
                }
                else
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        stack.Push(float.Parse(number));
                        number = null;
                    }
                    if ((c == '+' || c == '-' || c == '*' || c == '/') & stack.Count > 0)
                    {
                        float a = stack.Pop();
                        float b = stack.Pop();
                        switch (c)
                        {
                            case '+':
                                result = b + a;
                                break;
                            case '-':
                                result = b - a;
                                break;
                            case '*':
                                result = b * a;
                                break;
                            case '/':
                                result = b / a;
                                break;
                        }
                        stack.Push(result);
                    }
                }
            }
            if (stack.Count > 0) return stack.Pop();
            else return float.Parse(number);
        }

        private void button_eq_Click(object sender, EventArgs e)
        {
            string rpn = Convert_To_RPN(label_disp, e);
            float result = Solve_RPN(rpn);
            label_disp.Text = result.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            label_disp.Text = "";
        }

        private void menu_clock_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            if (clickedItem == null) return;

            ToolStripMenuItem parent = clickedItem.OwnerItem as ToolStripMenuItem;
            if (parent != null)
            {
                foreach (ToolStripItem item in parent.DropDownItems)
                {
                    if (item is ToolStripMenuItem menuItem)
                        menuItem.Checked = false;
                }
            }
            clickedItem.Checked = true;

            int clockMode = int.Parse(clickedItem.Tag.ToString());
            analogClock1.Visible = (clockMode == 1);
            digitalClock1.Visible = (clockMode == 2);
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void domyślnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            motive_colors[0] = Color.White;
            motive_colors[1] = Color.FromArgb(240, 240, 240);
            motive_colors[2] = Color.Black;
            changeColors();
        }

        private void ciemnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            motive_colors[0] = Color.Black;
            motive_colors[1] = Color.FromArgb(25,25,25);
            motive_colors[2] = Color.DodgerBlue;
            changeColors();
        }

        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            motive_colors[0] = Color.DarkGreen;
            motive_colors[1] = Color.ForestGreen;
            motive_colors[2] = Color.GreenYellow;
            changeColors();
        }

        void changeColors()
        {
            this.BackColor = motive_colors[0];
            foreach (var btn in this.Controls.OfType<Button>()) 
            {
                btn.BackColor = motive_colors[1];
                btn.ForeColor = motive_colors[2];
            }
            
            this.label_disp.BackColor = motive_colors[1];
            this.label_disp.ForeColor = motive_colors[2];

            this.digitalClock1.main_color = motive_colors[1];
            this.digitalClock1.detail_color = motive_colors[2];

            this.analogClock1.main_color = motive_colors[1];
            this.analogClock1.detail_color = motive_colors[2];

            this.menuStrip1.BackColor = motive_colors[0];
            this.menuStrip1.ForeColor = motive_colors[2];

            foreach(ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = motive_colors[0];
                item.ForeColor = motive_colors[2];
                changeMenuItemColors(item);
            }
        }

        void changeMenuItemColors(ToolStripMenuItem parent)
        {
            foreach (ToolStripMenuItem item in parent.DropDownItems)
            {
                item.BackColor = motive_colors[0];
                item.ForeColor = motive_colors[2];


                if (item.DropDownItems.Count > 0)
                {
                    changeMenuItemColors(item);
                }
            }
        }

        private void button_KeyPress(object sender, KeyPressEventArgs e)
        { 
            switch (e.KeyChar)
            {
                case '0':
                    {
                        this.button0.PerformClick();
                        return;
                    }
                case '1':
                    {
                        this.button1.PerformClick();
                        return;
                    }
                case '2':
                    {
                        this.button2.PerformClick();
                        return;
                    }
                case '3':
                    {
                        this.button3.PerformClick();
                        return;
                    }
                case '4':
                    {
                        this.button4.PerformClick();
                        return;
                    }
                case '5':
                    {
                        this.button5.PerformClick();
                        return;
                    }
                case '6':
                    {
                        this.button6.PerformClick();
                        return;
                    }
                case '7':
                    {
                        this.button7.PerformClick();
                        return;
                    }
                case '8':
                    {
                        this.button8.PerformClick();
                        return;
                    }
                case '9':
                    {
                        this.button9.PerformClick();
                        return;
                    }
                case ',':
                    {
                        this.button_comma.PerformClick();
                        return;
                    }
                case '-':
                    {
                        this.button_sub.PerformClick();
                        return;
                    }
                case '/':
                    {
                        this.button_div.PerformClick();
                        return;
                    }
                case (char)Keys.Back:
                    {
                        if(this.label_disp.Text.Length > 0) this.label_disp.Text = this.label_disp.Text.Remove(this.label_disp.Text.Length - 1);
                        return;
                    }
                case (char)Keys.Enter:
                    {
                        this.button_eq.PerformClick();
                        return;
                    }
                case '+':
                    {
                        this.button_add.PerformClick();
                        return;
                    }
                case '*':
                    {
                        this.button_mul.PerformClick();
                        return;
                    }
                default:
                    break;
                
            }
        }
    }
}
