// <copyright file="IEvenCheck.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Math;

/// <summary>
/// Exposes a method that checks if the given number is even.
/// </summary>
public interface IEvenCheck
{
    /// <summary>
    /// Returns true if the provided value is even.
    /// </summary>
    /// <param name="value">The value to check.</param>
    /// <returns>True if the provided value is even, and false otherwise..</returns>
    bool IsEven(int value);
}
