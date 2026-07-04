using SemMediator.Domain.Shared.Records;

namespace SemMediator.Domain.Shared.Interfaces
{
    public interface ILogHandler
    {
        public Task SendLog(Log log);
    }
}
