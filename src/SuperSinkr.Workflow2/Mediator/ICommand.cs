using MediatR;

namespace SuperSinkr.Workflow2.Mediator
{
    public interface ICommand : IRequest<Unit> { }

    public interface ICommand<out TResult> : IRequest<TResult> { }
}