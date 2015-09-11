using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LL;

namespace QE
{
    public class QueueGeneric<T> : IQueue<T> where T : class, IComparable
    {
        private LinkList<T> _linkList;

        public QueueGeneric()
        {
            _linkList = new QueueLinkList<T>();
        }

        public void Enqueue(T x)
        {
            _linkList.Insert(x);
        }

        public T Dequeue()
        {
            return _linkList.GetItem();
        }
    }
}
