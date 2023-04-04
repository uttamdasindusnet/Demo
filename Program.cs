var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
<<<<<<< HEAD

app.UseRouting()
    .UseEndpoints(endpoints =>)
    .UseStaticFiles();
=======
app.UseRouting();
>>>>>>> Uttam
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
<<<<<<< HEAD
app.MapControllerRoute(
    name: "KOMAL",
    pattern: "{controller=Home}/{action=Index}/{id}");


=======
    name: "default",
pattern:  "{controller=House}/{action=Index}/{id?}");
>>>>>>> Uttam
app.Run();
