using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SGA.Roles.Dto;
using SGA.Users.Dto;

namespace SGA.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
