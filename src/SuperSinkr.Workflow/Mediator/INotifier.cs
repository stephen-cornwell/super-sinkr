using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSinkr.Workflow.Mediator
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
