using SemMediator.Domain.Shared.Records;

namespace SemMediator.Domain.Shared.Interfaces
{
    public interface IQueryHandler
    {
        public Task<QueryResult> Query(IQuery query);
    }
}