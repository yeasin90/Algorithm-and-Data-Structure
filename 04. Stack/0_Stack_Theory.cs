using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Stack
{
    class _0_Stack_Theory
    {
        // 1. Abstract Data Type : ADT
        // 2. ADT means we does not care about there implementation. We care about there operation.
        // 3. Stack operations are two, 1. Push 2. Pop
        // 4. LIFO = Last-In-First-Out
        // 5. Each opertion of stack must take O(1). Beacuse, we do opertion in stack in a one side.
        // 6. Stack can be used with Array and LinkList
        // 7. Push and Pop operation in array is O(1). Because in arry, we will push element at end and pop element from end of arry. Thus O(1).
        // 8. Problem is, when array is full, stack is full. So, we have to create a new array with double size and copy from old array to new array. Thus O(n) and violates Stack O(1)
        // 9. To avoid O(n) with array, we need dynamic memory allocation with LinkList
        // 8. But Push pop operation in Link List is O(n). So, to use LinkList for stack, we have to push item after the head and pop from there.
    }
}
