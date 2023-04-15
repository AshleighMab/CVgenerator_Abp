using System.Threading.Tasks;
using CV_Abp.Configuration.Dto;

namespace CV_Abp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
