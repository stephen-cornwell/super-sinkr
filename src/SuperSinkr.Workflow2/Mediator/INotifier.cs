namespace SuperSinkr.Workflow2.Mediator
{
    internal interface INotifier
    {
        Task Publish<TMessage>(TMessage message);
    }

    public class NullNotifier : INotifier
    {
        public Task Publish<TMessage>(TMessage message)
        {
            return Task.CompletedTask;
        }
    }
}
