using MediatR;

namespace SuperSinkr.Workflow2.Mediator
{
    public interface IQuery<out TResult> : IRequest<TResult> {}
}