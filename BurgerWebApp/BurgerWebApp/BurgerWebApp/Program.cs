using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.Business.Implementation;
using BurgerWebApp.DataAccess;
using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DataAccess.Implementation;
using BurgerWebApp.DomainModels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IRepository<Burger>, BurgerRepository>();
builder.Services.AddTransient<IRepository<Order>, OrderRepository>();
builder.Services.AddTransient<IRepository<Extra>, ExtraItemsRepository>();
builder.Services.AddTransient<IRepository<Location>, LocationRepository>();
builder.Services.AddTransient<IRepository<Cart>, CartRepository>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IBurgerService, BurgerService>();
builder.Services.AddTransient<ICartService, CartService>();
builder.Services.AddTransient<IExtraService, ExtraService>();
builder.Services.AddTransient<ILocationService, LocationService>();
builder.Services.AddDbContext<BurgerAppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
