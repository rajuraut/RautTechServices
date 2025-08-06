WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // Enables MVC

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection(); // Redirect HTTP to HTTPS — improves security, recommended even in dev
app.UseStaticFiles(); // Enables serving static files (CSS, JS, images) from wwwroot/
app.UseRouting(); // Must-have for MVC or endpoint routing to work
app.UseAuthorization(); // Required only if using [Authorize] or authentication logic

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
