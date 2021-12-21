// <copyright file="LinkedListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.Collections;

/// <summary>
/// Represents a benchmark for <see cref="CSharp.Collections.LinkedListCollection{TItem}"/>.
/// </summary>
public class LinkedListCollection : Collection<CSharp.Collections.LinkedListCollection<string>, LinkedList<string>>
{
    private static readonly string[] Empty = Array.Empty<string>();

    /// <inheritdoc />
    public override LinkedList<string> EmptyCollection => new LinkedList<string>(Empty);
}
