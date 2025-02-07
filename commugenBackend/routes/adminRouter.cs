public static class AdminRouter
{
    public static RouteGroupBuilder MapAdminRoutes(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/admin");
        group.MapGet("/add/{creatorUserID}/{name}", (int creatorUserID,string name) => AdminHandler.AddForm( creatorUserID, name));

        group.MapGet("/getform/{id}", (int id) => AdminHandler.GetForm(id));
        
        group.MapGet("/getforms", () => AdminHandler.GetForms());
        
        group.MapGet("/removeform/{id}", (int id) => AdminHandler.RemoveForm(id));

        return group;
    }
}