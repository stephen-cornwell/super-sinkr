using SuperSinkr.Workflow.Mediator;
using SuperSinkr.Workflow.Workflow.Inputs;

namespace SuperSinkr.Workflow.Workflow;

// Workflow - the configuration
// Session - a set of instances of inputs, processors and outputs to be executed
// 

public interface ISyncWorkflow
{
    public ISyncInput Input { get; }
    public IProcessingPipeline Pipeline { get; }
    public ISyncOutput Output { get; }
}

/// <summary>
/// Represents a configuration of inputs, processors and outputs.
/// </summary>
public class SyncWorkflow : ISyncWorkflow
{
    private ICqrsMediator _mediator;

    public ISyncInput Input { get; protected set; }

   // public IProcessingPipeline Pipeline { get; protected set; }

    public ISyncOutput Output { get; protected set; }

    public SyncWorkflow(ICqrsMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task Start()
    {
        // Create and configure input(s) and triggers
        var inputConfig = new FolderSyncInputConfig();
        inputConfig.Folder = "c:\\temp\\super-sync\\input";
        
        Input = new FolderSyncInput(inputConfig);
        // Create and configure processors (processing pipeline).

       // Pipeline = new ProcessingPipeline()

        // Create and configure output(s)


        // Start triggers.

        await Input.StartMonitoring();
    }

}

public static class SyncWorkflowExtensions
{
    public static SyncWorkflow AddInput(this SyncWorkflow workflow, Action<FolderSyncInputConfig> options)
    {
        options.Invoke();

        return workflow;
    }
}

