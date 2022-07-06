// <copyright file="QuickSortDualPivotParallel.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting;

/// <summary>
/// Quicksort is a divide-and-conquer algorithm. It works by selecting
/// a 'pivot' element from the array and partitioning the other elements
/// into two sub-arrays, according to whether they are less than or
/// greater than the pivot. The sub-arrays are then sorted recursively.
/// </summary>
public class QuickSortDualPivotParallel : ISort
{
    /// <inheritdoc />
    public void Sort<T>(T[] array)
        where T : IComparable<T>
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        if (array.Length > short.MaxValue)
        {
            new QuickSortDualPivot().Sort(array);
            return;
        }

        Sort(array, 0, array.Length - 1, (int)Math.Log(Environment.ProcessorCount, 2.0) + 4);
    }

    private static void Sort<T>(T[] array, int lo, int hi, int depth)
        where T : IComparable<T>
    {
        if (lo < hi)
        {
            (int p0, int p1) = Partition(array, lo, hi);

            if (depth < 0)
            {
                Sort(array, lo, p0 - 1);
                Sort(array, p0 + 1, p1 - 1);
                Sort(array, p1 + 1, hi);
            }
            else
            {
                Parallel.Invoke(
                    new ParallelOptions()
                    {
                        MaxDegreeOfParallelism = 3,
                    },
                    () => Sort(array, lo, p0 - 1, depth - 1),
                    () => Sort(array, p0 + 1, p1 - 1, depth - 1),
                    () => Sort(array, p1 + 1, hi, depth - 1));
            }
        }
    }

    private static void Sort<T>(T[] array, int lo, int hi)
        where T : IComparable<T>
    {
        if (lo < hi)
        {
            (int p0, int p1) = Partition(array, lo, hi);
            Sort(array, lo, p0 - 1);
            Sort(array, p0 + 1, p1 - 1);
            Sort(array, p1 + 1, hi);
        }
    }

    private static (int P0, int P1) Partition<T>(T[] array, int lo, int hi)
        where T : IComparable<T>
    {
        if (array[lo].CompareTo(array[hi]) > 0)
        {
            Swap(array, lo, hi);
        }

        int j = lo + 1;
        int g = hi - 1, k = lo + 1;
        T p = array[lo], q = array[hi];

        while (k <= g)
        {
            if (array[k].CompareTo(p) < 0)
            {
                Swap(array, k, j);
                j++;
            }
            else if (array[k].CompareTo(q) >= 0)
            {
                while ((array[g].CompareTo(q) > 0) && (k < g))
                {
                    g--;
                }

                Swap(array, k, g);
                g--;

                if (array[k].CompareTo(p) < 0)
                {
                    Swap(array, k, j);
                    j++;
                }
            }

            k++;
        }

        j--;
        g++;

        Swap(array, lo, j);
        Swap(array, hi, g);

        return (j, g);
    }

    private static void Swap<T>(T[] array, int i, int j) => (array[j], array[i]) = (array[i], array[j]);
}
