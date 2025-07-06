using MVCProject.Data;
using Microsoft.EntityFrameworkCore;
using MVCProject.Models;

var builder = WebApplication.CreateBuilder(args);



// ✅ Register services BEFORE builder.Build()
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// ✅ Optional: Seed database (you can uncomment this if needed)

// ✅ Configure middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// ✅ Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Expenses}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    if (!context.Categories.Any())
    {
        context.Categories.AddRange(
            new Category { Name = "Food" },
            new Category { Name = "Transport" },
            new Category { Name = "Utilities" },
            new Category { Name = "Shopping" },
            new Category { Name = "Medical" }
        );

        context.SaveChanges();
    }
}



app.Run();
