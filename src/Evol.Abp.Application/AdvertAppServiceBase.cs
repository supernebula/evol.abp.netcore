using Abp.Application.Services;

namespace Evol.Abp
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AdvertAppServiceBase : ApplicationService
    {
        protected AdvertAppServiceBase()
        {
            LocalizationSourceName = AdvertConsts.LocalizationSourceName;
        }
    }
}