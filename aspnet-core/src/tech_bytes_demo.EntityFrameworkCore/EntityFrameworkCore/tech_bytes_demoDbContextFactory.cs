using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace tech_bytes_demo.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class tech_bytes_demoDbContextFactory : IDesignTimeDbContextFactory<tech_bytes_demoDbContext>
{
    public tech_bytes_demoDbContext CreateDbContext(string[] args)
    {
        tech_bytes_demoEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<tech_bytes_demoDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new tech_bytes_demoDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../tech_bytes_demo.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
