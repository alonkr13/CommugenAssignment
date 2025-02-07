public static class UserRouter
{
    public static RouteGroupBuilder MapUserRoutes(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/user");
        group.MapGet("/", UserHandler.GetUserHome);
        group.MapGet("/test", UserHandler.GetTestHome);
        return group;
    }
}