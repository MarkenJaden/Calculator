namespace Taschenrechner
{
    partial class Calculator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.bracket_close = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.bracket_open = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.CET = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Button();
            this.exponent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Enabled = false;
            this.resultBox.Location = new System.Drawing.Point(12, 12);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(232, 20);
            this.resultBox.TabIndex = 0;
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 55);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(50, 50);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Button_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(68, 55);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(50, 50);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Button_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(124, 55);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(50, 50);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Button_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 111);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(50, 50);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Button_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(68, 111);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(50, 50);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Button_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(124, 111);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(50, 50);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Button_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 167);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(50, 50);
            this.one.TabIndex = 7;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.Button_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(68, 167);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(50, 50);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Button_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(124, 167);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(50, 50);
            this.three.TabIndex = 9;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Button_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(194, 55);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 50);
            this.minus.TabIndex = 10;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Button_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(194, 111);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 50);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Button_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(194, 167);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(50, 50);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Button_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(194, 223);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(50, 50);
            this.divide.TabIndex = 13;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Button_Click);
            // 
            // bracket_close
            // 
            this.bracket_close.Location = new System.Drawing.Point(250, 55);
            this.bracket_close.Name = "bracket_close";
            this.bracket_close.Size = new System.Drawing.Size(50, 50);
            this.bracket_close.TabIndex = 14;
            this.bracket_close.Text = ")";
            this.bracket_close.UseVisualStyleBackColor = true;
            this.bracket_close.Click += new System.EventHandler(this.Button_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(68, 223);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(50, 50);
            this.zero.TabIndex = 15;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Button_Click);
            // 
            // bracket_open
            // 
            this.bracket_open.Location = new System.Drawing.Point(250, 111);
            this.bracket_open.Name = "bracket_open";
            this.bracket_open.Size = new System.Drawing.Size(50, 50);
            this.bracket_open.TabIndex = 16;
            this.bracket_open.Text = "(";
            this.bracket_open.UseVisualStyleBackColor = true;
            this.bracket_open.Click += new System.EventHandler(this.Button_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(194, 292);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(50, 50);
            this.result.TabIndex = 17;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.Button_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(12, 292);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(50, 50);
            this.C.TabIndex = 18;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.Button_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(68, 292);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(50, 50);
            this.CE.TabIndex = 19;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.Button_Click);
            // 
            // CET
            // 
            this.CET.Location = new System.Drawing.Point(124, 292);
            this.CET.Name = "CET";
            this.CET.Size = new System.Drawing.Size(50, 50);
            this.CET.TabIndex = 20;
            this.CET.Text = "Backspace";
            this.CET.UseVisualStyleBackColor = true;
            this.CET.Click += new System.EventHandler(this.Button_Click);
            // 
            // console
            // 
            this.console.AutoSize = true;
            this.console.Location = new System.Drawing.Point(366, 12);
            this.console.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(0, 13);
            this.console.TabIndex = 21;
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(124, 223);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(50, 50);
            this.point.TabIndex = 22;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.Button_Click);
            // 
            // exponent
            // 
            this.exponent.Location = new System.Drawing.Point(250, 167);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(50, 50);
            this.exponent.TabIndex = 23;
            this.exponent.Text = "^";
            this.exponent.UseVisualStyleBackColor = true;
            this.exponent.Click += new System.EventHandler(this.Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 24;
            this.button1.Text = "√";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 25;
            this.button2.Text = "π";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 26;
            this.button3.Text = "Sin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(306, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 27;
            this.button4.Text = "Cos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(306, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 28;
            this.button5.Text = "Tan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 355);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exponent);
            this.Controls.Add(this.point);
            this.Controls.Add(this.console);
            this.Controls.Add(this.CET);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.C);
            this.Controls.Add(this.result);
            this.Controls.Add(this.bracket_open);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.bracket_close);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.resultBox);
            this.Name = "Calculator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button bracket_close;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button bracket_open;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button CET;
        private System.Windows.Forms.Label console;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button exponent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

