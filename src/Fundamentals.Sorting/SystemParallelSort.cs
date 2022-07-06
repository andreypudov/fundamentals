// <copyright file="SystemParallelSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting;

/// <summary>
/// Represents a <see cref="Array.Sort{T}(T[])"/> implementation.
/// </summary>
public class SystemParallelSort : ISort
{
    /// <inheritdoc />
    public void Sort<T>(T[] array)
        where T : IComparable<T>
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        using var sorted = array.AsParallel().OrderBy(e => e).GetEnumerator();
        int index = 0;
        while (sorted.MoveNext())
        {
            array[index] = sorted.Current;
            index++;
        }
    }
}