// <copyright file="CommanLineInterface.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Core
{
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Jobs;
    using BenchmarkDotNet.Running;

    /// <summary>
    /// The Fundamentals CLI is a command-line interface for Fundamentals.
    /// </summary>
    internal static class CommanLineInterface
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        private static void Main(/* string[] args */) =>
            BenchmarkRunner
                .Run(
                    typeof(Sorting.Benchmarks.Sort<>).Assembly,
                    ManualConfig.Create(DefaultConfig.Instance)
                        .WithOption(ConfigOptions.JoinSummary, true)
                        .WithOption(ConfigOptions.DisableLogFile, true));
    }
}