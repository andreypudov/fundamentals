// <copyright file="SystemArraySort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    /// <summary>
    /// Represents a benchmark for <see cref="System.Array.Sort{T}(T[])"/>.
    /// </summary>
    public class SystemArraySort : Sort<Sorting.SystemArraySort>
    {
        // Intentionally left bank
    }
}