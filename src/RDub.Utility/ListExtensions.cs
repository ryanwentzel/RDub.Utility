using System;
using System.Collections.Generic;
using System.Linq;

namespace RDub.Utility
{
    /// <summary>
    /// Extensions methods that operate on <see cref="IList{T}"/>.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Creates a new <see cref="IList{T}"/> that is a copy of the current instance.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="collection"/>.</typeparam>
        /// <param name="collection">The <see cref="IList{T}"/> to clone.</param>
        /// <returns>An <see cref="IList{T}"/> that is a copy of the current instance.</returns>
        public static IList<T> Clone<T>(this IList<T> collection) where T : ICloneable
        {
            if (collection == null) throw new NullReferenceException();

            var list = collection as List<T>;
            return list != null 
                ? list.ConvertAll(item => (T)item.Clone()) 
                : collection.Select(item => (T)item.Clone()).ToList();
        }
    }
}