using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CV_Abp.Configuration.Dto;

namespace CV_Abp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CV_AbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
