using Gefest.Domain.Messages.General;

namespace Gefest.Domain.Messages.Download;

/// <summary>
/// 
/// </summary>
public sealed class DownloadCompletedMessage 
    : UriMessage
{
    /// <summary>
    /// 
    /// </summary>
    public string Path { get; private set; }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <param name="path"></param>
    private DownloadCompletedMessage(Uri uri, string path)
        :base(uri)
    {
        Path = path;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public static DownloadCompletedMessage CreateMessage(Uri? uri, string? path) 
        => new (uri!, path!);
}