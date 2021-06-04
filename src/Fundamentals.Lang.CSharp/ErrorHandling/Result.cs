// <copyright file="Result.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.ErrorHandling
{
    /// <summary>
    /// Represents the result of the execution.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Result"/> class.
        /// </summary>
        /// <param name="success">The result flag of operation.</param>
        /// <param name="error">The text of the error.</param>
        protected Result(bool success, string error)
        {
            this.Success = success;
            this.Error = error;
        }

        /// <summary>
        /// Gets a value indicating whether operation completed with success status.
        /// </summary>
        public bool Success { get; private set; }

        /// <summary>
        /// Gets a value indicating whether operation completed with failure status.
        /// </summary>
        public bool Failure => !this.Success;

        /// <summary>
        /// Gets the text of the error.
        /// </summary>
        public string Error { get; private set; }

        /// <summary>
        /// Constructs the instance of the <see cref="Result"/> with failure status.
        /// </summary>
        /// <param name="message">The text of the error.</param>
        /// <returns>The new instance of the result.</returns>
        public static Result Fail(string message)
        {
            return new Result(false, message);
        }

        /// <summary>
        /// Constructs the instance of the <see cref="Result"/> with success status.
        /// </summary>
        /// <returns>The new instance of the result.</returns>
        public static Result Ok()
        {
            return new Result(true, string.Empty);
        }
    }
}