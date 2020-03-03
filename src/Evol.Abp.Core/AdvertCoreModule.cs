using Abp.Modules;
using Abp.Reflection.Extensions;
using Evol.Abp.Localization;

namespace Evol.Abp
{
    public class AdvertCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            AdvertLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdvertCoreModule).GetAssembly());
        }
    }
}