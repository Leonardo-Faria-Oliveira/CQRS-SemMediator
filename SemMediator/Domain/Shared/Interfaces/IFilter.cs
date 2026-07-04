using SemMediator.Domain.Shared.Enums;

namespace SemMediator.Domain.Shared.Interfaces
{
    public interface IFilter
    {
        public List<EEvent> GetEvents();
        public Task ExecuteAsync(ICommandHandler commandHandler);
        public Task AfterExecuteAsync();
    }
}
