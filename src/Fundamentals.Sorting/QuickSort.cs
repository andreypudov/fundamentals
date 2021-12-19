// <copyright file="QuickSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting;

/// <summary>
/// Quicksort is a divide-and-conquer algorithm. It works by selecting
/// a 'pivot' element from the array and partitioning the other elements
/// into two sub-arrays, according to whether they are less than or
/// greater than the pivot. The sub-arrays are then sorted recursively.
/// </summary>
public class QuickSort : ISort
{
    /// <inheritdoc />
    public void Sort<T>(T[] array)
        where T : IComparable<T>
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        Sort(array, 0, array.Length - 1);
    }

    private static void Sort<T>(T[] array, int lo, int hi)
        where T : IComparable<T>
    {
        if (lo < hi)
        {
            int p = Partition(array, lo, hi);
            Sort(array, lo, p - 1);
            Sort(array, p + 1, hi);
        }
    }

    private static int Partition<T>(T[] array, int lo, int hi)
        where T : IComparable<T>
    {
        T pivot = array[lo + ((hi - lo) / 2)];
        int i = lo - 1;
        int j = hi + 1;

        while (true)
        {
            do
            {
                i = i + 1;
            }
            while (array[i].CompareTo(pivot) < 0);

            do
            {
                j = j - 1;
            }
            while (array[j].CompareTo(pivot) > 0);

            if (i >= j)
            {
                return j;
            }

            Swap(array, i, j);
        }
    }

    private static void Swap<T>(T[] array, int i, int j)
    {
        T temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
}
