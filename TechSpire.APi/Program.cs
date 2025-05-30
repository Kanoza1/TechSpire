using Hangfire;
using Hangfire.States;
using Microsoft.EntityFrameworkCore;
using TechSpire.APi.Exceptions;
using TechSpire.infra;
using TechSpire.infra.Dbcontext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddInfrastructure(builder.Configuration);

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();


var app = builder.Build();

app.UseExceptionHandler();   //  Handle exceptions

app.UseHangfireDashboard("/jobs");

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Seed the database with initial data
//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbcontext>();
//    await AppDbContextSeed.SeedAsync(dbContext);
//}
//// Ensure that the database is created and migrations are applied
//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbcontext>();
//    await dbContext.Database.EnsureCreatedAsync();
//    // If you are using migrations, you can apply them here
//    // await dbContext.Database.MigrateAsync();
//}
//// Ensure that the Hangfire server is started
//using (var scope = app.Services.CreateScope())
//{
//    var hangfireServer = scope.ServiceProvider.GetRequiredService<IBackgroundJobClient>();
//    // You can enqueue jobs here if needed
//    // hangfireServer.Enqueue(() => Console.WriteLine("Hello from Hangfire!"));
//}

//try
//{
//    //using var scope = app.Services.CreateScope();
//    //var services = scope.ServiceProvider;
//    //var context = services.GetRequiredService<AppDbcontext>();
//    //await context.Database.MigrateAsync();
//    await AppDbContextSeed.SeedAsync(context);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex);
//    throw;
//}


app.Run();
