using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CV_Abp.Configuration;

namespace CV_Abp.Web.Host.Startup
{
    [DependsOn(
       typeof(CV_AbpWebCoreModule))]
    public class CV_AbpWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CV_AbpWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CV_AbpWebHostModule).GetAssembly());
        }
    }
}
