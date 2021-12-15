// <copyright file="ConditionalOperator.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Tests.ConditionalOperators;

using Fundamentals.Lang.CSharp.ConditionalOperators;
using NUnit.Framework;

/// <summary>
/// Represents a base test fixture for <see cref="IConditionalOperator"/>.
/// </summary>
/// <typeparam name="T">The type of the <see cref="IConditionalOperator"/> implementation.</typeparam>
[TestFixture]
public abstract class ConditionalOperator<T>
    where T : IConditionalOperator, new()
{
    /// <summary>
    /// Represents a positive test case for the conditional operator.
    /// </summary>
    /// <param name="color">The instance of the color.</param>
    /// <param name="name">The name of the color.</param>
    [TestCase(Color.White, "White")]
    [TestCase(Color.Silver, "Silver")]
    [TestCase(Color.Gray, "Gray")]
    [TestCase(Color.Black, "Black")]
    [TestCase(Color.Red, "Red")]
    [TestCase(Color.Maroon, "Maroon")]
    [TestCase(Color.Yellow, "Yellow")]
    [TestCase(Color.Olive, "Olive")]
    [TestCase(Color.Lime, "Lime")]
    [TestCase(Color.Green, "Green")]
    [TestCase(Color.Aqua, "Aqua")]
    [TestCase(Color.Teal, "Teal")]
    [TestCase(Color.Blue, "Blue")]
    [TestCase(Color.Navy, "Navy")]
    [TestCase(Color.Fuchsia, "Fuchsia")]
    [TestCase(Color.Purple, "Purple")]
    public void ConditionalOperator_PositiveGetName_ReturnsName(Color color, string name) =>
        Assert.AreEqual(name, new T().GetName(color));
}
