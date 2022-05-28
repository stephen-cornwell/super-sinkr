using SuperSinkr.Workflow.Workflow;

namespace SuperSinkr.Workflow;

public class SyncSession
{
    public Guid Id { get; }
    public List<SyncFile> Files { get; }

    public SyncSession()
    {
        Id = Guid.NewGuid();
        Files = new List<SyncFile>();
    }
}