using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STC
{
    public abstract class Stack
    {
        public int StackItemCount { get; set; }
        abstract public void Push(int x);
        abstract public int Pop();
        abstract public bool IsEmpty();
    }

    public abstract class Stack<T>
    {
        public int StackItemCount { get; set; }
        abstract public void Push(T x);
        abstract public T Pop();
        abstract public T Top();
        abstract public bool IsEmpty();
    }
}
