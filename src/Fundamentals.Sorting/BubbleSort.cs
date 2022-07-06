// <copyright file="BubbleSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting;

/// <summary>
/// Bubble sort, sometimes referred to as sinking sort, is a simple
/// sorting algorithm that repeatedly steps through the list, compares
/// adjacent elements and swaps them if they are in the wrong order.
/// The pass through the list is repeated until the list is sorted.
/// The algorithm, which is a comparison sort, is named for the way
/// smaller or larger elements "bubble" to the top of the list.
/// </summary>
public class BubbleSort : ISort
{
    /// <inheritdoc />
    public void Sort<T>(T[] array)
        where T : IComparable<T>
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        for (int i = 0; i < array.Length; ++i)
        {
            for (int j = array.Length - 1; j > i; --j)
            {
                if (array[j].CompareTo(array[j - 1]) < 0)
                {
                    (array[j], array[j - 1]) = (array[j - 1], array[j]);
                }
            }
        }
    }
}
