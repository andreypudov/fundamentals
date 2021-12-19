// <copyright file="ReadOnlyCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.Collections;

using System = System.Collections.ObjectModel;

/// <summary>
/// Represents a benchmark for <see cref="CSharp.Collections.ReadOnlyCollection{TItem}"/>.
/// </summary>
/// <typeparam name="TItem">The type of elements in the coolection.</typeparam>
public class ReadOnlyCollection<TItem> : Collection<CSharp.Collections.ReadOnlyCollection<TItem>, System.ReadOnlyCollection<TItem>, TItem>
{
    // Intentionally left bank

    /// <inheritdoc />
    public override System.ReadOnlyCollection<TItem> SmallCollection { get; set; } = new System.ReadOnlyCollection<TItem>(new List<TItem>());
}
