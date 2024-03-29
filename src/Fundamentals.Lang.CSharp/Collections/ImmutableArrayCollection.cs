﻿// <copyright file="ImmutableArrayCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

using System.Collections.Immutable;

/// <summary>
/// Represents an immutable array collection.
/// </summary>
/// <typeparam name="TItem">The type of elements in the collection.</typeparam>
public class ImmutableArrayCollection<TItem> : ICollection<ImmutableArray<TItem>, TItem>
{
    /// <inheritdoc />
    public ImmutableArray<TItem> Build(TItem[] collection) =>
        ImmutableArray.Create(collection);

    /// <inheritdoc />
    public ImmutableArray<TItem> Add(ImmutableArray<TItem> collection, TItem value) =>
        collection.Add(value);

    /// <inheritdoc />
    public TItem? Find(ImmutableArray<TItem> collection, TItem value) =>
        collection.First(item => item!.Equals(value));

    /// <inheritdoc />
    public IEnumerable<TItem> Filter(ImmutableArray<TItem> collection, Func<TItem, bool> predicate) =>
        collection.Where(predicate);
}
