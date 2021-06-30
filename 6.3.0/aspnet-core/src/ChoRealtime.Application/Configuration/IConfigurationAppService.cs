using System.Threading.Tasks;
using ChoRealtime.Configuration.Dto;

namespace ChoRealtime.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
