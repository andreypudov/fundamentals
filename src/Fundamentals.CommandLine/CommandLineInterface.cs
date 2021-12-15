// <copyright file="CommandLineInterface.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

BenchmarkSwitcher
    .FromAssemblies(
    new[]
    {
            typeof(Fundamentals.Lang.CSharp.Benchmarks.ConditionalOperators.ConditionalOperator<>).Assembly,
            typeof(Fundamentals.Lang.CSharp.Benchmarks.ErrorHandling.ErrorHandler<>).Assembly,
            typeof(Fundamentals.Lang.FSharp.Benchmarks.TypeSystem.TypeInference<>).Assembly,
            typeof(Fundamentals.Lang.FSharp.Benchmarks.ConditionalOperators.ConditionalOperator<>).Assembly,
            typeof(Fundamentals.Math.Benchmarks.Fibonacci<>).Assembly,
            typeof(Fundamentals.Sorting.Benchmarks.Sort<>).Assembly,
    })
    .Run(
        args,
        ManualConfig.Create(DefaultConfig.Instance)
            .WithOption(ConfigOptions.JoinSummary, true)
            .WithOption(ConfigOptions.DisableLogFile, true));
