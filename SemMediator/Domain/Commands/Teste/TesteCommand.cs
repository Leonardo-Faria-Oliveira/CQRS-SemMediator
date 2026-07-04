using SemMediator.Domain.Shared.Enums;
using SemMediator.Domain.Shared.Interfaces;
using SemMediator.Domain.Shared.Records;

namespace SemMediator.Domain.Commands.Teste
{
    public class TesteCommand : ICommand
    {
        public Task<CommandResult> ExecuteAsync(ICommandHandler handler)
        {
            throw new NotImplementedException();
        }

        public Task<CommandResult> GetErrorAsync(ICommandHandler handler)
        {
            throw new NotImplementedException();
        }

        public EEvent GetEvent()
        {
            throw new NotImplementedException();
        }

        public Log GetLog()
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasPermissionAsync(ICommandHandler handler)
        {
            throw new NotImplementedException();
        }
    }
}
