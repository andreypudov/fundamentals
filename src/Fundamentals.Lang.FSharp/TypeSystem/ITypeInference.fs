// <copyright file="ITypeInference.fs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.FSharp.TypeSystem

type ITypeInference =
    abstract member PrimitiveSpecified : int -> int
    abstract member PrimitiveInferenced : int -> int
    abstract member ComplexSpecified : string -> string
    abstract member ComplexInferenced : string -> string