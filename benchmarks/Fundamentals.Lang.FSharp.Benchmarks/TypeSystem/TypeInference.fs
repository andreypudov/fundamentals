// <copyright file="TypeInference.fs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.FSharp.Benchmarks.TypeSystem

open Fundamentals.Lang.FSharp.TypeSystem
open BenchmarkDotNet.Attributes

[<AbstractClass>]
type TypeInference<'T when 'T :> ITypeInference and 'T : (new : unit -> 'T)>() =
    let instance = new 'T()

    [<Benchmark>]
    [<Arguments(42)>]
    member this.PrimitiveSpecified value = value |> instance.PrimitiveSpecified

    [<Benchmark>]
    [<Arguments(42)>]
    member this.PrimitiveInferenced value = value |> instance.PrimitiveInferenced

    [<Benchmark>]
    [<Arguments("forty-two")>]
    member this.ComplexSpecified value = value |> instance.ComplexSpecified

    [<Benchmark>]
    [<Arguments("forty-two")>]
    member this.ComplexInferenced value = value |> instance.ComplexInferenced