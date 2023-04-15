using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CV_Abp.Configuration;
using CV_Abp.Web;

namespace CV_Abp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CV_AbpDbContextFactory : IDesignTimeDbContextFactory<CV_AbpDbContext>
    {
        public CV_AbpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CV_AbpDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CV_AbpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CV_AbpConsts.ConnectionStringName));

            return new CV_AbpDbContext(builder.Options);
        }
    }
}
