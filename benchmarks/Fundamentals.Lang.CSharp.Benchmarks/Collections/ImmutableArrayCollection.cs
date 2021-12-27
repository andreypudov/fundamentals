// <copyright file="ImmutableArrayCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.Collections;

using System = System.Collections.Immutable;

/// <summary>
/// Represents a benchmark for <see cref="CSharp.Collections.ImmutableArrayCollection{TItem}"/>.
/// </summary>
public class ImmutableArrayCollection : Collection<CSharp.Collections.ImmutableArrayCollection<string>, System.ImmutableArray<string>>
{
    /// <inheritdoc />
    public override System.ImmutableArray<string> SmallCollection => System.ImmutableArray.Create(SmallData);

    /// <inheritdoc />
    public override System.ImmutableArray<string> LargeCollection => System.ImmutableArray.Create(LargeData);
}
