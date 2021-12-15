// <copyright file="InsertionSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting;

/// <summary>
/// Insertion sort is a simple sorting algorithm that builds the final
/// sorted array (or list) one item at a time. It is much less efficient
/// on large lists than more advanced algorithms such as quicksort,
/// heapsort, or merge sort.
/// </summary>
public class InsertionSort : ISort
{
    /// <inheritdoc />
    public void Sort<T>(T[] array)
        where T : IComparable<T>
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        for (int j = 1; j < array.Length; ++j)
        {
            T key = array[j];
            int i = j - 1;

            while ((i >= 0) && (array[i].CompareTo(key) > 0))
            {
                array[i + 1] = array[i];
                i -= 1;
            }

            array[i + 1] = key;
        }
    }
}
