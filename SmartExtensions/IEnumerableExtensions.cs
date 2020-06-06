using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartExtensions
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Calculates the sum of the given timeSpans.
        /// </summary>
        public static TimeSpan Sum(this IEnumerable<TimeSpan> timeSpans)
        {
            TimeSpan sumTillNowTimeSpan = TimeSpan.Zero;

            foreach (TimeSpan timeSpan in timeSpans)
            {
                sumTillNowTimeSpan += timeSpan;
            }

            return sumTillNowTimeSpan;
        }

        /// <summary>
        /// Determines whether a collection is null or has no elements without having to enumerate the entire collection to get a count.  Uses LINQ.
        /// </summary>
        /// <typeparam name="T">The item type.</typeparam>
        /// <param name="items">The items.</param>
        /// <returns>
        /// <c>true</c> if this list is null or empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> items)
        {
            return items == null || !items.Any();
        }

        /// <summary>
        /// Executes provided action on each item of the Enumerable
        /// </summary>
        /// <param name="act">The action to perform.</param>
        /// <returns>
        /// Returns the IEnumerable (useful in chaining commands)
        /// </returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> enumerable, Action<T> act)
        {
            foreach (var item in enumerable)
            {
                act(item);
            }

            return enumerable;
        }
    }
}