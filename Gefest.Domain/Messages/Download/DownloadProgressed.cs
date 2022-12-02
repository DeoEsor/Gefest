using Gefest.Domain.Messages.General;

namespace Gefest.Domain.Messages.Download;

/// <summary>
/// 
/// </summary>
public class DownloadProgressedMessage 
    : UriMessage
{
    /// <summary>
    /// 
    /// </summary>
    public double Progress { get; private set; }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <param name="progress"></param>
    public DownloadProgressedMessage(Uri uri, double progress)
        :base(uri)
    {
        Progress = progress;
    }
}