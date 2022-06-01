using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservablePipelines;

namespace SuperSinkr.Workflow
{
    internal class Input : IPipe<SyncSession, SyncSession>
    {
        public IObservable<SyncSession> Handle(IObservable<SyncSession> source)
        {
            throw new NotImplementedException();
        }
    }
}
