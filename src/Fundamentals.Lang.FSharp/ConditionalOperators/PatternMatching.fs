// <copyright file="PatternMatching.fs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.FSharp.ConditionalOperators

module PatternMatching =

    open Fundamentals.Lang.FSharp.Color

    let GetName color =
        match color with
        | Color.White -> "White"
        | Color.Silver -> "Silver"
        | Color.Gray -> "Gray"
        | Color.Black -> "Black"
        | Color.Red -> "Red"
        | Color.Maroon -> "Maroon"
        | Color.Yellow -> "Yellow"
        | Color.Olive -> "Olive"
        | Color.Lime -> "Lime"
        | Color.Green -> "Green"
        | Color.Aqua -> "Aqua"
        | Color.Teal -> "Teal"
        | Color.Blue -> "Blue"
        | Color.Navy -> "Navy"
        | Color.Fuchsia -> "Fuchsia"
        | Color.Purple -> "Purple"
        | _ -> "None"