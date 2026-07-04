using SemMediator.Domain.Shared.Enums;

namespace SemMediator.Domain.Shared.Interfaces
{
    public interface IFilterHandler
    {
        public List<IFilter> GetFilters(EEvent commandEvent);
    }
}
