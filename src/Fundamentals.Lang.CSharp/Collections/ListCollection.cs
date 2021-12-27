// <copyright file="ListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

/// <summary>
/// Represents an immutable list collection.
/// </summary>
/// <typeparam name="TItem">The type of elements in the collection.</typeparam>
public class ListCollection<TItem> : ICollection<List<TItem>, TItem>
{
    /// <inheritdoc />
    public TItem? Find(List<TItem> collection, TItem value) =>
        collection.Find(item => item!.Equals(value));
}