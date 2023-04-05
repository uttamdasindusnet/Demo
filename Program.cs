var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
 // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts. uttam das komal
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
    pattern: "{controller=komal}/{action=Index}/{id}") // changed by komal 16:47

app.Run();
// komal changed in the program.cs 


