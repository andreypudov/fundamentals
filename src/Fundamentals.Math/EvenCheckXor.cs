// <copyright file="EvenCheckXor.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Math;

/// <summary>
/// Represents an xor implementation for <see cref="IEvenCheck.IsEven(int)"/>.
/// </summary>
public class EvenCheckXor : IEvenCheck
{
    /// <inheritdoc />
    public bool IsEven(int value) => (value ^ 1) == value + 1;
}
