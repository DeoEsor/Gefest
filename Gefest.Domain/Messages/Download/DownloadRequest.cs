using Gefest.Domain.Messages.General;

namespace Gefest.Domain.Messages.Download;

/// <summary>
/// 
/// </summary>
public sealed class DownloadRequestMessage 
    : UriMessage
{
    public DownloadRequestMessage(Uri uri)
        : base(uri)
    { }
}