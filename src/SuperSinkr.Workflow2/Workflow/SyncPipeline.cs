using MediatR;
using SuperSinkr.Workflow2.Mediator;
using SuperSinkr.Workflow2.Workflow.Processors;

namespace SuperSinkr.Workflow2.Workflow;

public interface IProcessingPipeline
{
    List<ISyncProcessor> Processors { get; }
}


public class ProcessingPipeline : IProcessingPipeline, INotificationHandler<FilesRetrievedNotification>
{
    private ICqrsMediator _mediator;

    public List<ISyncProcessor> Processors { get; }

    public ProcessingPipeline(ICqrsMediator mediator)
    {
        _mediator = mediator;

        Processors = new List<ISyncProcessor>();
        Processors.Add(new DummySyncProcessor());
    }

    public async Task Handle(FilesRetrievedNotification notification, CancellationToken cancellationToken)
    {
        if (notification.Session.Id == )

        foreach (var item in notification.Session.Files)
        {
            foreach (var processor in Processors)
            {
                // Get command type for processor.

                var result = await processor.Process(item, cancellationToken);

                if (!result.IsSuccessful)
                {
                    // terminate session.
                }
            }
        }

    }
}

public class PipelineSession
{
    public PipelineSession()
    {

    }
}