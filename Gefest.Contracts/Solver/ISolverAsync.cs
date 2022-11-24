namespace Gefest.Contracts;

/// <summary>
/// 
/// </summary>
public interface ISolverAsync
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    Task<ISolverResult<T>> SolveAsync<T>();
}

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ISolverAsync<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<ISolverResult<T>> SolveAsync();
}