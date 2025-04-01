using WebAPI.Domain.Models;

namespace WebAPI.Application.Interfaces.Repository
{
    public interface IDataFetchRepository
    {
        Task<List<DataFetchResponse>> DataFetch(int? id);
    }
}
