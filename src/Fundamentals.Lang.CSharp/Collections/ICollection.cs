﻿// <copyright file="ICollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

/// <summary>
/// Exposes a data structure that implements the collection.
/// </summary>
/// <typeparam name="TCollection">The type of the coolection.</typeparam>
/// <typeparam name="TItem">The type of elements in the coolection.</typeparam>
public interface ICollection<TCollection, TItem>
{
    /// <summary>
    /// Finds the first node that contains the specified value.
    /// </summary>
    /// <param name="collection">The instance of the collection.</param>
    /// <param name="value">The value to locate in the collection.</param>
    /// <returns>The first node/value that contains the specified value, if found; otherwise, null.</returns>
    TItem? Find(TCollection collection, TItem value);

    /// <summary>
    /// Filters a sequence of values based on a predicate.
    /// </summary>
    /// <param name="collection">The collection to filter.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <returns>An IEnumerable{TItem} that contains elements from the input sequence that satisfy the condition.</returns>
    public IEnumerable<TItem> Filter(TCollection collection, Func<TItem, bool> predicate);
}
