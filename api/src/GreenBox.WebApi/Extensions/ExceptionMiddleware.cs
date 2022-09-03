using System.Net;
namespace GreenBox.Api.Extensions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _log;
        public ExceptionMiddleware(RequestDelegate next, ILoggerFactory log)
        {
            _next = next;
            _log = log.CreateLogger("Logger");
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                HandleExceptionAsync(httpContext, e);
            }
        }

        private void HandleExceptionAsync(HttpContext context, Exception exception)
        {
            _log.LogError($"Error: {exception.Message}");
            _log.LogError($"Stack: {exception.StackTrace}");
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        }

    }
}
