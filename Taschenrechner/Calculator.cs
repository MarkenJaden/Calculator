using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private ArrayList needsToBeCalc = new ArrayList();

        private bool resultButtonPressed = false;

        // Starts the whole process with an arraylist as input
        public Double calculate(ArrayList inputList)
        {
            // parameter inputlist to simple string using LINQ
            string input = inputList.Cast<object>().Aggregate("", (current, ch) => current + ch);

            Stack<Double> stack = new Stack<Double>();

            //get postfix from input string
            String temp = Utils.infixToPostfix(input);
            // remove last char, because it will be empty
            temp = temp.Remove(temp.Length - 1);
            //create string array to get all input seperate
            String[] inputs = temp.Split(' ');

            // add to "console"
            console.Text += "Infix: " + input + "\n";
            console.Text += "Postfix: " + temp + "\n";

            //return double calc'ed from input array and empty stack
            return new CalcProcess().handleCalculation(stack, inputs);
        }

        //A lot of redundant shit is going on here, but since it's not rated I didn't care
        private void Button_Click(object sender, EventArgs e)
        {
            Button pressed = (Button) sender;

            if (resultButtonPressed && int.TryParse(pressed.Text, out _))
            {
                resultBox.Text = String.Empty;
                needsToBeCalc.Clear();
                console.Text = String.Empty;
                resultButtonPressed = false;
            }
            else
                resultButtonPressed = false;

            switch (pressed.Text)
            {
                //Delete:
                //Everything
                //Last number or operator
                //Last index
                case "=":
                    if (needsToBeCalc.Count != 0 && !needsToBeCalc[needsToBeCalc.Count - 1].Equals(Operator.ADD) &&
                        !needsToBeCalc[needsToBeCalc.Count - 1].Equals(Operator.SUB) &&
                        !needsToBeCalc[needsToBeCalc.Count - 1].Equals(Operator.MUL) &&
                        !needsToBeCalc[needsToBeCalc.Count - 1].Equals(Operator.DIV) &&
                        !needsToBeCalc[needsToBeCalc.Count - 1].Equals(Operator.EXP) &&
                        !needsToBeCalc[needsToBeCalc.Count - 1].Equals("√"))
                    {
                        resultBox.Text = calculate(needsToBeCalc).ToString();
                        resultButtonPressed = true;
                    }
                    else MessageBox.Show("Eine Zahl wäre schön :)", "Zahl?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "C":
                    resultBox.Text = String.Empty;
                    needsToBeCalc.Clear();
                    console.Text = String.Empty;
                    break;
                case "CE":
                    int index = 0;
                    for (int i = needsToBeCalc.Count - 1;
                        i > -1;
                        i--) //backwards through needToBeCalc
                    {
                        if (int.TryParse(needsToBeCalc[i].ToString(), out _) || needsToBeCalc[i].Equals(".")) continue;
                        index = i++;
                        break;
                    }

                    if (index != 0)
                    {
                        resultBox.Text = Utils.Reverse(resultBox.Text);
                        needsToBeCalc.Reverse();
                        for (int i = index - 1; i >= 0; i--)
                        {
                            needsToBeCalc.RemoveAt(i);
                            resultBox.Text = resultBox.Text.Remove(i,1);
                        }
                        needsToBeCalc.Reverse();
                        resultBox.Text = Utils.Reverse(resultBox.Text);
                    }
                    break;
                case "Backspace":
                    if (resultBox.Text.Length == 0) return;
                    needsToBeCalc.RemoveAt(needsToBeCalc.Count - 1);
                    resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1);
                    break;
                default:
                {
                    string temp = String.Empty;
                    if (resultBox.Text.Length != 0)
                    {
                        var tempCheckSCT = needsToBeCalc[needsToBeCalc.Count - 1];
                        if (tempCheckSCT.Equals("S") || tempCheckSCT.Equals("C") || tempCheckSCT.Equals("T"))
                            if (!int.TryParse(pressed.Text, out _))
                                return; //check if number, out nothing, not needed
                    }

                    //Here I use exceptions, this is not really nice programming, but it serves the purpose for the moment
                    try
                    {
                        //stop if '.' || operator is pressed without a number entered before
                        if (resultBox.Text.Length == 0 && (pressed.Text.Equals(".") || pressed.Text.Equals(Operator.ADD) ||
                                                           pressed.Text.Equals(Operator.SUB) || pressed.Text.Equals(Operator.MUL) ||
                                                           pressed.Text.Equals(Operator.DIV) || pressed.Text.Equals(Operator.EXP) ||
                                                           pressed.Text.Equals(")"))) return;

                        if ((pressed.Text.Equals(Operator.ADD) || pressed.Text.Equals(Operator.SUB) || pressed.Text.Equals(Operator.MUL) ||
                             pressed.Text.Equals(Operator.DIV) || pressed.Text.Equals(Operator.EXP)) &&
                            !needsToBeCalc[needsToBeCalc.Count - 1].Equals(")"))
                            for (int i = needsToBeCalc.Count - 1;
                                i > -1;
                                i--) //backwards through needToBeCalc
                            {
                                if (needsToBeCalc[i].Equals(Operator.ADD) || needsToBeCalc[i].Equals(Operator.SUB) ||
                                    needsToBeCalc[i].Equals(Operator.MUL) || needsToBeCalc[i].Equals(Operator.DIV) ||
                                    needsToBeCalc[i].Equals(Operator.EXP)) break;
                                if (!needsToBeCalc[i].Equals("S") && !needsToBeCalc[i].Equals("C") &&
                                    !needsToBeCalc[i].Equals("T")) continue;
                                resultBox.Text += ")";
                                break;
                            }

                        if (!int.TryParse(pressed.Text, out _))
                            //Check if any operator is being pressed twice or more in a row
                            if (needsToBeCalc[needsToBeCalc.Count - 1].Equals(Operator.ADD) ||
                                needsToBeCalc[needsToBeCalc.Count - 1].Equals(Operator.SUB) ||
                                needsToBeCalc[needsToBeCalc.Count - 1].Equals(Operator.MUL) ||
                                needsToBeCalc[needsToBeCalc.Count - 1].Equals(Operator.DIV) ||
                                needsToBeCalc[needsToBeCalc.Count - 1].Equals(Operator.EXP) ||
                                needsToBeCalc[needsToBeCalc.Count - 1].Equals("(") ||
                                needsToBeCalc[needsToBeCalc.Count - 1].Equals(")"))
                            {
                                    //Check if is allowed
                                if (!pressed.Text.Equals("(") && !pressed.Text.Equals("√") &&
                                    !pressed.Text.Equals("Sin") && !pressed.Text.Equals("Cos") &&
                                    !pressed.Text.Equals("Tan") && !pressed.Text.Equals("π"))
                                {
                                    needsToBeCalc.RemoveAt(needsToBeCalc.Count - 1);
                                    resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1);
                                } else
                                    {
                                        //check if before was a (
                                        if (pressed.Text.Equals("(") && needsToBeCalc[needsToBeCalc.Count - 1].Equals("("))
                                        {
                                            needsToBeCalc.RemoveAt(needsToBeCalc.Count - 1);
                                            resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1);
                                        }
                                    }
                            }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }

                    //check if special and add special
                    switch (pressed.Text)
                    {
                        case "Sin":
                            temp = "(";
                            needsToBeCalc.Add("S");
                            break;
                        case "Cos":
                            temp = "(";
                            needsToBeCalc.Add("C");
                            break;
                        case "Tan":
                            temp = "(";
                            needsToBeCalc.Add("T");
                            break;
                        case "π":
                            needsToBeCalc.Add(Math.PI);
                            break;
                        default:
                            needsToBeCalc.Add(pressed.Text);
                            break;
                    }
                    resultBox.Text += pressed.Text + temp;
                    break;
                }
            }
        }
    }
}
