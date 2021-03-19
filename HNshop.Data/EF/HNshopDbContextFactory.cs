using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HNshop.Data.EF
{
    public class HNshopDbContextFactory : IDesignTimeDbContextFactory<HNshopDbContext>
    {
        public HNshopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("HNshopDb");

            var optionsBuilder = new DbContextOptionsBuilder<HNshopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new HNshopDbContext(optionsBuilder.Options);
        }
    }
}
