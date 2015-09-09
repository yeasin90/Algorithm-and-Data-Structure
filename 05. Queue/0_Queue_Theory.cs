using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QE
{
    class _0_Queue_Theory
    {
        // 1. ADT
        // 2. FIFO
        // 3. Two operations : 1) Enqueue 2) Dequeue
        // 4. Dequeue from front and Enqueue from rare.
        // 5. Both operations should take O(1)
        // 6. LinkList can be used for Queue.
        // 7. If there is only one HEAD pointer in LinkList, Enqueue will take O(n) thus violates Queue O(1)
        // 8. To solve this, or to have both operation as O(1), we use another pointers in LinkList which is RARE pointer.
        // 9. For Dequeue we use FRONT pointer or HEAD pointer For Enqueue we use RARE pointer.
        // 10. FRONT used for deletion. RARE used for insertion.
    }
}
