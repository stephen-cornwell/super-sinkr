using MediatR;

namespace SuperSinkr.Workflow2.Mediator
{
    public interface ICqrsMediator
    {
        Task<TResult> Query<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
        Task Command(ICommand command, CancellationToken cancellationToken = default);
        Task<TResult> Command<TResult>(ICommand<TResult> command, CancellationToken cancellationToken = default);
        Task Notify(INotification notification, CancellationToken cancellationToken = default);
    }
}