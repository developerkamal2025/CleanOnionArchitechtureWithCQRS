﻿using MediatR;
using WebAPI.Application.Shared.ExceptionHandling;

namespace WebAPI.Application.Shared.CQRS
{
    public interface IQueryHandler<TQuery> : IRequestHandler<TQuery, Result> where TQuery : IQuery;
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>> where TQuery : IQuery<TResponse>;
}
