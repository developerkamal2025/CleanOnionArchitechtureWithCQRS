using WebAPI.Application.Query.Queries;
using WebAPI.Application.Shared.CQRS;

namespace WebAPI.Application.Query.Interfaces
{
    public interface IDataRead : IQueryHandler<DataFetchQuery>;
}
