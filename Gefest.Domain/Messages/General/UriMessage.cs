namespace Gefest.Domain.Messages.General;

/// <summary>
/// 
/// </summary>
public class UriMessage
{
    /// <summary>
    /// 
    /// </summary>
    public Uri Uri { get; protected set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    protected UriMessage(Uri uri)
    {
        Uri = uri;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static UriMessage CreateMessage(Uri? uri) 
        => new (uri!);
}