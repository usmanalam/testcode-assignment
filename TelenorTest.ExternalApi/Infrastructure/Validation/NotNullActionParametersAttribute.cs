using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Filters;
using TelenorTest.ExternalApi.V1.Infrastructure.Errors;
using TelenorTest.ExternalApi.V1.Utils;

namespace TelenorTest.ExternalApi.V1.Infrastructure.Validation
{
	/// <summary>
	///     Validates an incomming request for an empty argument.
	/// </summary>
	/// <remarks>
	///     It raises an <see cref="InvalidRequestException" /> exception in case if at least one argument is null.
	/// </remarks>
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
	public class NotNullActionParametersAttribute : ActionFilterAttribute
	{
		/// <inheritdoc />
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			base.OnActionExecuting(context);
			List<KeyValuePair<string, object>> corruptedArgs = context.ActionArguments.Where(a => a.Value == null).ToList();
			if (context.ActionArguments.Count < context.ActionDescriptor.Parameters.Count)
			{
				context.ActionDescriptor.Parameters.Where(p => !context.ActionArguments.ContainsKey(p.Name))
					.ForEach(p => corruptedArgs.Add(new KeyValuePair<string, object>(p.Name, null)));
			}

			if (corruptedArgs.Count > 0)
			{
				throw new InvalidRequestException(this.CreateErrorInfo(corruptedArgs));
			}
		}

		private string CreateErrorInfo(List<KeyValuePair<string, object>> corruptedArgs)
		{
			List<string> messageBuilder = new List<string>();
			corruptedArgs.ForEach(a => messageBuilder.Add(a.Key));
			return string.Format("Looks up a localized string similar to Arguments are not fully provided: {0}", string.Join(',', messageBuilder));
		}

		
	}
}
