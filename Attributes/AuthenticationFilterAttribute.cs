using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Filters;
using DotnetAndDocker.Exceptions;
using System.Net;

namespace DotnetAndDocker.Attributes
{
    public class AuthenticationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string authKey = context.HttpContext.Request
                    .Headers["Authorization"].SingleOrDefault();

            if (string.IsNullOrWhiteSpace(authKey))
                throw new HttpException(HttpStatusCode.Unauthorized);
        }
    }
}