// <copyright file="EvenCheck.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Math.Benchmarks;

using BenchmarkDotNet.Attributes;
using Fundamentals.Math;

/// <summary>
/// Represents a base benchmark for <see cref="IEvenCheck"/>.
/// </summary>
/// <typeparam name="T">The type of the <see cref="IEvenCheck"/> implementation.</typeparam>
public abstract class EvenCheck<T>
    where T : IEvenCheck, new()
{
    private readonly T instance = new T();

    /// <summary>
    /// Represents a general benchmark.
    /// </summary>
    /// <param name="value">The value to check.</param>
    [Benchmark]
    [Arguments(16)]
    public void General(int value) =>
        this.instance.IsEven(value);
}
