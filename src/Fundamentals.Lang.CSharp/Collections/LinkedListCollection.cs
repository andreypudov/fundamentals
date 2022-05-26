// <copyright file="LinkedListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

/// <summary>
/// Represents an immutable list collection.
/// </summary>
/// <typeparam name="TItem">The type of elements in the collection.</typeparam>
public class LinkedListCollection<TItem> : ICollection<LinkedList<TItem>, TItem>
{
    /// <inheritdoc />
    public LinkedList<TItem> Build(TItem[] collection) =>
        new(collection);

    /// <inheritdoc />
    public LinkedList<TItem> Add(LinkedList<TItem> collection, TItem value)
    {
        collection.AddLast(value);
        return collection;
    }

    /// <inheritdoc />
    public TItem? Find(LinkedList<TItem> collection, TItem value) =>
        collection.First(item => item!.Equals(value));

    /// <inheritdoc />
    public IEnumerable<TItem> Filter(LinkedList<TItem> collection, Func<TItem, bool> predicate) =>
        collection.Where(predicate);
}
