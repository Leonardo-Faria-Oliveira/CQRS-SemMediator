using SemMediator.Domain.Shared.Records;

namespace SemMediator.Domain.Shared.Interfaces
{
    public interface IQueryHandler
    {
        public CurrentRequest CurrentRequest { get; }
        public Task<QueryResult> Query(IQuery query);
    }
}