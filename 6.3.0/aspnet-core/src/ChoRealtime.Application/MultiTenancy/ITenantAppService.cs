using Abp.Application.Services;
using ChoRealtime.MultiTenancy.Dto;

namespace ChoRealtime.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

