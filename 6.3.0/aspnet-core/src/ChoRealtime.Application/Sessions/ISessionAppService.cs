using System.Threading.Tasks;
using Abp.Application.Services;
using ChoRealtime.Sessions.Dto;

namespace ChoRealtime.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
