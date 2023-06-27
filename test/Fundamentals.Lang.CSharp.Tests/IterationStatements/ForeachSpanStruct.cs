// <copyright file="ForeachSpanStruct.cs" company="Andrey Pudov">
// Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Tests.IterationStatements;

using NUnit.Framework;

/// <summary>
/// Represents a test class for <see cref="Fundamentals.Lang.CSharp.IterationStatements.ForeachSpanStruct"/>.
/// </summary>
[TestFixture]
public class ForeachSpanStruct : IterationStatement<Fundamentals.Lang.CSharp.IterationStatements.ForeachSpanStruct>
{
    /// <inheritdoc cref="ForeachSpanStruct" />
    [Test]
    [Ignore("Not supported for arrays")]
    public override void IterationStatement_PositiveSumOfArray_ReturnsSum(
        [Values(null)] int[] numbers,
        [Values(0)] int sum) => throw new NotImplementedException();
}