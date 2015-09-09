using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public abstract class LinkList<T>
    {
        protected Node<T> _headNode;
        protected int _numberOfNode;

        public LinkList()
        {
            _headNode = new Node<T>();
            _numberOfNode = 0;
        }

        public abstract void Insert(T input);
        public virtual void Insert(T input, int index)
        {
            if (index < 0)
                throw new IndexOutOfRangeException("Index out of Range");
            else if (index > _numberOfNode + 1)
                throw new IndexOutOfRangeException("Number of Nodes : " + _numberOfNode + ". Highest insert index can be : " + _numberOfNode + 1);
            else if (index == 0)
                throw new Exception("Head node already exist");

            Node<T> toAdd = createNode(input);

            if (_numberOfNode == 0)
                _headNode.Next = toAdd;
            else if (index == 1)
            {
                toAdd.Next = _headNode.Next;
                _headNode.Next = toAdd;
            }
            else
            {
                Node<T> previous = getNodeByIndex(index - 1);
                Node<T> next = getNodeByIndex(index + 1);
                previous.Next = toAdd;
                toAdd.Next = next;
            }

            _numberOfNode = _numberOfNode + 1;
        }
        public void Delete(int index)
        {
            if (_numberOfNode == 0)
                throw new Exception("List is empty. Cannot delete head node");
            else if (index == 0)
                throw new Exception("Cannot delete head node");
            else if (index < 0 || index > _numberOfNode)
                throw new IndexOutOfRangeException("Index out of Range");

            Node<T> toDelete = getNodeByIndex(index);
            Node<T> previous = getNodeByIndex(index - 1);

            previous.Next = toDelete.Next;
            _numberOfNode = _numberOfNode - 1;
        }
        public virtual T GetItem(int index = 0)
        {
            return getNodeByIndex(index).Data;
        }
        protected Node<T> getNodeByIndex(int index)
        {
            Node<T> temp = _headNode;
            int counter = 0;

            if (index < 0 || index > _numberOfNode)
                throw new IndexOutOfRangeException("Index out of Range");
            else if (_numberOfNode == 0)
                throw new Exception("List is empty");
            else if (index == 0)
                return temp;

            while (temp.Next != null)
            {
                temp = temp.Next;
                counter++;

                if (counter == index)
                    break;
            }

            return temp;
        }
        protected Node<T> createNode(T x)
        {
            return new Node<T>() { Data = x };
        }
    }

    public class StackLinkList<T> : LinkList<T>
    {
        public override void Insert(T input)
        {
            Node<T> temp = getNodeByIndex(_numberOfNode);
            Node<T> toAdd = createNode(input);
            temp.Next = toAdd;
            _numberOfNode = _numberOfNode + 1;
        }
    }

    public class QueueLinkList<T> : LinkList<T>
    {
        private Node<T> _rare;

        public QueueLinkList()
        {
            _rare = new Node<T>();
        }

        public override void Insert(T input)
        {
            Node<T> toAdd = createNode(input);

            if (_headNode.Next == null && _rare.Next == null)
                _headNode.Next = toAdd;

            _rare.Next = toAdd;
            _rare = toAdd;
        }

        public override T GetItem(int index)
        {
            if (_headNode.Next == null)
                throw new Exception("Empty queue");

            T result = _headNode.Next.Data;
            _headNode.Next = _headNode.Next.Next;
            return result;
        }
    }
}
