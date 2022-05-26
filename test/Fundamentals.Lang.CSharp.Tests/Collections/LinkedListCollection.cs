// <copyright file="LinkedListCollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Tests.Collections;

using NUnit.Framework;

/// <summary>
/// Represents a test case for <see cref="CSharp.Collections.LinkedListCollection{TItem}"/>.
/// </summary>
[TestFixture]
public class LinkedListCollection : Collection<CSharp.Collections.LinkedListCollection<string>, LinkedList<string>>
{
    // Intentionally left bank
}