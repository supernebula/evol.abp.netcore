using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Evol.Abp.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<AdvertDbContext> dbContextOptions,
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for AdvertDbContext */
            dbContextOptions.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AdvertDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}

