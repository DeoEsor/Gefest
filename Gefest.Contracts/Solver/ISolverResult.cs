namespace Gefest.Contracts;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ISolverResult<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    T Result { get; }   

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    string Comment { get; }
}