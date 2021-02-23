using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SGA.Configuration.Dto;

namespace SGA.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SGAAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
