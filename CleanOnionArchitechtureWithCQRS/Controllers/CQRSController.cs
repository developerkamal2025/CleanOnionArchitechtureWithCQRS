using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.Shared.Abstraction;
using WebAPI.Application.Command.Commands;
using WebAPI.Application.Query.Queries;

namespace CleanOnionArchitechtureWithCQRS.Controllers
{
    [Route("api/[controller]")]
    public class CQRSController : BaseController
    {
        [HttpPost("DataUpsert")]
        public async Task<IActionResult> DataUpsert(DataUpsertCommand command, CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(command, cancellationToken));
        }

        [HttpPost("DataFetch")]
        public async Task<IActionResult> DataFetch(DataFetchQuery query, CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(query, cancellationToken));
        }
    }
}
