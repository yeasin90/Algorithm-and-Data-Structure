using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LL;

namespace STC
{
    public class NonGenericLinkListStack : Stack
    {
        private LinkList _nonGenericLinkList;

        public NonGenericLinkListStack()
        {
            _nonGenericLinkList = new StackLinkList();
            StackItemCount = 0;
        }

        public override void Push(int x)
        {
            //_nonGenericLinkList.Insert(x); // add node at the end of Link List. Causes O(n) for Pop thus violates O(1) of Stack principle.
            _nonGenericLinkList.Insert(x, 1); // add node at the begining nd after headnode. O(1) is ensured
            StackItemCount = StackItemCount + 1;
        }

        public override int Pop()
        {
            int result = _nonGenericLinkList.GetItem(1);
            //_nonGenericLinkList.Delete(_stackItemCount); // delete last node from Link List. Causes O(n) thus violates O(1) of Stack principle.
            _nonGenericLinkList.Delete(1); // This will delete in O(1) hence follow Stack principle
            StackItemCount = StackItemCount - 1;
            return result;
        }

        public override bool IsEmpty()
        {
            return StackItemCount == 0;
        }
    }
}
