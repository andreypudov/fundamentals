// <copyright file="TypeInference.fs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.FSharp.TypeSystem

type ParametersTypeInference() =
   interface ITypeInference with
      member this.PrimitiveSpecified (value: int) : int = value |> this.PrimitiveSpecifiedImpl
      member this.PrimitiveInferenced value = value |> this.PrimitiveInferencedImpl

      member this.ComplexSpecified (value: string) : string = value |> this.ComplexSpecifiedImpl
      member this.ComplexInferenced value = value |> this.ComplexInferencedImpl

   member private this.PrimitiveSpecifiedImpl (value: int) : int = value
   member private this.PrimitiveInferencedImpl value = value

   member private this.ComplexSpecifiedImpl (value: string) : string = value
   member private this.ComplexInferencedImpl value = value