using ACTIONCONTROLLERS.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HomeControllers}/{action=Index}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HomeControllers}/{action=Delete}"
);

app.MapControllerRoute(
    name: "default",
    pattern:"{controller=HomeControllers}/{action=Edit}"
);

app.Run();
