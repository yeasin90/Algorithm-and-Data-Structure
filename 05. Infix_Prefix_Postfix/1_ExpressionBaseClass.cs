using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public abstract class ExpressionEvaluator
    {
        protected int Perform(char oprt, int operand1, int operand2)
        {
            int oprdn1 = operand1;
            int oprnd2 = operand2;
            int result = 0;

            switch (oprt)
            {
                case '+':
                    {
                        result = oprdn1 + oprnd2;
                        break;
                    }
                case '-':
                    {
                        result = oprdn1 - oprnd2;
                        break;
                    }
                case '*':
                    {
                        result = oprdn1 * oprnd2;
                        break;
                    }
                case '/':
                    {
                        result = oprdn1 / oprnd2;
                        break;
                    }
                default:
                    break;
            }

            return result;
        }

        public abstract T Evaluate<T>(string input) where T : IComparable;
    }

    public static class ExpressionHelper
    {
        public static int CharToInt(char c)
        {
            return c - '0';
        }

        public static char IntToChar(int x)
        {
            char result = '-';
            if (x >= 0 && x < 10)
                result = (char)(x + '0');

            return result;
        }

        public static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        public static bool IsHighPreference(char input, char target)
        {
            return false;
        }
    }
}
