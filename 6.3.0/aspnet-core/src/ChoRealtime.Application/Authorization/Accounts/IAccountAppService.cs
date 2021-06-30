using System.Threading.Tasks;
using Abp.Application.Services;
using ChoRealtime.Authorization.Accounts.Dto;

namespace ChoRealtime.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
