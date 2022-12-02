namespace Gefest.Contracts.SyncPipeline;

/// <summary>
/// 
/// </summary>
public interface ISyncPipeline
{
    /// <summary>
    /// 
    /// </summary>
    void SyncPreAction();
    
    /// <summary>
    /// 
    /// </summary>
    void SyncPostAction();
}