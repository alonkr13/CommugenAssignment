public static class AdminRouter
{
    public static RouteGroupBuilder MapAdminRoutes(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/admin");
        group.MapGet("/add", AdminHandler.AddForm );

        group.MapGet("/returnform/{id}", (int id) => AdminHandler.ReturnForm(id));
        
        group.MapGet("/returnforms", () => AdminHandler.ReturnForms());
        
        group.MapGet("/removeform/{id}", (int id) => AdminHandler.RemoveForm(id));

        return group;
    }
}