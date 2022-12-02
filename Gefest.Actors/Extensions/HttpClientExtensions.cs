namespace Gefest.Actors.Extensions;

public static class HttpClientExtensions
{
    public static async Task DownloadLargeFile(this HttpClient client, string url, string dist)
    {
        using var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
        await using var streamToReadFrom = await response.Content.ReadAsStreamAsync();
        await using var streamToWriteTo = File.Open(dist, FileMode.Create);
        await streamToReadFrom.CopyToAsync(streamToWriteTo);
    }
}