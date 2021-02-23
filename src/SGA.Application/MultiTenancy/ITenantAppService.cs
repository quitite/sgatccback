using Abp.Application.Services;
using SGA.MultiTenancy.Dto;

namespace SGA.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

