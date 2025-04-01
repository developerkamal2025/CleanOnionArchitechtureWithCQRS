using WebAPI.Application.Interfaces.Repository;
using WebAPI.Application.Query.Interfaces;
using WebAPI.Application.Query.Queries;
using WebAPI.Application.Shared.ExceptionHandling;

namespace WebAPI.Application.Query.QueryHandler
{
    public class DataFetchQueryHandler : IDataRead
    {
        private readonly IDataFetchRepository _fetchService;
        public DataFetchQueryHandler(IDataFetchRepository fetchService) {
            _fetchService = fetchService;
        }

        public async Task<Result> Handle(DataFetchQuery query, CancellationToken cancellationToken)
        {
            var response = await _fetchService.DataFetch(query.Id);
            return Result.Success(response);
        }
    }
}
