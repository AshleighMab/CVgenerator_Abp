using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CV_Abp.Authorization.Roles;
using CV_Abp.Authorization.Users;
using CV_Abp.MultiTenancy;

namespace CV_Abp.EntityFrameworkCore
{
    public class CV_AbpDbContext : AbpZeroDbContext<Tenant, Role, User, CV_AbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CV_AbpDbContext(DbContextOptions<CV_AbpDbContext> options)
            : base(options)
        {
        }
    }
}
