using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Evol.Abp.EntityFrameworkCore;
using Abp.AspNetCore;
using Evol.Abp.Web.Core.Extensions;
using Evol.Abp.Data;

namespace Evol.Abp.Web.Site.Startup
{
    [DependsOn(
        typeof(AdvertApplicationModule),
        typeof(AdvertDataModule),
        typeof(AbpAspNetCoreModule))]
    public class AdvertWebSiteModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AdvertWebSiteModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<AdvertNavigationProvider>();
        }


        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdvertWebSiteModule).GetAssembly());
        }
    }
}