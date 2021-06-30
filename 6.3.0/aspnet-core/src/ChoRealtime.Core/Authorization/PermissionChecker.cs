using Abp.Authorization;
using ChoRealtime.Authorization.Roles;
using ChoRealtime.Authorization.Users;

namespace ChoRealtime.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
