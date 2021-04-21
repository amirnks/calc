
namespace calculator_assigment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 52);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "sqrt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sqrt);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "x^2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.pw2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "x^y";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Op_press);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "1/x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ovr);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Btn_ce);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(93, 165);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(73, 38);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(172, 165);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(73, 38);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "DEL";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(251, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 38);
            this.button8.TabIndex = 8;
            this.button8.Text = "/";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Op_press);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(251, 209);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 38);
            this.button9.TabIndex = 9;
            this.button9.Text = "x";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Op_press);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(251, 253);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 38);
            this.button10.TabIndex = 10;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Op_press);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(251, 297);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(73, 38);
            this.button11.TabIndex = 11;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Op_press);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(251, 341);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(73, 53);
            this.button12.TabIndex = 12;
            this.button12.Text = "=";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Btn_eql);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(14, 209);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(73, 38);
            this.seven.TabIndex = 17;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Btn_click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(14, 253);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(73, 38);
            this.four.TabIndex = 18;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Btn_click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(14, 297);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(73, 38);
            this.one.TabIndex = 19;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.Btn_click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(14, 341);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 47);
            this.button15.TabIndex = 20;
            this.button15.Text = "+/-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Ngt);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(172, 209);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(73, 38);
            this.nine.TabIndex = 21;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Btn_click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(93, 209);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(73, 38);
            this.eight.TabIndex = 22;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Btn_click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(93, 253);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(73, 38);
            this.five.TabIndex = 23;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Btn_click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(93, 297);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(73, 38);
            this.two.TabIndex = 24;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Btn_click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(93, 341);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(73, 47);
            this.zero.TabIndex = 25;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Btn_click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(172, 253);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(73, 38);
            this.six.TabIndex = 26;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Btn_click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(172, 297);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(73, 38);
            this.three.TabIndex = 27;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Btn_click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(172, 341);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(73, 47);
            this.dot.TabIndex = 28;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.Btn_click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 42);
            this.textBox2.TabIndex = 29;
            this.textBox2.Click += new System.EventHandler(this.textbox2);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(328, 14);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 321);
            this.textBox3.TabIndex = 30;
            this.textBox3.Click += new System.EventHandler(this.textbox3);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(346, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 45);
            this.button6.TabIndex = 31;
            this.button6.Text = "clear history";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 398);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.three);
            this.Controls.Add(this.six);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.two);
            this.Controls.Add(this.five);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.one);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
    }
}

