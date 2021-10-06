using System;

namespace TelenorTest.ExternalApi.V1.Infrastructure.Errors
{
	public class InvalidRequestException : Exception
	{
		/// <summary>
		///     Initializes a new instance of a class.
		/// </summary>
		/// <param name="message">A message that descibes the exception.</param>
		public InvalidRequestException(string message)
			: base(message)
		{
		}

		/// <summary>
		///     Initializes a new instance of a class.
		/// </summary>
		/// <param name="message">A message that descibes the exception.</param>
		/// <param name="innerException">An original exception.</param>
		public InvalidRequestException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
