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
    public TItem? Find(LinkedList<TItem> collection, TItem value) =>
        collection.First(item => item!.Equals(value));
}
