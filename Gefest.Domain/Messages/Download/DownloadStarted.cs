using Gefest.Domain.Messages.General;

namespace Gefest.Domain.Messages.Download;

/// <summary>
/// 
/// </summary>
public class DownloadStartedMessage 
    : UriMessage
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    public DownloadStartedMessage(Uri uri)
        :base(uri)
    {  }
}