using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LL;

namespace STC
{
    public class GenericLinkListStack<T> : Stack<T> where T : class, IComparable
    {
        private LinkList<T> _nonGenericLinkList;
        private int _stackItemCount;

        public GenericLinkListStack()
        {
            _nonGenericLinkList = new StackLinkList<T>();
            _stackItemCount = 0;
        }

        public override void Push(T x)
        {
            //_nonGenericLinkList.Insert(x); // add node at the end of Link List. Causes O(n) for Pop thus violates O(1) of Stack principle.
            _nonGenericLinkList.Insert(x, 1); // add node at the begining nd after headnode. O(1) is ensured
        }

        public override T Pop()
        {
            T result = _nonGenericLinkList.GetItem(1);
            //_nonGenericLinkList.Delete(_stackItemCount); // delete last node from Link List. Causes O(n) thus violates O(1) of Stack principle.
            _nonGenericLinkList.Delete(1); // This will delete in O(1) hence follow Stack principle
            return result;
        }

        public override bool IsEmpty()
        {
            return _stackItemCount == 0;
        }
    }
}
