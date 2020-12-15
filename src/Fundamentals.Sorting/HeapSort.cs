// <copyright file="HeapSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting
{
    using System;

    /// <summary>
    /// Heapsort is a comparison-based sorting algorithm. Heapsort can be
    /// thought of as an improved selection sort: like selection sort,
    /// heapsort divides its input into a sorted and an unsorted region, and
    /// it iteratively shrinks the unsorted region by extracting the largest
    /// element from it and inserting it into the sorted region. Unlike
    /// selection sort, heapsort does not waste time with a linear-time scan
    /// of the unsorted region; rather, heap sort maintains the unsorted
    /// region in a heap data structure to more quickly find the largest
    /// element in each step.
    /// </summary>
    public class HeapSort : ISort
    {
        /// <inheritdoc />
        public void Sort<T>(T[] array)
            where T : IComparable<T>
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int length = array.Length;

            for (int i = (length / 2) - 1; i >= 0; --i)
            {
                Heapify(array, length, i);
            }

            for (int i = length - 1; i >= 0; --i)
            {
                T temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Heapify(array, i, 0);
            }
        }

        private static void Heapify<T>(T[] array, int length, int i)
            where T : IComparable<T>
        {
            int leftChild = (2 * i) + 1;
            int rightChild = (2 * i) + 2;
            int largest = i;

            if ((leftChild < length) && (array[leftChild].CompareTo(array[largest]) > 0))
            {
                largest = leftChild;
            }

            // if the right child is larger than parent
            if ((rightChild < length) && (array[rightChild].CompareTo(array[largest]) > 0))
            {
                largest = rightChild;
            }

            if (largest != i)
            {
                T temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;

                Heapify(array, length, largest);
            }
        }
    }
}