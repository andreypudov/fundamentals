﻿// <copyright file="ListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.Collections;

/// <summary>
/// Represents a benchmark for <see cref="CSharp.Collections.ListCollection{TItem}"/>.
/// </summary>
public class ListCollection : Collection<CSharp.Collections.ListCollection<string>, List<string>>
{
    /// <inheritdoc />
    public override List<string> SmallCollection => new(SmallData);

    /// <inheritdoc />
    public override List<string> LargeCollection => new(LargeData);
}
