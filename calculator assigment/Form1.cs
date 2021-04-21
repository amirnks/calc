using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_assigment
{
    public partial class Form1 : Form
    {
        double value = 0;
        double value2 = 0;
        int rm = 0;
        string txt = "";
        bool press_op = false;
        bool eqll = false;
        List<string> hsy = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "0";
            value = 0;
        }

        

        private void Btn_click(object sender, EventArgs e)
        {
            if((textBox1.Text == "0") || (press_op) || textBox1.Text == "invalid input")
            {
                textBox1.Clear();
            }
            else if(eqll)
            {
                textBox1.Clear();
                eqll = false;
                value = 0;
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
            press_op = false;
        }

     
        private void Btn_ce(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Op_press(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" || value != 0 )
            {
                if (eqll)
                {
                    value = Double.Parse(textBox1.Text);
                }
                else
                {
                    button12.PerformClick();
                }
                eqll = false;
            }
            Button button = (Button)sender;
            txt = button.Text;
            value = Double.Parse(textBox1.Text);
            press_op = true;
           
        }

        private void Btn_eql(object sender, EventArgs e)
        {
            eqll = true;
            value2 = Double.Parse(textBox1.Text);
            textBox3.Text = string.Join("\r\n", hsy);
            switch (txt)
            {
                case "+":
                    textBox2.Text = value.ToString() + "+" + value2.ToString();
                    textBox1.Text = (value + value2).ToString();
                    hsy.Add(value.ToString() + "+" + value2.ToString() + "=" + textBox1.Text);
                    break;
                case "-":
                    textBox2.Text = value.ToString() + "-" + value2.ToString();
                    textBox1.Text = (value - value2).ToString();
                    hsy.Add(value.ToString() + "-" + value2.ToString() + "=" + textBox1.Text);
                    break;
                case "x":
                    textBox2.Text = value.ToString() + "x" + value2.ToString();
                    textBox1.Text = (value * value2).ToString();
                    hsy.Add(value.ToString() + "x" + value2.ToString() + "=" + textBox1.Text);
                    break;
                case "/":
                    
                    textBox2.Text = value.ToString() + "/" + value2.ToString();
                    if (Double.Parse(textBox1.Text) == 0)
                    {
                        textBox1.Text = "cannot divide by zero";
                        break;
                    }
                    else
                        textBox1.Text = (value / value2).ToString();
                        hsy.Add(value.ToString() + "/" + value2.ToString() + "=" + textBox1.Text);
                    break;
                case "x^y": 
                    textBox2.Text = value.ToString() + "^" + value2.ToString();
                    textBox1.Text = Math.Pow(value, value2).ToString();
                    hsy.Add(value.ToString() + "^" + value2.ToString() + "=" + textBox1.Text);
                    break;
                default:
                    break;
            }
            press_op = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
             rm = textBox1.Text.Length - 1;
            if (rm == -1)
            {
                textBox1.Text = "invalid input";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(rm, 1);
            }
        }

        private void pw2(object sender, EventArgs e)
        {
            value = Double.Parse(textBox1.Text);
            textBox2.Text = value.ToString() + "^" + "2";
            textBox1.Text = Math.Pow(Double.Parse(textBox1.Text),2).ToString();
            hsy.Add(value.ToString() + "^  2" + "=" + textBox1.Text);
            press_op = true;
        }

        private void sqrt(object sender, EventArgs e)
        {
            if (Double.Parse(textBox1.Text) < 0)
            {
                textBox1.Text = "Invalid input";
            }
            else
            {
                textBox1.Text = Math.Sqrt(Double.Parse(textBox1.Text)).ToString();
            }
            press_op = true;

        }

        private void ovr(object sender, EventArgs e)
        {
            textBox2.Text ="1"+ "/" + Double.Parse(textBox1.Text).ToString();
            textBox1.Text = (1 / Double.Parse(textBox1.Text)).ToString();
            press_op = true;
        }

        private void Ngt(object sender, EventArgs e)
        {

            textBox1.Text = (-1 * Double.Parse(textBox1.Text)).ToString();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "nine":
                    nine.PerformClick();
                    break;
                case "eight":
                    eight.PerformClick();
                    break;
                case "seven":
                    seven.PerformClick();
                    break;
                case "six":
                    six.PerformClick();
                    break;
                case "five":
                    five.PerformClick();
                    break;
                case "four":
                    four.PerformClick();
                    break;
                case "three":
                    three.PerformClick();
                    break;
                case "two":
                    two.PerformClick();
                    break;
                case "one":
                    one.PerformClick();
                    break;
                case "zero":
                    zero.PerformClick();
                    break;
                case ".":
                    dot.PerformClick();
                    break;
                default:
                    break;




            }
        }

        private void textbox2(object sender, EventArgs e)
        {

        }

        private void textbox3(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}
