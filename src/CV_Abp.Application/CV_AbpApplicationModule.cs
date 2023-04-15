using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CV_Abp.Authorization;

namespace CV_Abp
{
    [DependsOn(
        typeof(CV_AbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CV_AbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CV_AbpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CV_AbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
