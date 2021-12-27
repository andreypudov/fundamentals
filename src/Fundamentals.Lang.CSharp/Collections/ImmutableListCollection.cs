// <copyright file="ImmutableListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

using System.Collections.Immutable;

/// <summary>
/// Represents an immutable list collection.
/// </summary>
/// <typeparam name="TItem">The type of elements in the collection.</typeparam>
public class ImmutableListCollection<TItem> : ICollection<ImmutableList<TItem>, TItem>
{
    /// <inheritdoc />
    public TItem? Find(ImmutableList<TItem> collection, TItem value) =>
        collection.Find(item => item!.Equals(value));
}
