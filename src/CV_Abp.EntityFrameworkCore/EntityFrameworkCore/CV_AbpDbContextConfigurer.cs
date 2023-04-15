using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CV_Abp.EntityFrameworkCore
{
    public static class CV_AbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CV_AbpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CV_AbpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
