using System;
using System.Collections.Generic;
using System.Linq;

namespace Taschenrechner
{
    class Utils
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int PointBeforeLine(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1; //Low prio

                case '*':
                case '/':
                case ':':
                    return 2; //Middle prio

                case '^':
                case '√':
                case 'S':
                case 'C':
                case 'T':
                    return 3; //High prio
            }
            return -1;
        }

        // The main method that converts given infix expression to postfix expression.
        public static String infixToPostfix(String exp)
        {
            // initializing empty String for result
            String result = "";

            // initializing empty stack
            Stack<Char> stack = new Stack<char>();

            // walk through every char of given parameter exp
            for (int i = 0; i < exp.Length; ++i)
            {
                char c = exp.ElementAt(i);

                // If the scanned character is an operand, add it to output
                if (Char.IsDigit(c))
                {
                    result += c + "";
                    //Check whether the following character is a point or a number in order to add the spaces appropriately
                    try
                    {
                        char temp = exp.ElementAt(1 + i);
                        if (temp == ',')
                        {
                            result += temp + "";
                        }
                        else if (!Char.IsDigit(temp))
                        {
                            result += " ";
                        }
                    }
                    catch (Exception)
                    {
                        result += " ";
                    }

                } // If the scanned character is an '(', push it to the stack
                else switch (c)
                {
                    // an '(' is encountered
                    case '(':
                        stack.Push(c);
                        break;
                    //  If the scanned character is an ')', pop and output from the stack
                    case ')':
                        while (stack.Count != 0 && stack.Peek() != '(')
                        {
                            result += stack.Pop() + " ";
                        }

                        if (stack.Count != 0 && stack.Peek() != '(')
                        {
                            return "Invalid Expression"; // not possible, will throw error
                        }
                        else
                        {
                            stack.Pop();
                        }

                        break;
                    case ',':
                        break;
                    // an operator is encountered
                    default:
                    {
                        //Check math rules (PointBeforeLine Rule) if higher => higher prio
                        while (stack.Count != 0 && Utils.PointBeforeLine(c) <= Utils.PointBeforeLine(stack.Peek()))
                        {
                            if (stack.Peek() == '(')
                            {
                                return "Invalid Expression";
                            }
                            result += stack.Pop() + " ";
                        }
                        stack.Push(c);
                        break;
                    }
                }

                //console.Text += "Convert " + i + ": " + result + "\n\n";
                //console.Text += "Stack: \n";
                //foreach (var l in stack)
                //{
                //    console.Text += l + " ";
                //}
                //console.Text += "\n\n";
            }

            // pop all the operators from the stack and add to full qualified string
            while (stack.Count != 0)
            {
                if (stack.Peek() == '(')
                {
                    return "Invalid Expression";
                }
                result += stack.Pop() + " ";
            }
            return result;
        }
    }
}
