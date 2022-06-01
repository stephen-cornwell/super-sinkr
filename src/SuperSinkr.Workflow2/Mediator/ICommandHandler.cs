using MediatR;

namespace SuperSinkr.Workflow2.Mediator
{
    public interface ICommandHandler<in TCommand, TResult> : IRequestHandler<TCommand, TResult> where TCommand : ICommand<TResult> { }
}