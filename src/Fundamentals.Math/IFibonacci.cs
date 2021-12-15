// <copyright file="IFibonacci.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Math;

using System.Numerics;

/// <summary>
/// Exposes a method that returns the Fibonacci number at the given position.
/// </summary>
public interface IFibonacci
{
    /// <summary>
    /// Returns the Fibonacci number at the given position.
    /// </summary>
    /// <param name="position">The position of the number.</param>
    /// <returns>The Fibonacci number at the given position.</returns>
    BigInteger Fibonacci(int position);
}
