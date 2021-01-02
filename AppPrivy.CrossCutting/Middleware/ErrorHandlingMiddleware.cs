using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

using Serilog;

namespace AppPrivy.CrossCutting.Middleware
{
    public class ErrorHandlingMiddleware : IMiddleware
    {
        private readonly ILogger _logger;

        public ErrorHandlingMiddleware(ILogger logger )
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                _logger.Error($"Unexpected error: {ex}");
                await HandleExceptionAsync(context, ex);
            }
        }


        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var json = new
            {
                context.Response.StatusCode,
                Message = "An error occurred whilst processing your request",
                Detailed = exception
            };

            return context.Response.WriteAsync(JsonConvert.SerializeObject(json));

        }


    }
}
