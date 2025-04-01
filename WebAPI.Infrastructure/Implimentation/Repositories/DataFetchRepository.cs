using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Interfaces.Repository;
using WebAPI.Domain.Models;

namespace WebAPI.Infrastructure.Implimentation.Repositories
{
    public class DataFetchRepository :IDataFetchRepository
    {
        public async Task<List<DataFetchResponse>> DataFetch(int? id)
        {
            List<DataFetchResponse> response = new List<DataFetchResponse>();
            try
            {

            }
            catch(Exception ex) {
                throw;
            }
            finally
            {
            }
            return response;
        }
    }
}
