using WebAPI.Application.Shared.CQRS;

namespace WebAPI.Application.Query.Queries
{
    public record DataFetchQuery(int? Id):IQuery;
}
