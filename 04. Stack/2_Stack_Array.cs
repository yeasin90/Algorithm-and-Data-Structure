using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STC
{
    public class ArrayStack : Stack
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
}
