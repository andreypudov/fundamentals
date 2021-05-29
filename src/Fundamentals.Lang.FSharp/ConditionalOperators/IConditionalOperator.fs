// <copyright file="IConditionalOperator.fs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.FSharp.ConditionalOperators

open Fundamentals.Lang.FSharp

type IConditionalOperator =
    abstract member GetName : Color -> string