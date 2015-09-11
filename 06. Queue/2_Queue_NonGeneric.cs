using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LL;

namespace QE
{
    public class QueueNonGeneric : IQueue
    {
        private LinkList _linkList;

        public QueueNonGeneric()
        {
            _linkList = new QueueLinkList();
        }

        public void Enqueue(int x)
        {
            _linkList.Insert(x);
        }

        public int Dequeue()
        {
            return _linkList.GetItem();
        }
    }
}
