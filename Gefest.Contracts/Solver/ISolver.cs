namespace Gefest.Contracts.Solver;

/// <summary>
/// 
/// </summary>
public interface ISolver
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    ISolverResult<T> Solve<T>();
}

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ISolver<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    ISolverResult<T> Solve();
}