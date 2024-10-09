var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(builder.Configuration));

builder.Services.AddControllersWithViews();

builder.Services.ConfigureSettings(builder.Configuration);

builder.Services.AddBusinessServices();
builder.Services.AddDataRepositories();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
//builder.Services.AddDbContext<ABCDContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Transient);
builder.Services.AddDbContextFactory<ABCDContext>(
    (options) =>
    {
        options.UseSqlServer(connectionString);
        options.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.BoolWithDefaultWarning));
    }, ServiceLifetime.Transient);

var app = builder.Build();

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

app.MapAreaControllerRoute("Admin", "Admin", "Admin/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

var appSettings = app.Services.GetRequiredService<IOptions<AppSettings>>().Value;
app.Logger.LogInformation("Starting {@AppSettings}", appSettings);

app.Run();
