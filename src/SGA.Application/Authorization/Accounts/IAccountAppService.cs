using System.Threading.Tasks;
using Abp.Application.Services;
using SGA.Authorization.Accounts.Dto;

namespace SGA.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
