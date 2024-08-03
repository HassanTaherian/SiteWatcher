using SiteWatcher.Core.Entities;

namespace SiteWatcher.Core.Services;

public class WatchService(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Watch> CreateWatch(string name, CancellationToken cancellationToken)
    {
        Watch watch = new()
        {
            Name = name
        };

        await _context.Database.EnsureCreatedAsync(cancellationToken);
        await _context.Set<Watch>().AddAsync(watch, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return watch;
    }
}