using SemMediator.Domain.Shared.Interfaces;
using SemMediator.Domain.Shared.Records;

namespace SemMediator.Domain.Queries.Teste
{
    public class ListTestsQuery : IQuery
    {
        public Task<QueryResult> GetErrorAsync(IQueryHandler handler)
        {
            throw new NotImplementedException();
        }

        public Log GetLog()
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasPermissionAsync(IQueryHandler handler)
        {
            throw new NotImplementedException();
        }

        public Task<QueryResult> QueryAsync(IQueryHandler queryHandler)
        {
            throw new NotImplementedException();
        }
    }
}
