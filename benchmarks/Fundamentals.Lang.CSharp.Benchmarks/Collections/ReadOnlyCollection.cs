// <copyright file="ReadOnlyCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.Collections;

using System = System.Collections.ObjectModel;

/// <summary>
/// Represents a benchmark for <see cref="CSharp.Collections.ReadOnlyCollection{TItem}"/>.
/// </summary>
public class ReadOnlyCollection : Collection<CSharp.Collections.ReadOnlyCollection<string>, System.ReadOnlyCollection<string>>
{
    /// <inheritdoc />
    public override System.ReadOnlyCollection<string> SmallCollection { get; set; } = new System.ReadOnlyCollection<string>(new List<string>());
}
