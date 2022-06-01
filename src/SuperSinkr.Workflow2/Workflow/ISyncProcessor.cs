using SuperSinkr.Workflow2.Workflow.Processors;

namespace SuperSinkr.Workflow2.Workflow;

/// <summary>
/// Possible processors:
///     OCR
///     Convert to PDF
///     Convert to image
/// </summary>
/// <typeparam name="TProcessorCommand"></typeparam>
public interface ISyncProcessor
{
    Task<FileProcessorResult> Process(SyncFile file, CancellationToken cancellationToken = default);
}