using SemMediator.Domain.Shared.Enums;
using SemMediator.Domain.Shared.Interfaces;
using SemMediator.Domain.Shared.Records;

namespace SemMediator.Domain.Queries
{
    public class QueriesHandlers : IQueryHandler
    {
        private readonly CurrentRequest CurrentRequest;
        private readonly ILogHandler LogHandler;

        public QueriesHandlers(
        CurrentRequest _currentRequest,
        ILogHandler _logHandler)
        {
            CurrentRequest = _currentRequest;
            LogHandler = _logHandler;
        }

        public async Task<QueryResult> Query(IQuery query)
        {

            var errors = await query.GetErrorAsync(this);
            if (errors != null)
            {
                return errors;
            }

            var hasPermission = await query.HasPermissionAsync(this);
            if (!hasPermission)
            {
                return new QueryResult(EErrorResponse.Forbidden, "You can not apply to this request");
            }

            var result = await query.QueryAsync(this);

            var log = query.GetLog();
            await LogHandler.SendLog(log);

            return result;
        }
    }
}
