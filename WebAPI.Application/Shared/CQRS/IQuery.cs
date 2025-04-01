using MediatR;
using WebAPI.Application.Shared.ExceptionHandling;

namespace WebAPI.Application.Shared.CQRS
{
    public interface IQuery : IRequest<Result>;
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>;
}
