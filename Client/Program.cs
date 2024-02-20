using Client.CustomAuth;
using Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using NLog.Web;

var logger = LogManager.Setup().LoadConfigurationFromFile().GetCurrentClassLogger();
try
{

    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    //builder.Services.AddRazorComponents().AddInteractiveServerComponents();
    builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents();
        
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();
    builder.Services.AddMudServices();
    builder.Services.AddScoped<AuthenticationStateProvider, AppAuthorization>();
    builder.Services.AddHttpClient<AccountService>(options =>
    {
        options.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ApiService"));
        options.Timeout = TimeSpan.FromSeconds(30);
    });

    #region Application Services
    builder.Services.AddTransient<AccountService>();
    #endregion

    builder.Services.AddAuthorization();
    builder.Services.AddAuthentication("Bearer").AddJwtBearer();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error", createScopeForErrors: true);
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();

    app.UseStaticFiles();
    app.UseAntiforgery();

    app.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();

    app.Run();

}
catch (Exception ex)
{
    logger.Error(ex);
}
finally
{
    LogManager.Shutdown();
}