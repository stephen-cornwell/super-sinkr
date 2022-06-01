using SuperSinkr.Workflow2.Mediator;

namespace SuperSinkr.Workflow2.Workflow.Inputs;

public class FolderSyncInput : ISyncInput
{
    private readonly ICqrsMediator _mediator;
    private FolderSyncInputConfig _config;

    public FolderSyncInput(FolderSyncInputConfig config)
    {
        _config = config;
    }

    public async Task StartMonitoring()
    {
        // File monitor, manual trigger etc.
    }

    public async Task Trigger()
    {
        var session = new SyncSession();
        var files = new List<SyncFile>();

        foreach (var filePath in Directory.GetFiles(_config.Folder))
        {
            var fileName = Path.GetFileName(filePath);
            var syncPath = filePath.Remove(0, _config.Folder.Length - 1);

            var fileContent = await File.ReadAllBytesAsync(filePath);
            var syncItem = new SyncFile("", filePath, fileContent);
            session.Files.Add(syncItem);
        }

        // If we have files to sync, then notify handling systems.
        await _mediator.Notify(new FilesRetrievedNotification(session));
    }
}