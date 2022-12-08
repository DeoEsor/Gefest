using Akka.Actor;
using Gefest.Actors.Extensions;
using Gefest.Contracts;
using Gefest.Domain.Messages;

namespace Gefest.Actors.FileDownload;

public class FileDownloadActor 
    : ReceiveActor, IRequestHandler<DownloadRequestMessage>
{
    private Uri? _currentUri;
    private string? _currentTargetPath;
    private IActorRef? _currentDownloadRequester;
    
    public IStash? Stash { get; set; } = null;
    
    public FileDownloadActor() =>Become(Ready);

    public void Ready() => ReceiveAsync<DownloadRequestMessage>(Handler);

    public void Downloading()
    {
        Receive<DownloadRequestMessage>(OnRequest);
        Receive<DownloadCompletedMessage>(OnCompleteMsg);
    }

    private void OnCompleteMsg(DownloadCompletedMessage _)
    {
        Become(Ready);
        Stash?.UnstashAll();
    }

    private void OnRequest(DownloadRequestMessage _) => Stash?.Stash();

    private async Task Handler(DownloadRequestMessage message)
    {
        await HandleRequest(message);
        Become(Downloading);
    }

    public async Task HandleRequest(DownloadRequestMessage request)
    {
        _currentUri = request.Uri;
        _currentTargetPath = request.Path;
        _currentDownloadRequester = Sender;

        _currentDownloadRequester.Tell(new DownloadStartedMessage(_currentUri));
        
        await StartDownloadAsync();
    }
    
    private async Task StartDownloadAsync()
    {
        using var client = new HttpClient();
        await client.DownloadLargeFile(_currentUri?.AbsoluteUri!, _currentTargetPath!);

        _currentDownloadRequester.Tell(new DownloadCompletedMessage(_currentUri, _currentTargetPath));
        Become(Ready);
    }
}
