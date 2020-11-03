using EFCodeFirst.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    /*
     * Based on https://garywoodfine.com/using-ef-core-in-a-separate-class-library-project/
     * Before running commands, navigate to project folder (not solution parent)
     * Commands:
     * dotnet ef migrations add Initial
     * dotnet ef database update 
     */
    public class TestContextFactory : IDesignTimeDbContextFactory<TestDbContext>
    {
        public TestContextFactory()
        {
        }

        private IConfiguration Configuration => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        public TestDbContext CreateDbContext(string[] args)
        {

            var builder = new DbContextOptionsBuilder<TestDbContext>();
            builder.UseSqlServer(Configuration.GetValue<string>("DbConnectionString"));

            return new TestDbContext(builder.Options);
        }
    }
}
