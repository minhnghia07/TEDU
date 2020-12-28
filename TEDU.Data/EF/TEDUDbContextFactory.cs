using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TEDU.Data.EF
{
    class TEDUDbContextFactory : IDesignTimeDbContextFactory<TEDUDbContext>
    {
        public TEDUDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("TEDUDb"); 

            var optionsBuilder = new DbContextOptionsBuilder<TEDUDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TEDUDbContext(optionsBuilder.Options);
        }
    }
}
