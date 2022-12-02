namespace Gefest.Contracts.Pipeline;

/// <summary>
/// 
/// </summary>
public interface IPipeline
{
    /// <summary>
    /// 
    /// </summary>
    int Count { get; }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="task"></param>
    void AddTask(Task task);
}