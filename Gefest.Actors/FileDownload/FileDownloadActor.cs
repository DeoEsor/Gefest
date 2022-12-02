using Akka.Actor;
using Gefest.Actors.Extensions;
using Gefest.Contracts;
using Gefest.Domain.Messages.Download;

namespace Gefest.Actors.FileDownload;

public class FileDownloadActor 
    : ReceiveActor, IRequestHandler<DownloadRequestMessage>
{
    #region State

    private Uri? _currentUri;
    private string? _currentTargetPath;
    private IActorRef? _currentDownloadRequester;
    
    public IStash? Stash { get; set; } = null;


    #endregion
    
    #region Initialization

    public FileDownloadActor()
    {
        Become(Ready);
    }

    #endregion
    
    #region States

    public void Ready()
    {
        ReceiveAsync<DownloadRequestMessage>(Handler);
    }

    public void Downloading()
    {
        Receive<DownloadRequestMessage>(_ => Stash?.Stash());
        Receive<DownloadCompletedMessage>(_ => 
        {
            Become(Ready);
            Stash?.UnstashAll();
        });
    }

    #endregion
    
    #region Handlers
    
    private async Task Handler(DownloadRequestMessage message)
    {
        await HandleRequest(message);
        Become(Downloading);
    }

    public async Task HandleRequest(DownloadRequestMessage request)
    {
        _currentUri = request.Uri;
        _currentTargetPath = Path.GetTempFileName();
        _currentDownloadRequester = Sender;

        _currentDownloadRequester.Tell(new DownloadStartedMessage(_currentUri));
        
        await StartDownloadAsync();
    }
    
    private async Task StartDownloadAsync()
    {
        using var client = new HttpClient();
        await client.DownloadLargeFile("", "");

        _currentDownloadRequester.Tell(DownloadCompletedMessage.CreateMessage(_currentUri, _currentTargetPath));
        Become(Ready);
    }

    #endregion
}
