using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiDb
{
    internal class AppDataDesignTimeContext : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source=WIZYOGA;Initial Catalog=MattiExampleDb;TrustServerCertificate=true;Integrated Security=True");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
