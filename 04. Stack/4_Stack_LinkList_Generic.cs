using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LL;

namespace STC
{
    public class GenericLinkListStack<T> : Stack<T> where T : IComparable
    {
        private LinkList<T> _genericLinkList;

        public GenericLinkListStack()
        {
            _genericLinkList = new StackLinkList<T>();
            StackItemCount = 0;
        }

        public override void Push(T x)
        {
            //_nonGenericLinkList.Insert(x); // add node at the end of Link List. Causes O(n) for Pop thus violates O(1) of Stack principle.
            _genericLinkList.Insert(x, 1); // add node at the begining nd after headnode. O(1) is ensured
            StackItemCount = StackItemCount + 1;
        }

        public override T Pop()
        {
            T result = _genericLinkList.GetItem(1);
            //_nonGenericLinkList.Delete(_stackItemCount); // delete last node from Link List. Causes O(n) thus violates O(1) of Stack principle.
            _genericLinkList.Delete(1); // This will delete in O(1) hence follow Stack principle
            StackItemCount = StackItemCount - 1;
            return result;
        }

        public override bool IsEmpty()
        {
            return StackItemCount == 0;
        }

        public override T Top()
        {
            return _genericLinkList.GetItem(1);
            //throw new NotImplementedException();
        }
    }
}
