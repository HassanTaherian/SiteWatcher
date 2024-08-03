using Microsoft.AspNetCore.Mvc;
using SiteWatcher.Core.Entities;
using SiteWatcher.Core.Services;

namespace SiteWatcher.Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class WatchController(WatchService watchService) : ControllerBase
{
    private readonly WatchService _watchService = watchService;

    [HttpPost("")]
    public async Task<IActionResult> CreateWatch(string name, CancellationToken cancellationToken)
    {
        Watch watch = await _watchService.CreateWatch(name, cancellationToken);

        return Ok(watch);
    }
}
