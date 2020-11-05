// <copyright file="CommanLineInterface.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Core
{
    using System;

    /// <summary>
    /// The Fundamentals CLI is a command-line interface for Fundamentals.
    /// </summary>
    internal sealed class CommanLineInterface
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args">The list of command-line arguments.</param>
        private static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',', args));
        }
    }
}
