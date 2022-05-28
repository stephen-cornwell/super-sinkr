using SuperSinkr.Workflow.Mediator;
using SuperSinkr.Workflow.Workflow.Processors;

namespace SuperSinkr.Workflow.Workflow;

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