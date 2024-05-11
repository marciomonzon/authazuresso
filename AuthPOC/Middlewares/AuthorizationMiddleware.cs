
namespace AuthPOC.Middlewares
{
    public class AuthorizationMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var azureEmailUserAuthenticated = context.User?.Identity?.Name;
            

            await next(context);
        }
    }
}
