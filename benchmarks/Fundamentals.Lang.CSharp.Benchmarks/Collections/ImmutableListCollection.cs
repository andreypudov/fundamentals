// <copyright file="ImmutableListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.Collections;

using System = System.Collections.Immutable;

/// <summary>
/// Represents a benchmark for <see cref="CSharp.Collections.ImmutableListCollection{TItem}"/>.
/// </summary>
public class ImmutableListCollection : Collection<CSharp.Collections.ImmutableListCollection<string>, System.ImmutableList<string>>
{
    /// <inheritdoc />
    public override System.ImmutableList<string> EmptyCollection => System.ImmutableList.Create(EmptyData);

    /// <inheritdoc />
    public override System.ImmutableList<string> SmallCollection => System.ImmutableList.Create(SmallData);

    /// <inheritdoc />
    public override System.ImmutableList<string> LargeCollection => System.ImmutableList.Create(LargeData);
}
