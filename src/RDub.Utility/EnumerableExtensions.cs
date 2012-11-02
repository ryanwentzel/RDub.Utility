using System;
using System.Collections.Generic;

namespace RDub.Utility
{
    /// <summary>
    /// Extension methods that operate on enumerable collections.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Performs the specified action on each element of the <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/></typeparam>
        /// <param name="source">An <see cref="IEnumerable{T}"/> containing items on which to perform an action.</param>
        /// <param name="action">The <see cref="Action{T}"/> delegate to perform on each element of the <see cref="IEnumerable{T}"/>.</param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null) throw new NullReferenceException();
            if (action == null) throw new ArgumentNullException("action");

            foreach (var item in source)
            {
                action(item);
            }
        }
    }
}
