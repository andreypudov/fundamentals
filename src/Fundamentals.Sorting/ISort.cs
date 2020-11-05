// <copyright file="ISort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting
{
    using System;

    /// <summary>
    /// Exposes a method that sorts the elements in a one-dimensional array.
    /// </summary>
    public interface ISort
    {
        /// <summary>
        /// Sorts the elements in an entire <see cref="Array"/> using the <see cref="IComparable{T}"/>
        /// generic interface implementation of each element of the Array.
        /// </summary>
        /// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to sort.</param>
        void Sort<T>(T[] array);
    }
}
