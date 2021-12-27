// <copyright file="ReadOnlyCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

using System.Linq;
using System = System.Collections.ObjectModel;

/// <summary>
/// Represents an read only collection.
/// </summary>
/// <typeparam name="TItem">The type of elements in the collection.</typeparam>
public class ReadOnlyCollection<TItem> : ICollection<System.ReadOnlyCollection<TItem>, TItem>
{
    /// <inheritdoc />
    public TItem? Find(System.ReadOnlyCollection<TItem> collection, TItem value) =>
        collection.First(item => item!.Equals(value));
}
