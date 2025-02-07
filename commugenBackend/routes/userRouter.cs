public static class UserRouter
{
    public static RouteGroupBuilder MapUserRoutes(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/user");
        
        group.MapGet("/changefield/{fieldID}/{name}", (int fieldID, string name) => UserHandler.ChangeField(fieldID,name));

        group.MapGet("/removefield/{id}", (int id) => UserHandler.RemoveField(id));

        group.MapGet("/getfield/{id}", (int id) => UserHandler.GetField(id));

        group.MapGet("/addfield/{type}/{name}/{formID}", (string type, string name, int formID) =>
            UserHandler.AddField(type, name, formID));

        group.MapGet("/getfields", () => UserHandler.GetFields());

        return group;
    }
}