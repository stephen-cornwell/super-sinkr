using MediatR;

namespace SuperSinkr.Workflow2.Mediator
{
    public interface IQueryHandler<in TQuery, TResult> : IRequestHandler<TQuery, TResult> where TQuery : IQuery<TResult> { }
}