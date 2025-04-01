using MediatR;
using WebAPI.Application.Shared.ExceptionHandling;

namespace WebAPI.Application.Shared.CQRS
{
    public interface ICommand : IRequest<Result>;
    public interface ICommand<TResponse> : IRequest<Result<TResponse>>;
}
