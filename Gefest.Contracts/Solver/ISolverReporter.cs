namespace Gefest.Contracts.Solver;

/// <summary>
/// 
/// </summary>
public interface ISolverReporterAsync
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    Task<ISolverResult<T>> ReportAsync<T>();
}

/// <summary>
/// 
/// </summary>¬
public interface ISolverReporter
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    ISolverResult<T> Report<T>();
}