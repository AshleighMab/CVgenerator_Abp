using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CV_Abp.EntityFrameworkCore;
using CV_Abp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CV_Abp.Web.Tests
{
    [DependsOn(
        typeof(CV_AbpWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CV_AbpWebTestModule : AbpModule
    {
        public CV_AbpWebTestModule(CV_AbpEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CV_AbpWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CV_AbpWebMvcModule).Assembly);
        }
    }
}