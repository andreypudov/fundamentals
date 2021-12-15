// <copyright file="SystemArraySort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting;

/// <summary>
/// Represents a <see cref="Array.Sort{T}(T[])"/> implementation.
/// </summary>
public class SystemArraySort : ISort
{
    /// <inheritdoc />
    public void Sort<T>(T[] array)
        where T : IComparable<T>
    {
        Array.Sort(array);
    }
}
