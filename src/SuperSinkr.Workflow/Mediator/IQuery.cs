using MediatR;

namespace SuperSinkr.Workflow.Mediator
{
    public interface IQuery<out TResult> : IRequest<TResult> {}
}