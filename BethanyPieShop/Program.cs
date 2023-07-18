using BethanyPieShop.Model;
using BethanyPieShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp=>ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();



builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BethanyPieShopDbContext>(options => { 
    options.UseSqlServer(
    builder.Configuration["ConnectionStrings:BethanyPieShopDbcontextConnection"]); 
});



var app = builder.Build();

app.UseStaticFiles();
app.UseSession();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapDefaultControllerRoute();
DbInitializer.Seed(app);
app.Run();
