// <copyright file="SelectionSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting;

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

        int minimal;
        for (int i = 0; i < array.Length - 1; ++i)
        {
            minimal = i;
            for (int j = i + 1; j < array.Length; ++j)
            {
                if (array[j].CompareTo(array[minimal]) < 0)
                {
                    minimal = j;
                }
            }

            T buffer = array[i];
            array[i] = array[minimal];
            array[minimal] = buffer;
        }
    }
}
