using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QE
{
    public interface IQueue
    {
        void Enqueue(int x);
        int Dequeue();
    }

    public interface IQueue<T>
    {
        void Enqueue(T x);
        T Dequeue();
    }
}
