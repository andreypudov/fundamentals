// <copyright file="PatternMatching.fs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Tests.ConditionalOperators

module PatternMatching =

    open Fundamentals.Lang.FSharp
    open Fundamentals.Lang.FSharp.Color
    open Fundamentals.Lang.FSharp.ConditionalOperators.PatternMatching
    open NUnit.Framework
    open FsUnit

    [<TestCase(Color.White, "White")>]
    [<TestCase(Color.Silver, "Silver")>]
    [<TestCase(Color.Gray, "Gray")>]
    [<TestCase(Color.Black, "Black")>]
    [<TestCase(Color.Red, "Red")>]
    [<TestCase(Color.Maroon, "Maroon")>]
    [<TestCase(Color.Yellow, "Yellow")>]
    [<TestCase(Color.Olive, "Olive")>]
    [<TestCase(Color.Lime, "Lime")>]
    [<TestCase(Color.Green, "Green")>]
    [<TestCase(Color.Aqua, "Aqua")>]
    [<TestCase(Color.Teal, "Teal")>]
    [<TestCase(Color.Blue, "Blue")>]
    [<TestCase(Color.Navy, "Navy")>]
    [<TestCase(Color.Fuchsia, "Fuchsia")>]
    [<TestCase(Color.Purple, "Purple")>]
    let ``Should return ``(color, name) =
        GetName color |> should equal name