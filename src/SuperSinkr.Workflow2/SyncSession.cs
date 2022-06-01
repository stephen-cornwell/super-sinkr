using SuperSinkr.Workflow2.Workflow;

namespace SuperSinkr.Workflow2;

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