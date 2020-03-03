using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Evol.Abp.Configuration.Dto;

namespace Evol.Abp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AdvertAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
