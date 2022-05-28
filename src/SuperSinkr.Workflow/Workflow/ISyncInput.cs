namespace SuperSinkr.Workflow.Workflow;

/// <summary>
/// Possible inputs:
///     Watched directory
///     Supernate device
///     Cloud -
///         * google drive
///         * onedrive
///         * dropbox
/// </summary>
///


  
public interface ISyncInput 
{
    // todo: cache to avoid double processing???
    Task StartMonitoring();
    Task Trigger();

    
}

//public interface ISyncInput<in TConfig> : ISyncInput, IConfigurable<TConfig>
//{

//}