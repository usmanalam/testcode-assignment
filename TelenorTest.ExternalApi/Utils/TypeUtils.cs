using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelenorTest.ExternalApi.V1.Utils
{
	public static class TypeUtils
	{
		/// <summary>
		///     Iterates for each item in the specified collection.
		/// </summary>
		/// <typeparam name="T">A type of an item.</typeparam>
		/// <param name="collection">A collection of items.</param>
		/// <param name="actionMethod">An action method that is executed for each item.</param>
		public static void ForEach<T>(this IEnumerable<T> collection, Action<T> actionMethod)
		{
			foreach (T item in collection)
			{
				actionMethod(item);
			}
		}
	}
}
