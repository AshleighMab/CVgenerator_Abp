using System.Threading.Tasks;
using Abp.Application.Services;
using CV_Abp.Sessions.Dto;

namespace CV_Abp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
