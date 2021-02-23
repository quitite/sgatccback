using System.Threading.Tasks;
using Abp.Application.Services;
using SGA.Sessions.Dto;

namespace SGA.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
