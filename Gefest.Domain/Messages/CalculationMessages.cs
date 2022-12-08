namespace Gefest.Domain.Messages;

public sealed record CalculationCompletedMessage(Uri Uri, string Path) : UriMessage(Uri);

public sealed record CalculationProgressedMessage(Uri Uri, float Progress) : UriMessage(Uri);

public sealed record CalculationRequestMessage(Uri Uri, string Path) : UriMessage(Uri);

public sealed record CalculationStartedMessage(Uri Uri) : UriMessage(Uri);
