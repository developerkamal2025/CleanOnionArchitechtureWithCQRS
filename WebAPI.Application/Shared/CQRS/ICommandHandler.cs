﻿using MediatR;
using WebAPI.Application.Shared.ExceptionHandling;

namespace WebAPI.Application.Shared.CQRS
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result> where TCommand : ICommand;
    public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>> where TCommand : ICommand<TResponse>;
}
