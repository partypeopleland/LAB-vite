var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();


var app = builder.Build();

// TODO:check env for dev
// app.UseCors(b => b.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseRouting();
app.UseEndpoints(e => e.MapDefaultControllerRoute());

app.UseSpa(b =>
{
    // TODO:check env for dev
    b.UseProxyToSpaDevelopmentServer("http://localhost:5173/");
});


app.Run();