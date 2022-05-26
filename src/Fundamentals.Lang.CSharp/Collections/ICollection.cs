// <copyright file="ICollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

/// <summary>
/// Exposes a data structure that implements the collection.
/// </summary>
/// <typeparam name="TCollection">The type of the collection.</typeparam>
/// <typeparam name="TItem">The type of elements in the collection.</typeparam>
public interface ICollection<TCollection, TItem>
{
    /// <summary>
    /// Builds a new instance of the collection that contains elements copied from the specified array.
    /// </summary>
    /// <param name="collection">The collection whose elements are copied to the new list.</param>
    /// <returns>The new instance of the collection that contains elements copied from the specified array.</returns>
    TCollection Build(TItem[] collection);

    /// <summary>
    /// Adds the specified object to the end of the collection.
    /// </summary>
    /// <param name="collection">The instance of the collection.</param>
    /// <param name="value">The value to add to the collection.</param>
    /// <returns>The instance of the collection with the object added..</returns>
    TCollection Add(TCollection collection, TItem value);

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
