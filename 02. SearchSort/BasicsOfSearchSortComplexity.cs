using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    #region References
    // all complexity : http://bigocheatsheet.com/
    // 1. http://www.annedawson.net/BigOh.htm
    // 2. http://www.cs.upc.edu/~jordicf/Teaching/programming/pdf4/MATH02_Complexity-4slides.pdf
    // 3. http://pages.cs.wisc.edu/~vernon/cs367/notes/3.COMPLEXITY.html
    // 4. http://www.quora.com/How-can-we-check-for-the-complexity-log-n-and-n-log-n-for-an-algorithm
    // 5. recursive complexity : http://www.math.ucla.edu/~wittman/10b.1.10w/Lectures/Lec10.pdf
    //                           http://www.cise.ufl.edu/class/cot3100fa07/quicksort_analysis.pdf
    #endregion

    #region Loop Complexity
    public class LoopComplexity
    {
        public void On(int n)
        {
            int i, j = 0;

            for (i = 0; i < n; i++)
            {
            }
            // linear loop always = O(n)

            for (i = n; i > 0; i /= 2)
            {
                for (j = 0; j < i; j++)
                {
                }
            }
            // Complexity NOT O(n2) BUT O(n). HOW?
            // for n = 10,
            // i = 10, outer loop runs 1st time, inner loop runs i(n) times [ total run so far = 1 + n ]
            // i = 5,  outer loop runs 2nd time, inner loop runs i(5) times [ total run so far = 2 + (n + n/2) ]
            // i = 2,  outer loop runs 3rd time, inner loop runs i(2) times [ total run so far = 3 + (n + n/2 + n/2*2) ]
            // i = 1,  outer loop runs 4th time, inner loop runs i(1) times [ total run so far = 4 + (n + n/2 + n/2*2 + n/2*2*2) ]
            // So, outer loop runs for logn times while inner loop runs for = (n + n/2 + n/2*2 + n/2*2*2 + .... + 1 ] 
            // in the progression n + n/2 + n/2*2 + n/2*2*2 + .... + 1, last item is 1 because, if  loop run in logn fashion, it will finally run for 1 time in last step.
            // complexity   = logn + (n + n/2 + n/2*2 + n/2*2*2 + ... + 1)
            //              = logn + n(1 + 1/2 + 1/2*2 + 1/2*2*2 + ... + 1 )
            //              = logn + n[2 - 1/{(2^n) - 1}]
            //              = logn + 2n - n*(1/{(2^n) - 1})
            // In BigOh, we consider large value
            // So, complexity = O(2n) => O(n)
        }

        public void On2(int n)
        {
            int i, j = 0;

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    // statements
                }
            }
            // Complexity O(n2). HOW?
            // i = 1, outer loop runs 1st time, inner loop runs n times [ total runs so far = 1 + n ]
            // i = 2, outer loop runs 2nd time, inner loop runs n times [ total runs so far = 2 + (n+n) = 2 + 2n ]
            // i = 3, outer loop runs 3rd time, inner loop runs n times [ total runs so far = 3 + (n+n+n) = 3 + 3n ]
            // i = n, outer loop runs nth time, inner loop runs n times [ total runs so far = n + (n+n+...+n) = n + n*n ]
            // complexity = n + n2
            // In BigOh, we consider large value
            // So, complexity = O(n2)

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    // statements
                }
            }
            // Complexity O(n2). HOW?
            // i = 1, outer loop runs 1st time, inner loop runs for i(1) times [ total runs so far = 1 + 1 ]
            // i = 2, outer loop runs 2nd time, inner loop runs for i(2) times [ total runs so far = 2 + (1+2) ]
            // i = 3, outer loop runs 3rd time, inner loop runs for i(3) times [ total runs so far = 3 + (1+2+3) ]
            // i = 4, outer loop runs 4th time, inner loop runs for i(4) times [ total runs so far = 4 + (1+2+3+4) ]
            // i = n, outer loop runs nth time, inner loop runs for i(n) times [ total runs so far = n + (1+2+3+4+...+n) ]
            // complexity   = n + (1+2+3+...+n)
            //              = n + n*(n+1)/2
            //              = n + n2 + n*1/2
            // In BigOh, we consider large value
            // So, complexity = O(n2)
        }

        public void logn(int n)
        {
            for (int i = n; i >= 1; i /= 2)
            {
                // statements
            }
            // Complexity O(logn). HOW?
            // for n = 10,
            // i = 10, outer loop runs 1st time. After loop execution i = 10/2 or i = n/2       or i = 5
            // i = 5, outer loop runs 2nd time. After loop execution i = 5/2  or i = n/2*2      or i = 2
            // i = 2, outer loop runs 3rd time, After loop execution i = 2/2  or i = n/2*2*2    or i = 1
            // i = 1, outer loop runs 4th time. After loop execution i = 1/2  or i = n/2*2*2*2  or i = 0
            // So, total number of iteration = 4 (for i = 10, 5, 2 and 1)
            // Or log10 ~ 3.36 ~ 4
            // So, complexity = O(logn)
        }

        public void nlogn(int n)
        {
            int i, j = 0;

            for (i = 0; i < n; i++)
            {
                for (j = n; j > 0; j /= 2)
                {
                    // statements
                }
            }
            // Complexity O(nlogn). HOW?
            // for n = 10,
            // i = 1, outer loop runs 1st time, inner loop runs for logn times [ total runs so far = 1 + logn ]
            // i = 2, outer loop runs 2nd time, inner loop runs for logn times [ total runs so far = 2 + (logn + logn) = 2 + 2logn ]
            // i = 3, outer loop runs 3rd time, inner loop runs for logn times [ total runs so far = 3 + 2logn + logn = 3 + 3logn ]
            // i = 4, outer loop runs 4th time, inner loop runs for logn times [ total runs so far = 4 + 3logn + logn = 4 + 4logn ]
            // i = n, outer loop runs nth time, inner loop runs for logn times [ total runs so far = n + nlogn ]
            // complexity = n + nlogn
            // In BigOh, we consider large value
            // So, complexity = O(nlogn)
        }
    }
    #endregion

    #region Recursion Complexity
    public class RecursionComplexity
    {
        private void DoSomething(int n)
        {
            for (int i = 0; i < n; i++)
            {

            }
        }

        public void Fun1(int n)
        {
            if (n > 0) // cost = 1
            {
                DoSomething(n); // cost = n
                Fun1(n - 1); // cost = 1 ( for subtraction)
            }
        }
        // Complexity O(n2). HOW?
        // In base case, when n = 0, cost = 1 (only comparison will take place)
        // In base case, n = 0. So, T(0) = 1
        // In recursive case, when n > 0, cost = 1 + n + 1 = 2 + n cost
        // recurrence relation T(n) = 2 + n + T(n-1)
        //                          = c + n + [c + n + T(n-2)]
        //                          = 2c + 2n + T(n-2)
        //                          = 2c + 2n + [c + n + T(n-3)]
        //                          = 3c + 3n + T(n-3)
        //                          = 3c + 3n + [c + n + T(n-4)]
        //                          = 4c + 4n + T(n-4)
        //                          = kc + kn + T(n-k)
        // We need to use know values to solve the above recurrence relation. Our known value is T(0) = 1 in base case
        // So, in base case, n-k = 0 => n = k. Putting value of k
        // T(n) = nc + n*n + T(0)
        //      = nc + n2 + 1
        // In BigOh, we consider large value
        // So, complexity = O(n2)


        public void Fun2(int n)
        {
            if (n > 0)      // cost = 1
            {
                DoSomething(n); // cost = n
                Fun2(n / 2);  // cost = 1
            }
        }
        // Complexity O(n). HOW?
        // In base case, when n = 0, cost = 1 (only comparison will take place)
        // In base case, n = 0. So, T(0) = 1
        // In recursive case, when n > 0, cost = 1 + n + 1 = 2 + n cost
        // recurrence relation T(n) = n + T(n/2)
        //                          = n + [ n/2 + T(n/4) ]
        //                          = n + n/2 + [ n/4 + T(n/8) ]
        //                          = n + n/2 + n/4 + T(n/8)
        //                          = n + n/2 + n/4 + n/8 + T(n/8)
        //                          = n/2^0 + n/2^1 + n/2^2 + T(n/2^3)
        //
        // We saw previously, if outer loop runs in logn, inner loop runs only 1 time in final step. 
        // Same thing is happening in the recursive call. Fun2(n/2) is acting like outer loop and DoSomething(n) is acting like inner loop
        // Fun2(n/2) is making total = logn execution and DoSomething(n) is making a total of  = n + n/2 + n/4 + n/8 + ... + 1 execution.
        // So, T(n) = logn + n + n/2 + n/4 + n/8 + ... + 1
        //          = logn + n[2 - 1/{(2^n) - 1}]
        //          = logn + 2n - n*(1/{(2^n) - 1})
        //          = n
        // In BigOh, we consider large value
        // So, complexity = O(n)

        public int FibonacciComplexity(int n)
        {
            if (n == 1 || n == 2) // cost = 1
                return 1;
            else
                return FibonacciComplexity(n - 1) + FibonacciComplexity(n - 2); // cost = 1(n-1) + 1(middle +) + 1(n-2) = 3
        }
        // Complexity O(2^n). HOW?
        // In base cse, when n = 1 or n = 2, cost = 1 (only comparison will take place)
        // In base case, n = 1 or n = 2. So, T(1) or T(2).
        // In recursive case, when n > 2, cost = 1 + 1 + 1 + 1 = 4
        // recurrence reltion T(n)  = 4 + T(n-1) + T(n-2) = c + T(n-1) + T(n-2) [ c = 4 ]
        // 
        // **** Some Observation ****
        // T(n-1) and T(n-2) are call to same function with different parameters. So, we can assume that T(n-1) and T(n-2) will take same ammount of time
        // In relity, T(n-1) > T(n-2)
        //
        // *** Asumming T(n-1) = T(n-2), we get [ considering T(n-1) = T(n-2) is called lower bound ]
        // T(n) = c + 2T(n-2)
        //      = c + 2[c + 2T(n-4)]
        //      = 3c + 4T(n-4)
        //      = 3c + 4[c + 2T(n-6)]
        //      = 7c + 8T(n-6)
        //      = 7c + 8[c + 2T(n-8)]
        //      = 15c + 16T(n-8)
        //      = 2^k*T(n-2k) + (2^k - 1)c
        // We need to use know values to solve the above recurrence relation. Our known value is T(1) = 1 and T(2) = 1 in base case
        // so in base casem
        //                  => n-2k = 1 or n-2k = 2
        //                  => 2k = n - 1 or 2k = n - 2
        //                  => k = (n-1)/2 or k = (n-2)/2
        // putting value of k = (n-1)/2 when n-2k = 1, we get
        // T(n) = 2^{(n-1)/2}*T(1) + (2{(n-1)/2} - 1)c
        //      = 2^{(n/2 - 1/2)}*1 +  [2^{(n/2 - 1/2)}]c - c
        //      = 2^(n/2)....
        // In BigOh, we consider large value
        // So, complexity = O(2^n). This can be improved to O(n2) by using Memoization/Dynamic Programming
        // 
        // *** Asumming T(n-2) = T(n-1), we get [ considering T(n-2) = T(n-1) is called upper bound ]
        // In upper bound similr complexity is found which is O(2^n)

        public int Factorial(int n)
        {
            if (n == 0)     // cost = 1
                return 1;
            else
                return n * Factorial(n - 1); // cost = 1(middle multipliction + 1 (n-1) = 2
        }
        // Complexity O(n). HOW?
        // In base case, when n = 0, cost = 1 (only comparison will take place)
        // In base case, n = 0. So, T(0) = 1
        // In recursive case, when n > 0, cost = 2+1 = 3 cost
        // recurrence relation T(n) = c + T(n-1) [ when c = 3 ]
        //                          = c + [c + T(n-1)]
        //                          = 2c + T(n-2)
        //                          = 2c + [c + T(n-3)]
        //                          = 3c + T(n-3)
        //                          = 3c + [c + T(n-4)]
        //                          = 4c + T(n-4)
        //                          = kc + T(n-k)
        // We need to use know values to solve the above recurrence relation. Our known value is T(0) = 1 in base case
        // So, in base case, n-k = 0 => n = k. Putting value of k
        // T(n) = nc + T(0)
        //      = nc + 1
        // In BigOh, we consider large value
        // So, complexity = O(n) => O(n)
    }
    #endregion

    #region SearchSortComplexity
    public class SearchSortComplexity
    {
        public int[] InsertionSortIterative(int[] arr)
        {
            int j, temp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }

            return arr;
        }

        private void InsertOrder(int element, ref int[] arr, int first, int last)
        {
            if (element >= arr[last])
                arr[last + 1] = element;
            else if (first < last)
            {
                arr[last + 1] = arr[last];
                InsertOrder(element, ref arr, first, last - 1);
            }

            else // first == last and element < a[last]
            {
                arr[last + 1] = arr[last];
                arr[last] = element;

            }
        }

        public int[] InsertionSortRecursive(int[] arr, int first, int last)
        {
            if (first < last)
            {
                InsertionSortRecursive(arr, first, last - 1);
                InsertOrder(arr[last], ref arr, first, last - 1);
            }

            return arr;
        }

        public int[] SelectionSortIterative(int[] arr)
        {
            int min_key, temp = 0;
            int j = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min_key = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min_key] > arr[j])
                        min_key = j;
                }

                temp = arr[min_key];
                arr[min_key] = arr[j];
                arr[j] = temp;
            }

            return arr;
        }

        public void SelectionSortRecursive(ref int[] array, int startIndex)
        {
            if (startIndex >= array.Length - 1)
                return;
            int minIndex = startIndex;
            for (int index = startIndex + 1; index < array.Length; index++)
            {
                if (array[index] < array[minIndex])
                    minIndex = index;
            }
            int temp = array[startIndex];
            array[startIndex] = array[minIndex];
            array[minIndex] = temp;
            SelectionSortRecursive(ref array, startIndex + 1);
        }

        public void BubbleSortIterative(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void BubbleSortRecursive()
        {
            // pointless
        }

        public int BinarySearchInterative(int target, int[] arr, int beg, int end)
        {
            int mid = (beg + end) / 2;
            while (target != arr[mid] && beg < end)
            {
                if (target < arr[mid])
                {
                    end = (mid - 1);
                    mid = (beg + end) / 2;
                }
                else if (target > arr[mid])
                {
                    beg = mid + 1;
                    mid = (beg + end) / 2;
                }
            }

            if (target == arr[mid])
                return arr[mid];
            else
                return -1;
        }

        public int BinarySearchRecursive(int target, int[] arr, int beg, int end)
        {
            if (beg > end)
                return -1;
            else
            {
                int mid = (beg + end) / 2;
                if (target > arr[mid])
                    return BinarySearchRecursive(target, arr, mid + 1, end);
                else if (target < arr[mid])
                    return BinarySearchRecursive(target, arr, beg, mid - 1);
                else
                    return arr[mid];
            }
        }

        public void MergeSort()
        {
            // tree view : http://www.personal.kent.edu/~rmuhamma/Algorithms/MyAlgorithms/Sorting/mergeSort.htm
            //MergeSort(arr[], l,  r)
            //If r > l
            //1. Find the middle point to divide the array into two halves:  
            //         middle m = (l+r)/2
            //2. Call mergeSort for first half:   
            //         Call mergeSort(arr, l, m)
            //3. Call mergeSort for second half:
            //         Call mergeSort(arr, m+1, r)
            //4. Merge the two halves sorted in step 2 and 3:
            //         Call merge(arr, l, m, r)

            // 1. It's  Divide and Conquer
            // 2. It's a recursive algorithm
            // 3. Not In-place algorithm. Because it requires an extra memory. In-place algorithm does not requires extra memory
            // 4. Stable. What is Stable?
            // When we sort, example for integers, we sort in increasing order. 
            // But when we sort complex type, we sort them based on some key property. Example List<SomeClass> 
            // Say, a complex type is (1,2), (2,5), (4,8), (2,3). We want to sort this in increasing order of X-coordinate
            // here, key = X-coordinte
            // In stable algorithm, the relative order of records are preserved
            // So, ordering = (1,2), (2,5), (2,3), (4,8). 
            // NOT (1,2), (2,3), (2,5), (4,8). Because in the original list (2,5) comes before (2,3). So in sorted list, (2,5) must also come before (2,3). This is called stable sorting
            // If Not stable, then (1,2), (2,3), (2,5), (4,8)
            // 
            //
            // Space complexity = O(n)
            // Time Complexity = O(nlogn). HOW?
            // Tn = T(n/2) + T(n/2) + cn
            //    = 2T(n/2) + cn
            //    = 2{2T(n/4) + c*(n/2)} + cn
            //    = 4T(n/4) + 2cn
            //    = 4{2T(n/8) + c*(n/4)} + 2cn
            //    = 8T(n/8) + 3cn
            //    = 2^k*T(n/2^k) + k*cn
            // In base case, T(1)
            // So, n/2^k = 1 or k = logn
            // T(n) = 2^logn*T(1) + logn*cn
            //      = n*c + nlogn [ 2^logn = n and T(1) = 1 = c ]
            //      = O(nlogn)
        }

        public void QuickSort()
        {
            // 1. Divide and Conquer
            // 2. Recursive
            // 3. In place algorithm
            // 4. Not Stable. What is Stable?
            // When we sort, example for integers, we sort in increasing order. 
            // But when we sort complex type, we sort them based on some key property. Example List<SomeClass> 
            // Say, a complex type is (1,2), (2,5), (4,8), (2,3). We want to sort this in increasing order of X-coordinate
            // here, key = X-coordinte
            // In stable algorithm, the relative order of records are preserved
            // So, ordering = (1,2), (2,5), (2,3), (4,8). 
            // NOT (1,2), (2,3), (2,5), (4,8). Because in the original list (2,5) comes before (2,3). So in sorted list, (2,5) must also come before (2,3). This is called stable sorting
            // If Not stable, then (1,2), (2,3), (2,5), (4,8)

            // 1. Find a pivot element form the array.
            // 2. Rearrange the array so that all the elements smaller than pivot comes before and all the element greater than pivot comes after it. After this step the pivot element is in its final position.
            // 3. Recursively apply step 1 and 2 on the divided array.
            // OR
            // 1)  Start with list I of n items
            // 2)  Choose pivot v from I
            // 3)  Partition I into 2 unsorted lists I1 and I2 such that
            //           I1 : all keys smaller than pivot
            //           I2 : all keys larger than pivot
            //           Items same as pivot goes to either list
            // 4)  Sort I1 recursively, yielding sorted list S1
            // 5)  Sort I2 recursively, yielding sorted list S2
            // 6)  Concatenate S1,v,S2 yielding sorted list S
            // OR
            // QuickSort(A, start, end)
            // {
            //      if(start < end)
            //      {
            //          pivotIndex = Partition(A, start, end)
            //          QuickSort(A, start, pivotIndex - 1)
            //          QuickSort(A, pivotIndex + 1, end)
            //      }
            // }

            

            // Quick Sort O(nlogn) in average case or best case (Normal version)
                // In normal version of quick sort, we select last element as pivot. 
                // Put the pivot element from last position  into a place in the array such that, all elements on the left of pivot are less than pivot and in the right are greater than pivot
                // Ex : [6, 8, 3, 2, 1, 7, 5, 4]
                // this function call : pivotIndex = Partition(A, start, end) makes the originl array like : [3, 2, 1, 4, 6, 8, 7, 5]
                // As we can see, pivot element breaks the array into two sub array. And the recursive calls will be based on sub array.
                // This is called a blance partitioning. 
                // Balance paritioning will be the best case.
                // In balance partitioning left sub-array and right sub-arry will have length n/2 [ where n is the number of elements in the original array ]
                // So, in best case, both the recursive call will have T(n/2) and pivotIndex = Partition(A, start, end) will have n
                // T(n) = T(n/2) + T(n/2) + n
                //      = 2T(n/2) + n
                //    = 2{2T(n/4) + c*(n/2)} + cn
                //    = 4T(n/4) + 2cn
                //    = 4{2T(n/8) + c*(n/4)} + 2cn
                //    = 8T(n/8) + 3cn
                //    = 2^k*T(n/2^k) + k*cn
                // In base case, T(n1)
                // So, n/2^k = 1 or k = logn
                // T(n) = 2^logn*T(1) + logn*cn
                //      = n*c + nlogn [ 2^logn = n and T(1) = 1 = c ]
                //      = O(nlogn)




            // Quick Sort O(n2) complexity in Worst case (Normal version)
                // Worst case is when we have totally un-balance paritioning.
                // Ex : [1, 2, 3, 4, 5, 6, 7, 8]
                // already sorted. If we select last element as pivot, we will have the same array.
                // [1, 2, 3, 4, 5, 6, 7, 8]
                // We will have only one segment on the left. There will be no right segment.
                // Our recursive calls : 
                //          QuickSort(A, start, pivotIndex - 1)
                //          QuickSort(A, pivotIndex + 1, end)
                //
                // So, one recursive call will go with T(n-1)
                // Another recursive call will not go with T(n + 1)
                // T(n) = T(n-1) + cn
                //      = {T(n-2) + c(n-1)} + cn
                //      = T(n-2) + 2cn - c
                //      = T(n-3) + c(n-2) + 2cn - c
                //      = T(n-3) + 3cn - 3c
                //      = T(n-4) + 4cn - 6c
                //      = T(n-k) + kcn - (1 + 2 + 3 + .... + k - 1)c
                //      = T(n-k) + kcn - {k(k-1)/2}*c
                // In base case, T(1), so n-k = 1 or n = k
                // T(n) = T(1) + n*n*c + n*(n-1)/2
                //      = O(n2)



            // Quick Sort O(nlogn) complexity in worst case using Randomize version of Quick Sort
            // get a random number from start to end
            // swap arr[rand] with arr[end]
            // then to partitioning
        }

        // So, we can conclude that, Merger Sort performs balance prtitioning in best case and worst case
        // And, Qucik Sort does un-balance paritioning if the array is sorted 
        // We use randomization in Qucik Sort for balance paritioning
    }
    #endregion 
}
