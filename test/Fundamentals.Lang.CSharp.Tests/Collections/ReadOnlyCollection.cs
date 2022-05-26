// <copyright file="ReadOnlyCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Tests.Collections;

using System = System.Collections.ObjectModel;
using NUnit.Framework;

/// <summary>
/// Represents a test case for <see cref="CSharp.Collections.ReadOnlyCollection{TItem}"/>.
/// </summary>
[TestFixture]
public class ReadOnlyCollection : Collection<CSharp.Collections.ReadOnlyCollection<string>, System.ReadOnlyCollection<string>>
{
    // Intentionally left bank
}