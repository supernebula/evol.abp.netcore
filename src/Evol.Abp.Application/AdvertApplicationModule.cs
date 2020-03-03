using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Evol.Abp.Data;

namespace Evol.Abp
{
    [DependsOn(
        typeof(AdvertCoreModule), 
        typeof(AbpAutoMapperModule),
        typeof(AdvertDataModule)
        )]
    public class AdvertApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AdvertApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            //DapperExtensions.DapperExtensions.SetMappingAssemblies(new List<Assembly> { thisAssembly });

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
