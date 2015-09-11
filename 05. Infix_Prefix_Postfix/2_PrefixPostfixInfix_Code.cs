using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using STC;

namespace DataStructure
{

    public class PostFix : ExpressionEvaluator
    {
        private STC.Stack<int> _stack;
        private int _result;

        public PostFix() 
        {
            _stack = new GenericLinkListStack<int>();
        }

        public override T Evaluate<T>(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                    _stack.Push(ExpressionHelper.CharToInt(input[i]));
                else if (ExpressionHelper.IsOperator(input[i]))
                {
                    int oprnd2 = _stack.Pop();
                    int oprnd1 = _stack.Pop();

                    _stack.Push(Perform(input[i], oprnd1, oprnd2));
                }
            }

            _result = _stack.Pop();
            return (T)(object)_result; // ref : http://stackoverflow.com/questions/8619948/why-cant-i-cast-int-to-t-but-can-cast-int-to-object-and-then-object-to-t
        }
    }

    public class Prefix : ExpressionEvaluator
    {
        private STC.Stack<int> _stack;
        private int _result;

        public Prefix()
        {
            _stack = new GenericLinkListStack<int>();
        }

        public override T Evaluate<T>(string input)
        {
            for(int i = input.Length - 1; i >=0; i--)
            {
                if (Char.IsDigit(input[i]))
                    _stack.Push(ExpressionHelper.CharToInt(input[i]));
                else if (ExpressionHelper.IsOperator(input[i]))
                {
                    int oprnd2 = _stack.Pop();
                    int oprnd1 = _stack.Pop();

                    _stack.Push(Perform(input[i], oprnd1, oprnd2));
                }
            }

            _result = _stack.Pop();
            return (T)(object)_result; // ref : http://stackoverflow.com/questions/8619948/why-cant-i-cast-int-to-t-but-can-cast-int-to-object-and-then-object-to-t
        }
    }

    public class InfixToPostfix : ExpressionEvaluator 
    {
        private STC.Stack<char> _stack;
        private string _result;
        
        public InfixToPostfix()
        {
            //_result = new StringBuilder();
            _stack = new GenericLinkListStack<char>();
        }

        public override T Evaluate<T>(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (Char.IsNumber(current) || Char.IsLetterOrDigit(current))
                    _result += current;
                else if (current == '(')
                    _stack.Push(current);
                else if (current == ')')
                {
                    current = _stack.Pop();
                    while (current != '(')
                    {
                        _result += current;
                        current = _stack.Pop();
                    }
                }
                else
                {
                     if(_stack.StackItemCount != 0 && ExpressionHelper.IsHighPreference(current, _stack.Top()))
                     {
                          while(_stack.StackItemCount != 0)
                          {
                              _result += _stack.Pop();
                          }
                      }
                      else
                          _stack.Push(current);
                }
            }

            while (_stack.StackItemCount != 0)
            {
                _result += _stack.Pop();
            }

            return (T)(object)_result;
        }
    }
}
