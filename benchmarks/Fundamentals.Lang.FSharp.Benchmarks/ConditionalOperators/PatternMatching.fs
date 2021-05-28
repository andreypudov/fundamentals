// <copyright file="PatternMatching.fs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.ConditionalOperators

module PatternMatching =

    open Fundamentals.Lang.FSharp.Color
    open Fundamentals.Lang.FSharp.ConditionalOperators.PatternMatching
    open BenchmarkDotNet.Attributes;

    [<Benchmark>]
    [<Arguments(Color.Purple)>]
    let ``Should return ``(color, name) =
        GetName color |> should equal name