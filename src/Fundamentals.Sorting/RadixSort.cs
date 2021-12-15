// <copyright file="RadixSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting;

/// <summary>
/// Radix sort is a non-comparative sorting algorithm. It avoids
/// comparison by creating and distributing elements into buckets
/// according to their radix.
/// </summary>
public class RadixSort : ISort
{
    /// <inheritdoc />
    public void Sort<T>(T[] array)
        where T : IComparable<T>
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        switch (array)
        {
            case int[] integers:
                Sort(integers, 32);
                break;
            default:
                new MergeSort().Sort(array);
                break;
        }
    }

    private static void Sort(int[] array, int size)
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        int i, j;
        int[] temp = new int[array.Length];

        for (int shift = size - 1; shift > -1; --shift)
        {
            j = 0;

            for (i = 0; i < array.Length; ++i)
            {
                bool move = (array[i] << shift) >= 0;
                if (shift == 0 ? !move : move)
                {
                    array[i - j] = array[i];
                }
                else
                {
                    temp[j++] = array[i];
                }
            }

            Array.Copy(temp, 0, array, array.Length - j, j);
        }
    }
}
