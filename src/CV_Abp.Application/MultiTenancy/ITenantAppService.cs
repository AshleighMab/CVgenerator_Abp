using Abp.Application.Services;
using CV_Abp.MultiTenancy.Dto;

namespace CV_Abp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

