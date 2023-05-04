using Microsoft.EntityFrameworkCore;

namespace SegmentSoTCSharp.Models;

public class SoTContext : DbContext
{
    public SoTContext(DbContextOptions<SoTContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<UserTrait> UserTraits { get; set; } = null!;
}