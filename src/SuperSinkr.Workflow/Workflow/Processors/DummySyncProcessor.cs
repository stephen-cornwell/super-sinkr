using System.Text;

namespace SuperSinkr.Workflow.Workflow.Processors;

public class DummySyncProcessor : ISyncProcessor
{
    public async Task<FileProcessorResult> Process(SyncFile file, CancellationToken cancellationToken = default)
    {
        file.ProcessingHistory.Add(new ProcessingHistory(Encoding.UTF8.GetBytes($"Processed By: {GetType().Name}"), GetType().Name));

        return await Task.FromResult(new FileProcessorResult());
    }
}