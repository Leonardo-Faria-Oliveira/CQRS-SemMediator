using SemMediator.Domain.Shared.Records;

namespace SemMediator.Domain.Shared.Interfaces
{
    public interface IQuery
    {
        public Task<QueryResult> GetErrorAsync(IQueryHandler handler);
        public Task<bool> HasPermissionAsync(IQueryHandler handler);
        public Task<QueryResult> QueryAsync(IQueryHandler queryHandler);
        public Log GetLog();
    }
}
