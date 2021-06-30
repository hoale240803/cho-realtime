using Abp.Application.Services.Dto;

namespace ChoRealtime.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

