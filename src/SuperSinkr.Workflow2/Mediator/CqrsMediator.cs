using MediatR;

namespace SuperSinkr.Workflow2.Mediator
{
    public class CqrsMediator : ICqrsMediator
    {
        private readonly IMediator _mediator;

        public CqrsMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<TResult> Query<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(query, cancellationToken);
        }


        public async Task Command(ICommand command, CancellationToken cancellationToken = default)
        {
            await _mediator.Send(command, cancellationToken);
        }

        public async Task<TResult> Command<TResult>(ICommand<TResult> command, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(command, cancellationToken);
        }

        public async Task Notify(INotification notification, CancellationToken cancellationToken = default)
        {
            await _mediator.Publish(notification, cancellationToken);
        }
    }
    

}
