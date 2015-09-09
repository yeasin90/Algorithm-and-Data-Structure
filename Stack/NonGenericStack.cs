using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericStack
{
    public abstract class Stack
    {
        abstract public void Push(int x);
        abstract public int Pop();
        abstract public bool IsEmpty();
    }

    public class NonGenericArrayStack : Stack
    {
        private const int MAX_SIZE = 1000;
        private int[] arr = new int[MAX_SIZE];
        private int top = -1;

        public override void Push(int x)
        {
            if (top == MAX_SIZE - 1)
                throw new StackOverflowException("Stack Size Exceedes");
            arr[++top] = x;
        }

        public override int Pop()
        {
            int temp = 0;
            if (top == -1)
                throw new Exception("No elements to pop");

            temp = arr[top--];
            return temp;
        }

        public override bool IsEmpty()
        {
            return top == -1;
        }
    }

    public class NonGenericLinkListStack : Stack
    {
        private Node _headNode;
        private int _nodeCount;
        private const int HEAD_NODE_THRESHOLD = -1000;

        public NonGenericLinkListStack()
        {
            _headNode = new Node();
            _headNode.Data = HEAD_NODE_THRESHOLD;
            _nodeCount = 0;
        }

        public override void Push(int data)
        {
            /*
             * Add on first node to void O(n) and convert to O(1) to maintain Stack principle
             * 
             * Node toAdd = new Node();
             * toAdd.Data = x;
             * toAdd.Next = _headNode;
             * _nodeCount = _nodeCount + 1;
             */


            Node temp;
            temp = getNodeByIndex(_nodeCount); // This will be O(n) which violates Stack O(1).
            temp.Next = createNewNode(data);
            _nodeCount = _nodeCount + 1;
        }


        public override int Pop()
        {
            Node temp = getNodeByIndex(_nodeCount);

            if (temp.Data == HEAD_NODE_THRESHOLD)
                throw new Exception("No elements to pop");

            Node previousNode = getNodeByIndex(_nodeCount - 1);
            previousNode.Next = null;
            _nodeCount = _nodeCount - 1;
            return temp.Data;
        }

        private Node getNodeByIndex(int position)
        {
            Node temp = _headNode;
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

        private Node createNewNode(int x)
        {
            Node toAdd = new Node();
            toAdd.Data = x;

            return toAdd;
        }

        public override bool IsEmpty()
        {
            return _nodeCount == 0;
        }
    }


    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }
}
