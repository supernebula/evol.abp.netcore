using Abp.Dapper;
using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DapperExtensions.Sql;
using System.Collections.Generic;
using System.Reflection;

namespace Evol.Abp.Data
{
    [DependsOn(
        typeof(AdvertCoreModule),
        typeof(AbpEntityFrameworkCoreModule),
        typeof(AbpDapperModule))]
    public class AdvertDataModule : AbpModule
    {

        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }



        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdvertDataModule).GetAssembly());

            DapperExtensions.DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(AdvertDataModule).GetAssembly() });
            //使用mysql必须修改，默认是sqlserver
            DapperExtensions.DapperExtensions.SqlDialect = new MySqlDialect();
        }
    }
}