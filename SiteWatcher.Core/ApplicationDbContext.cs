using Microsoft.EntityFrameworkCore;
using SiteWatcher.Core.Entities;

namespace SiteWatcher.Core;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public required DbSet<Watch> Watches { get; set; }
}