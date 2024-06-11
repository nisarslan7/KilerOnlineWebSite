using KilerOnline.Business.Abstract;
using KilerOnline.Business.Concrete;
using KilerOnline.DataAccess;
using KilerOnline.DataAccess.Abstract;
using KilerOnline.DataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<IFoodService, FoodManager>();
builder.Services.AddSingleton<IProductService, ProductManager>();
builder.Services.AddSingleton<IRegionService, RegionManager>();
builder.Services.AddSingleton<IUserService, UserManager>();
builder.Services.AddSingleton<IRoleService, RoleManager>();
builder.Services.AddSingleton<ApplicationDbContext, ApplicationDbContext>();
builder.Services.AddSingleton<ICategoryRepository, CategoryRepository>();
builder.Services.AddSingleton<IFoodRepository, FoodRepository>();
builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<IRegionRepository, RegionRepository>();
builder.Services.AddSingleton<IRoleRepository, RoleRepository>();
builder.Services.AddSingleton<IUserRepository, UserRepository>();





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
