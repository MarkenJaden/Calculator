using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    class CalcProcess
    {
        // Calculates the stack with the array with postfix
        public Double handleCalculation(Stack<Double> stack, String[] el)
        {
            double zahl1, zahl2;

            //for each input char
            foreach (var ch in el)
            {
                //check if operand
                if (ch.Equals(Operator.ADD) || ch.Equals(Operator.SUB) || ch.Equals(Operator.MUL) || ch.Equals(Operator.DIV) || ch.Equals(Operator.EXP))
                {
                    zahl2 = stack.Pop();
                    zahl1 = stack.Pop();
                    switch (ch)
                    {
                        case "+":
                            {
                                stack.Push(zahl1 + zahl2);
                                break;
                            }

                        case "-":
                            {
                                stack.Push(zahl1 - zahl2);
                                break;
                            }

                        case "*":
                            {
                                stack.Push(zahl1 * zahl2);
                                break;
                            }

                        case "/":
                        case ":": //only necessary if calculator would work with a manual input 
                            {
                                if (zahl2 == 0)
                                {
                                    MessageBox.Show("Warum willst du eigentlich durch 0 teilen? Ich mache da jetzt mal eine 1 raus und rechne damit weiter :)", "0?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    stack.Push(1);
                                    break;
                                }
                                stack.Push(zahl1 / zahl2);
                                break;
                            }

                        case "^":
                            {
                                stack.Push(Math.Pow(zahl1, zahl2));
                                break;
                            }
                    }
                }
                //check if SQRT or SIN... if 'if' wasn't an operand
                else if (ch.Equals(Operator.SQRT)) stack.Push(Math.Sqrt(stack.Pop()));
                else if (ch.Equals(Operator.SIN)) stack.Push(Math.Sin(stack.Pop()));
                else if (ch.Equals(Operator.COS)) stack.Push(Math.Cos(stack.Pop()));
                else if (ch.Equals(Operator.TAN)) stack.Push(Math.Tan(stack.Pop()));
                //else must be number, add to stack for later calc
                else stack.Push(Convert.ToDouble(ch));
            }

            //process finished, return result
            return stack.Pop();
        }
    }
}
