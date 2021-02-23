using System.Threading.Tasks;
using SGA.Configuration.Dto;

namespace SGA.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
