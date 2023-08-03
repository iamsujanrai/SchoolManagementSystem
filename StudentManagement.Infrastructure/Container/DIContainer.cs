using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentManagement.Infrastructure.SchoolContext;

namespace StudentManagement.Infrastructure.Container
{
    public static class DIContainer
    {
        public static IServiceCollection ImplementPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<SchoolDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly(typeof(SchoolDbContext).Assembly.FullName)),
            ServiceLifetime.Singleton);

            services.AddScoped<ISchoolDbContext>(provider => provider.GetRequiredService<SchoolDbContext>());

            return services;
        }
    }
}
