using projekat.Database.Repository;
using projekat.Database;
using Microsoft.EntityFrameworkCore;
using Npgsql;

using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.ServiceContracts;
using Asseco.Rest.PersonalFinanceManagementAPI.Implementations.Mock;
using System.Reflection;
using Asseco.Rest.PersonalFinanceManagementAPI.Implementations.EntityFramework;
using projekat.Implementations.EntitityFramework;
using Asseco.REST.Utilities.Serialization;

namespace projekat;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddMvcWithDynamicCaseResolvers();


        builder.Services.AddScoped<ITransactionsRepository, TransactionRepository>();
        builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
        builder.Services.AddScoped<ISplitRepository, SplitRepository>();

        builder.Services.AddScoped<IPersonalFinanceManagementAPITransactionsQueryService, PersonalFinanceManagementApiQueryServiceTransactionEntityFramework>();
        builder.Services.AddScoped<IPersonalFinanceManagementAPITransactionsCommandService, CommandEF>();
        builder.Services.AddScoped<IPersonalFinanceManagementAPICategoriesCommandService, CategoryService>();
        builder.Services.AddScoped<IPersonalFinanceManagementAPICategoriesQueryService, CategoryQueryService>();
        builder.Services.AddScoped<IPersonalFinanceManagementAPIAnalyticsQueryService, AnalyticsServiceEF>();

        builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


        builder.Services.AddDbContext<TransactionDBContext>(options => {
            options.UseNpgsql(CreateConnectionString(builder.Configuration));
        });

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

        // app.UseAuthorization();

        InitializeDatabase(app);
        app.MapControllers();

        //postgres timestapms
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        app.Run();
    }

    private static void InitializeDatabase(WebApplication app)
    {
        if(app.Environment.IsDevelopment()) {
            using var scope= app.Services.GetService<IServiceScopeFactory>().CreateScope();

            scope.ServiceProvider.GetRequiredService<TransactionDBContext>().Database.Migrate();

        }
    }

    private static string CreateConnectionString(IConfiguration configuration)
    {
        var username = Environment.GetEnvironmentVariable("DATABASE_USERNAME") ?? configuration["Database:Username"];
        var password = Environment.GetEnvironmentVariable("DATABASE_PASSWORD") ?? configuration["Database:Password"];
        var database = Environment.GetEnvironmentVariable("DATABASE_NAME") ?? configuration["Database:Name"];
        var host = Environment.GetEnvironmentVariable("DATABASE_HOST") ?? configuration["Database:Host"];
        var port = Environment.GetEnvironmentVariable("DATABASE_PORT") ?? configuration["Database:Port"];

        var builder = new NpgsqlConnectionStringBuilder(){
            Host = host,
            Port = int.Parse(port),
            Username = username,
            Password = password,
            Database = database,
            Pooling = true
        };
        return builder.ConnectionString;
    }
}
