// <copyright file="ListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Tests.Collections;

using NUnit.Framework;

/// <summary>
/// Represents a test case for <see cref="CSharp.Collections.ListCollection{TItem}"/>.
/// </summary>
[TestFixture]
public class ListCollection : Collection<CSharp.Collections.ListCollection<string>, List<string>>
{
    // Intentionally left bank
}