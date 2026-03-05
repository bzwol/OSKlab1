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
            this.ClientSize = new Size(600, 300);
            this.analogClock1.Visible = true;
            this.digitalClock1.Visible = false;
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
                label_disp.Text += ",";
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
                        output += '.';
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

            for (int i = 0; i < rpn.Length; i++)
            {
                char c = rpn[i];
                if (char.IsDigit(c) || c == '.')
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
                    if (c == '+' || c == '-' || c == '*' || c == '/')
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
            return stack.Pop();
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
    }
}
