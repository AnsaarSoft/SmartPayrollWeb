var logger = LogManager.Setup().LoadConfigurationFromFile().GetCurrentClassLogger();
try
{

    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddDbContext<AppDBContext>(db => db.UseSqlServer(builder.Configuration.GetConnectionString("AppString")), ServiceLifetime.Singleton);
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();
    #region Register DB Services
    builder.Services.AddScoped<IMstUser, MstUserService>();
    builder.Services.AddScoped<IMstEmployee, MstEmployeeService>();

    #endregion

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

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
