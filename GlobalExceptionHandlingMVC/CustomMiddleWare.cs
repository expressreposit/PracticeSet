using System.Diagnostics;

namespace GlobalExceptionHandlingMVC
{
    public class CustomMiddleWare
    {
        private readonly RequestDelegate _next;
        public CustomMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task Invoke(HttpContext httpContext)
        {
            using var buffer = new MemoryStream();
            var request = httpContext.Request;
            var response = httpContext.Response;

            var stream = response.Body;
            response.Body = buffer;

            await _next(httpContext);

            Debug.WriteLine($"Request content type:  " +
                $"{httpContext.Request.Headers["Accept"]} " +
                $"{System.Environment.NewLine} " +
                $"Request path: {request.Path} {System.Environment.NewLine} " +
                $"Response type: {response.ContentType} {System.Environment.NewLine} " +
                $"Response length: {response.ContentLength ?? buffer.Length}");
            
            buffer.Position = 0;

            await buffer.CopyToAsync(stream);
        }
    }

    //Create Extention Method.
    public static class CustomMiddlewareExtention
    {
        public static IApplicationBuilder UseCustomMiddleWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleWare>();
        }
    }
}
