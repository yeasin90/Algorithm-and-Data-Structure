﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // reference : http://www.bluesharktutorials.com/2013/08/quick-sort-algorithm-with-c-sharp-program-code.html
    class QuickSortNSquare
    {
        // Procedure which return pivot index
        int partition(int[] arr, int start, int end)
        {
            // We assume last element of array as pivot element
            int pivot = end;
            int i = start, j = end, temp;
            while (i < j)
            {
                // traverse the array and find index where element is greater than pivot element
                while (i < end && arr[i] < arr[pivot])
                    i++;
                // traverse the array and find index where element is smaller than pivot element
                while (j > start && arr[j] > arr[pivot])
                    j--;

                //exchange elements on indexes found by i and j
                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            // finally put pivot element at its right position in array
            temp = arr[pivot];
            arr[pivot] = arr[j];
            arr[j] = temp;
            // return pivot index
            return j;
        }
        // Quick sort procedure
        void quicksort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                // find the pivot index
                int pivotIndex = partition(arr, start, end);
                // recursivly call itself for array element before pivot index
                quicksort(arr, start, pivotIndex - 1);
                // recursivly call itself for array element after pivot index
                quicksort(arr, pivotIndex + 1, end);
            }
        }
    }
}
