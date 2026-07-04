using Microsoft.EntityFrameworkCore;
using SemMediator.Domain.Shared.Records;

namespace SemMediator.Domain.Shared.Interfaces
{
    public interface ICommandHandler
    {
        public CurrentRequest CurrentRequest { get; }
        public DbContext DbContext { get; }
        public Task<CommandResult> Handle(ICommand commands);
    }
}
