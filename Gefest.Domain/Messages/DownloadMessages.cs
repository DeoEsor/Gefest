namespace Gefest.Domain.Messages;

public sealed record DownloadCompletedMessage(Uri Uri, string Path) : UriMessage(Uri);

public sealed record DownloadProgressedMessage(Uri Uri, float Progress) : UriMessage(Uri);

public sealed record DownloadRequestMessage(Uri Uri, string Path) : UriMessage(Uri);

public sealed record DownloadStartedMessage(Uri Uri) : UriMessage(Uri);