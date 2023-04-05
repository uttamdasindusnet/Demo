var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();//komal678
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting()
    .UseEndpoints(endpoints =>)
    .UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "KOMAL",
    pattern: "{controller=komal}/{action=Index}/{id}") // changed by uttam678
// changed by uttam678
// changed by uttam678

app.Run();
