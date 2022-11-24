namespace Gefest.Contracts;

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
/// <typeparam name="T"></typeparam>
public interface ISolverReporter
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    ISolverResult<T> Report();
}