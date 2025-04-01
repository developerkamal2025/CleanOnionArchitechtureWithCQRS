using WebAPI.Domain.DTOs;

namespace WebAPI.Application.Interfaces.Repository
{
    public interface IDataUpsertRepository
    {
        Task<int> DataUpsert(DataUpsertDTO reqObj);
    }
}
