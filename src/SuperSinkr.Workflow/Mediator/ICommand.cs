using MediatR;

namespace SuperSinkr.Workflow.Mediator
{
    public interface ICommand : IRequest<Unit> { }

    public interface ICommand<out TResult> : IRequest<TResult> { }
}