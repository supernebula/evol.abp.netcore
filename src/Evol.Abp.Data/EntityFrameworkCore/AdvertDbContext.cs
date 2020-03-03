using Abp.EntityFrameworkCore;
using Evol.Abp.Component.Model;
using Microsoft.EntityFrameworkCore;

namespace Evol.Abp.EntityFrameworkCore
{
    public class AdvertDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public virtual DbSet<Customer> Customeres { get; set; }

        public AdvertDbContext(DbContextOptions<AdvertDbContext> options)
            : base(options)
        {

        }
    }
}
