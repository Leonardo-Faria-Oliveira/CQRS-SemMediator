using SemMediator.Domain.Shared.Enums;
using SemMediator.Domain.Shared.Interfaces;

namespace SemMediator.Domain.Filters.Teste
{
    public class TesteFilter : IFilter
    {
        public Task AfterExecuteAsync()
        {
            throw new NotImplementedException();
        }

        public Task ExecuteAsync(ICommandHandler commandHandler)
        {
            throw new NotImplementedException();
        }

        public List<EEvent> GetEvents()
        {
            throw new NotImplementedException();
        }
    }
}
