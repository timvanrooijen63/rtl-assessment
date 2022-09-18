using Microsoft.AspNetCore.Mvc;
using Rtl.WebApi.Models.Api;
using Rtl.WebApi.Models.Shared;
using Rtl.WebApi.Services;

namespace Rtl.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ShowsController : ControllerBase
{
    private readonly ILogger<ShowsController> _logger;
    private readonly IShowService _showService;

    public ShowsController(ILogger<ShowsController> logger, IShowService showService)
    {
        _logger = logger;
        _showService = showService;
    }

    [HttpGet(Name = "GetShows")]
    public async Task<Pagination<ShowResponse>> GetShowsAsync([FromQuery] Pagination pagination)
    {
        return await _showService.GetShowAsync(pagination);
    }
}
