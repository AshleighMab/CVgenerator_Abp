using System.Threading.Tasks;
using Abp.Application.Services;
using CV_Abp.Authorization.Accounts.Dto;

namespace CV_Abp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
