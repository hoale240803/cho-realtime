using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ChoRealtime.Configuration.Dto;

namespace ChoRealtime.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ChoRealtimeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
