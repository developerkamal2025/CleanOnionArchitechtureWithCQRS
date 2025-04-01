using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.Application.Shared.Abstraction
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        private ISender? _mediator;
        protected ISender? Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
