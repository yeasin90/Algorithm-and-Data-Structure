using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class TheoryStackQueueLinkListArray
    {
        public void Array()
        {
            // Contiguous memory location
            // Not dynmic memory allocation
            // Access time in best case O(1)
            // Access time in Worst case O(n)
        }

        public void LinkList()
        {
            // Not contiguous. But nodes one by each other 
            // Nodes are connected with each other.
            // 1st node is pointed by a Start Pointer
            // In array, we can acces any element by index value
            // In link list, we cannot access an element directly with index becuse it's not contiguous
            // We have to start with the Strt pointer then traverse further to find out target
            // So, Access time in best case and worst case is O(n)
            // There are two parts in a LinkList node 1)Value 2)NextNodePointer
            // So, each node will take two places of memory
            // But, in array each index takes only one space
            // So, extra memory used by Link List
            // Doubly linbk list is something better where ech node contains informtion about it's next nd previous node
        }

        public void Stack()
        {
            // (ADT) Abstract Data Type
            // ADT, becuse we don't bother about there implementation. We bother about there opertion. Opertion : Push, Pop, Top, IsEmpty
            // LIFO
            // Push, Pop are stack opertion with O(1)
            // Stack can be implemented with array and link list
            // Stack with array. push element into last index. pop element from last index
            // One limittion with array is array is not dynamic. 
            // So, if array is exhuasted, we have to create e new array with double size of the previous array and copy all elements to new array. But cost of copy from old arr to new arr is O(n)
            // So, time complexity for Push opertion in Stack using rray is O(1) in best case and O(n) in worst cse(when arra is exhuasted)
            // Stack with Link List. But LinkList has O(n) cost for push operation and same for pop
            // So, to use Link Link with statc, we have to put element at the begining node and pop from it. Then we can have O(1)
        }

        public void Queue()
        {
            // (ADT) Abstract Data Type
            // ADT, becuse we don't bother about there implementation. We bother about there opertion. Opertion : Push, Pop, Top, IsEmpty
            // FIFO
        }
    }
}
