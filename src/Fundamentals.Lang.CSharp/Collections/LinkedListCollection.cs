// <copyright file="LinkedListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

/// <summary>
/// Represents an immutable list collection.
/// </summary>
/// <typeparam name="TItem">The type of elements in the coolection.</typeparam>
public class LinkedListCollection<TItem> : ICollection<LinkedList<TItem>, TItem>
{
    /// <inheritdoc />
    public LinkedList<TItem> Add(LinkedList<TItem> collection, TItem item)
    {
        collection.AddLast(item);
        return collection;
    }

    /// <inheritdoc />
    public LinkedList<TItem> Remove(LinkedList<TItem> collection, TItem item)
    {
        collection.Remove(item);
        return collection;
    }
}
