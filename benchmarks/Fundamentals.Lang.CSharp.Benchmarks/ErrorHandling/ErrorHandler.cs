// <copyright file="ErrorHandler.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.ErrorHandling;

using BenchmarkDotNet.Attributes;
using Fundamentals.Lang.CSharp.ErrorHandling;

/// <summary>
/// Represents a base benchmark for conditional operators./>.
/// </summary>
/// <typeparam name="T">The type of the <see cref="IErrorHandler"/> implementation.</typeparam>
public abstract class ErrorHandler<T>
    where T : IErrorHandler, new()
{
    private readonly T instance = new T();

    /// <summary>
    /// Represents a general benchmark.
    /// </summary>
    [Benchmark]
    public void General() =>
        this.instance.HandleError();
}
