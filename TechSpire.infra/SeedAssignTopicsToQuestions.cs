using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TechSpire.infra.Dbcontext;
using TechSpire.infra.Services;

class Program
{
    static async Task Main(string[] args)
    {
        var services = new ServiceCollection();
        // Configure DbContext (update connection string as needed)
        services.AddDbContext<AppDbcontext>(options =>
            options.UseSqlServer("Server=.;Database=TechSpireDb;Trusted_Connection=true;TrustServerCertificate=true;"));

        var serviceProvider = services.BuildServiceProvider();
        using var scope = serviceProvider.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbcontext>();
        var topicExtractionService = new TopicExtractionService(dbContext);

        try
        {
            Console.WriteLine("Assigning topics to all questions based on keywords...");
            await topicExtractionService.ExtractAndAssignTopicsFromQuestionNamesAsync();
            Console.WriteLine("Topic assignment completed successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during topic assignment: {ex.Message}");
        }
    }
} 