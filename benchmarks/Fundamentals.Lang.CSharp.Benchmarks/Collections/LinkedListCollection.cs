// <copyright file="LinkedListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.Collections;

/// <summary>
/// Represents a benchmark for <see cref="CSharp.Collections.LinkedListCollection{TItem}"/>.
/// </summary>
public class LinkedListCollection : Collection<CSharp.Collections.LinkedListCollection<string>, LinkedList<string>>
{
    /// <inheritdoc />
    public override LinkedList<string> SmallCollection => new(SmallData);

    /// <inheritdoc />
    public override LinkedList<string> LargeCollection => new(LargeData);
}
