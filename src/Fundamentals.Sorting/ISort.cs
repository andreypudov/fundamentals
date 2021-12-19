// <copyright file="ISort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting;

/// <summary>
/// Exposes a method that sorts the elements in a one-dimensional array.
/// </summary>
public interface ISort
{
    /// <summary>
    /// Sorts the elements in an entire <see cref="Array"/> using the <see cref="IComparable{T}"/>
    /// generic interface implementation of each element of the Array.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the array.</typeparam>
    /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to sort.</param>
    /// <exception cref="ArgumentNullException"><c>array</c> is <c>null</c>.</exception>
    /// <exception cref="InvalidOperationException">One or more elements in <c>array</c> do not implement the <see cref="IComparable{T}"/> generic interface.</exception>
    void Sort<T>(T[] array)
        where T : IComparable<T>;
}
