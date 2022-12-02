using Gefest.Domain.Messages.General;

namespace Gefest.Domain.Messages.Download;

/// <summary>
/// 
/// </summary>
public sealed class DownloadRequestMessage 
    : UriMessage
{
    public string Path { get; }

    public DownloadRequestMessage(Uri uri, string path)
        : base(uri)
    {
        Path = path;
    }
}