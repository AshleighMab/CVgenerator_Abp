using Abp.Authorization;
using CV_Abp.Authorization.Roles;
using CV_Abp.Authorization.Users;

namespace CV_Abp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
