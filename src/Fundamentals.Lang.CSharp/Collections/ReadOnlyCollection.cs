// <copyright file="ReadOnlyCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

using System.Linq;
using System = System.Collections.ObjectModel;

/// <summary>
/// Represents an read only collection.
/// </summary>
/// <typeparam name="TItem">The type of elements in the coolection.</typeparam>
public class ReadOnlyCollection<TItem> : ICollection<System.ReadOnlyCollection<TItem>, TItem>
{
    /// <inheritdoc />
    public System.ReadOnlyCollection<TItem> Add(System.ReadOnlyCollection<TItem> collection, TItem item) =>
        collection.Concat(new[] { item }).ToList().AsReadOnly();

    /// <inheritdoc />
    public System.ReadOnlyCollection<TItem> Remove(System.ReadOnlyCollection<TItem> collection, TItem item) =>
        collection.Except(new[] { item }).ToList().AsReadOnly();
}
