using Evol.Abp.Configuration;
using Evol.Abp.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Evol.Abp.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class AdvertDbContextFactory : IDesignTimeDbContextFactory<AdvertDbContext>
    {
        public AdvertDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AdvertDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(AdvertConsts.ConnectionStringName)
            );

            return new AdvertDbContext(builder.Options);
        }
    }
}