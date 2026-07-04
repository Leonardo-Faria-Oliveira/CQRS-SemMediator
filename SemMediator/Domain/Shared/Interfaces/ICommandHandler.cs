using SemMediator.Domain.Shared.Records;

namespace SemMediator.Domain.Shared.Interfaces
{
    public interface ICommandHandler
    {
        public Task<CommandResult> Handle(ICommand command);
    }
}
