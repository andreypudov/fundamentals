// <copyright file="SelectionSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting
{
    using System;

    /// <summary>
    /// Selection sort is an in-place comparison sorting algorithm. It has
    /// an O(n2) time complexity, which makes it inefficient on large lists,
    /// and generally performs worse than the similar insertion sort.
    /// </summary>
    public class SelectionSort : ISort
    {
        /// <inheritdoc />
        public void Sort<T>(T[] array)
            where T : IComparable<T>
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int min;
            for (int i = 0; i < array.Length - 1; ++i)
            {
                min = i;
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if (array[j].CompareTo(array[min]) < 0)
                    {
                        min = j;
                    }
                }

                T buffer = array[i];
                array[i] = array[min];
                array[min] = buffer;
            }
        }
    }
}