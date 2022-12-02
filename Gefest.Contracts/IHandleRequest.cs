namespace Gefest.Contracts;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRequestHandler<in T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task HandleRequest(T request);
}