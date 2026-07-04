using SemMediator.Domain.Shared.Enums;
using SemMediator.Domain.Shared.Interfaces;
using SemMediator.Domain.Shared.Records;

namespace SemMediator.Domain.Commands
{
    public class CommandsHandler : ICommandHandler
    {
        private readonly CurrentRequest CurrentRequest;
        private readonly IFilterHandler FilterHandler;
        private readonly ILogHandler LogHandler;
        public CommandsHandler(
            CurrentRequest _currentRequest, 
            IFilterHandler _filterHandler,
            ILogHandler _logHandler)
        {
            CurrentRequest = _currentRequest;
            FilterHandler = _filterHandler;
            LogHandler = _logHandler;
        }

        public async Task<CommandResult> Handle(ICommand command)
        {
            var errors = await command.GetErrorAsync(this);
            if(errors != null)
            {
                return errors;
            }

            var hasPermission = await command.HasPermissionAsync(this);
            if (!hasPermission)
            {
                return new CommandResult(EErrorResponse.Forbidden, "You can not apply to this request");
            }

            var result = await command.ExecuteAsync(this);

            // Filters
            var commandEvent = command.GetEvent();
            var filters = FilterHandler.GetFilters(commandEvent);
            foreach (var item in filters)
            {
                await item.ExecuteAsync(this);
                await item.AfterExecuteAsync();
            }

            //Logs
            var log = command.GetLog();
            await LogHandler.SendLog(log);

            return result;
        }
    }
}
