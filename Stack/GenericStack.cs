using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    public class Node<T> where T : class, IComparable
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }

    public abstract class Stack<T> where T : class, IComparable
    {
        abstract public void Push(T x);
        abstract public T Pop();
        abstract public bool IsEmpty();
    }

    public class GenericLinkListStack<T> : Stack<T> where T : class, IComparable
    {
        private Node<T> _headNode;
        private int _nodeCount;

        public GenericLinkListStack()
        {
            _headNode = new Node<T>();
            _headNode.Data = default(T);
            _nodeCount = 0;
        }

        public override void Push(T data)
        {
            /*
             * Add on first node to void O(n) and convert to O(1) to maintain Stack principle
             * 
             * Node toAdd = new Node();
             * toAdd.Data = x;
             * toAdd.Next = _headNode;
             * _nodeCount = _nodeCount + 1;
             */

            Node<T> temp;
            temp = getNodeByIndex(_nodeCount); // This will be O(n) which violates Stack O(1).
            temp.Next = createNewNode(data);
            _nodeCount = _nodeCount + 1;
        }

        public override T Pop()
        {
            Node<T> temp = getNodeByIndex(_nodeCount);

            if (Equals(temp.Data, default(T)))
                throw new Exception("No elements to pop");

            Node<T> previousNode = getNodeByIndex(_nodeCount - 1);
            previousNode.Next = null;
            _nodeCount = _nodeCount - 1;
            return temp.Data;
        }

        private Node<T> getNodeByIndex(int position)
        {
            Node<T> temp = _headNode;
            int count = 0;

            if (position > _nodeCount || position < 0)
                throw new IndexOutOfRangeException("Index out of range");

            while (temp.Next != null)
            {
                temp = temp.Next;
                count++;
                if (count == position)
                    break;
            }

            return temp;
        }

        private Node<T> createNewNode(T x)
        {
            Node<T> toAdd = new Node<T>();
            toAdd.Data = x;

            return toAdd;
        }

        public override bool IsEmpty()
        {
            return _nodeCount == 0;
        }
    }
}
