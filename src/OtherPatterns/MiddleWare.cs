namespace Patterns.OtherPatterns;

internal class Middleware
{
    private readonly RequestDelegate _next;
    public Middleware(RequestDelegate next) {
        _next = next;
    }

    public async Task Invoke(HttpContext context) {
        await _next(context);
      }
}

public class HttpContext { }
public delegate Task RequestDelegate(HttpContext context);
    





