using System.Threading.Tasks;
using Evol.Abp.Configuration.Dto;

namespace Evol.Abp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
