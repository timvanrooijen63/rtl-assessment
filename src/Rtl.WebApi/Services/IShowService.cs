using Rtl.WebApi.Models.Api;
using Rtl.WebApi.Models.Shared;

namespace Rtl.WebApi.Services
{
    public interface IShowService
    {
        Task<Pagination<ShowResponse>> GetShowAsync(Pagination pagination);
    }
}
