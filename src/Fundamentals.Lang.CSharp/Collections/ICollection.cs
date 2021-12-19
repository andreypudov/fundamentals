// <copyright file="ICollection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Collections;

/// <summary>
/// Exposes a data structure that implements the collection.
/// </summary>
/// <typeparam name="TCollection">The type of the coolection.</typeparam>
/// <typeparam name="TItem">The type of elements in the coolection.</typeparam>
public interface ICollection<TCollection, TItem>
{
    /// <summary>
    /// Adds an object to the end of the collection.
    /// </summary>
    /// <param name="collection">The instance of the collection.</param>
    /// <param name="item">The object to be added to the end of the collection. The value can be <c>null</c> for reference types.</param>
    /// <returns>The new collection with the object added.</returns>
    TCollection Add(TCollection collection, TItem item);

    /// <summary>
    /// Removes the first occurrence of a specific object from the collection.
    /// </summary>
    /// <param name="collection">The instance of the collection.</param>
    /// <param name="item">The object to remove from the collection The value can be <c>null</c> for reference types.</param>
    /// <returns>The new collection with the object removed.</returns>
    TCollection Remove(TCollection collection, TItem item);
}
