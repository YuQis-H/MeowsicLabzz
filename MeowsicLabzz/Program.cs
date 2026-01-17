using MeowsicLabzz.Components;
using MeowsicLabzz.Components.Account;
using MeowsicLabzz.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("IdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'IdentityContextConnection' not found.");

// Register a DbContextFactory for use in Blazor components (register before AddDbContext)
builder.Services.AddDbContextFactory<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
 .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

// Register Identity including roles so role claims are populated in the cookie
builder.Services.AddIdentity<MeowsicLabzzUser, IdentityRole>(options =>
{
 options.SignIn.RequireConfirmedAccount = false;
})
 
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddSignInManager()
.AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<MeowsicLabzzUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Apply migrations and ensure admin user is in Administrator role (development convenience)
using (var scope = app.Services.CreateScope())
{
 var services = scope.ServiceProvider;
 try
 {
 var db = services.GetRequiredService<ApplicationDbContext>();
 db.Database.Migrate();

 var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
 var userManager = services.GetRequiredService<UserManager<MeowsicLabzzUser>>();

 const string adminRole = "Administrator";
 const string adminEmail = "admin@localhost.com";

 if (!roleManager.RoleExistsAsync(adminRole).GetAwaiter().GetResult())
 {
 roleManager.CreateAsync(new IdentityRole(adminRole)).GetAwaiter().GetResult();
 }

 var admin = userManager.FindByEmailAsync(adminEmail).GetAwaiter().GetResult();
 if (admin != null && !userManager.IsInRoleAsync(admin, adminRole).GetAwaiter().GetResult())
 {
 userManager.AddToRoleAsync(admin, adminRole).GetAwaiter().GetResult();
 }
 }
 catch (Exception ex)
 {
 // In development it's useful to log, keep minimal here
 Console.WriteLine($"An error occurred while migrating or seeding the database: {ex.Message}");
 }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
 app.UseExceptionHandler("/Error", createScopeForErrors: true);
 // The default HSTS value is30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
 app.UseHsts();
 app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
 .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();

app.Run();
