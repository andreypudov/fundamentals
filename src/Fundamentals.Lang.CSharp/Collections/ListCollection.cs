// <copyright file="ListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

/// <summary>
/// Represents an immutable list collection.
/// </summary>
/// <typeparam name="TItem">The type of elements in the coolection.</typeparam>
public class ListCollection<TItem> : ICollection<List<TItem>, TItem>
{
    /// <inheritdoc />
    public List<TItem> Add(List<TItem> collection, TItem item)
    {
        collection.Add(item);
        return collection;
    }

    /// <inheritdoc />
    public List<TItem> Remove(List<TItem> collection, TItem item)
    {
        collection.Remove(item);
        return collection;
    }
}