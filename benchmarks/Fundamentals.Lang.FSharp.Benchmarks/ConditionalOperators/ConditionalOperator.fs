// <copyright file="ConditionalOperator.fs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.FSharp.Benchmarks.ConditionalOperators

open Fundamentals.Lang.FSharp
open Fundamentals.Lang.FSharp.ConditionalOperators
open BenchmarkDotNet.Attributes

[<AbstractClass>]
type ConditionalOperator<'T when 'T :> IConditionalOperator and 'T : (new : unit -> 'T)>() =
    let operator = new 'T()

    [<Benchmark>]
    [<Arguments(Color.White)>]
    member this.First color = color |> operator.GetName

    [<Benchmark>]
    [<Arguments(Color.Purple)>]
    member this.Last color = color |> operator.GetName

    [<Benchmark>]    [<Arguments(Color.Black)>]
    member this.MinValue color = color |> operator.GetName