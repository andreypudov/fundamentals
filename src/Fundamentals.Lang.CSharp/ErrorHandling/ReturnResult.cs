// <copyright file="ReturnResult.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.ErrorHandling
{
    /// <summary>
    /// Represents an error handling using result.
    /// </summary>
    public class ReturnResult : IErrorHandler
    {
        private const int ExitFailure = -1;

        /// <inheritdoc />
        public void HandleError()
        {
            var result = DummyMethod();
        }

        private static Result DummyMethod()
        {
            return Result.Fail("The error description.");
        }
    }
}