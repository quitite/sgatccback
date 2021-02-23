using Abp.Authorization;
using SGA.Authorization.Roles;
using SGA.Authorization.Users;

namespace SGA.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
