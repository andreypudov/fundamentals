// <copyright file="ImmutableListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

using System.Collections.Immutable;

/// <summary>
/// Represents an immutable list collection.
/// </summary>
/// <typeparam name="TItem">The type of elements in the coolection.</typeparam>
public class ImmutableListCollection<TItem> : ICollection<IImmutableList<TItem>, TItem>
{
    /// <inheritdoc />
    public IImmutableList<TItem> Add(IImmutableList<TItem> collection, TItem item) =>
        collection.Add(item);

    /// <inheritdoc />
    public IImmutableList<TItem> Remove(IImmutableList<TItem> collection, TItem item) =>
        collection.Remove(item);
}
