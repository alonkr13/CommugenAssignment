var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

// app baseUrl = "http://localhost:5013"

app.MapAdminRoutes();

app.MapUserRoutes();


app.Run();
