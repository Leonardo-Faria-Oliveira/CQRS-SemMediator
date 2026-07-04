using Microsoft.EntityFrameworkCore;

namespace SemMediator.Domain.Config.DatabaseContext
{
    public class CommandsDbContext(DbContextOptions<CommandsDbContext> options) : DbContext(options)
    {


    }
}
