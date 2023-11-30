using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace ngnet.EntityFramework.Core;

[AppDbContext("ngnet", DbProvider.Sqlite)]
public class DefaultDbContext : AppDbContext<DefaultDbContext>
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
    {
    }
}
