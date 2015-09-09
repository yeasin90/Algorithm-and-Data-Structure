using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STC
{
    public abstract class Stack
    {
        abstract public void Push(int x);
        abstract public int Pop();
        abstract public bool IsEmpty();
    }

    public abstract class Stack<T>
    {
        abstract public void Push(T x);
        abstract public T Pop();
        abstract public bool IsEmpty();
    }
}
