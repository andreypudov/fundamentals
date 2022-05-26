// <copyright file="ImmutableArrayCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Tests.Collections;

using NUnit.Framework;
using System = System.Collections.Immutable;

/// <summary>
/// Represents a test case for <see cref="CSharp.Collections.ImmutableArrayCollection{TItem}"/>.
/// </summary>
[TestFixture]
public class ImmutableArrayCollection : Collection<CSharp.Collections.ImmutableArrayCollection<string>, System.ImmutableArray<string>>
{
    // Intentionally left bank
}