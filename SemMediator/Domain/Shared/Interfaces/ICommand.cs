using SemMediator.Domain.Shared.Enums;
using SemMediator.Domain.Shared.Records;

namespace SemMediator.Domain.Shared.Interfaces
{
    public interface ICommand
    {
        public Task<CommandResult> GetErrorAsync(ICommandHandler handler);
        public Task<bool> HasPermissionAsync(ICommandHandler handler);
        public Task<CommandResult> ExecuteAsync(ICommandHandler handler);
        public EEvent GetEvent();
        public Log GetLog();
    }
}
