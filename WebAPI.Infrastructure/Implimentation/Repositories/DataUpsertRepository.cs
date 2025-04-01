using WebAPI.Application.Interfaces.Repository;
using WebAPI.Domain.DTOs;

namespace WebAPI.Infrastructure.Implimentation.Repositories
{
    public class DataUpsertRepository : IDataUpsertRepository
    {
        public async Task<int> DataUpsert(DataUpsertDTO reqObj)
        {
            int result = 0;
            try
            {
                result = 1;
            }
            catch {
                result = 0;
            }
            finally { }

            return result;
        }
    }
}
