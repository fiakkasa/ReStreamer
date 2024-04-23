using Microsoft.AspNetCore.Mvc;

namespace ReStreamer.Controllers;

[ApiController]
[Route("[controller]")]
public class StreamController : ControllerBase
{
    [HttpGet]
    public async Task<Stream> Get(
        [FromServices] IHttpClientFactory httpClientFactory, 
        [FromQuery] Uri url, 
        CancellationToken cancellationToken
    )
    {
        using var httpClient = httpClientFactory.CreateClient(Consts.UrlReStreamerHttpClient);

        var info = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, url), cancellationToken);

        info.EnsureSuccessStatusCode();
        
        Response.Headers.ContentType = info.Content.Headers.ContentType?.ToString() ?? "application/octet-stream";
        Response.Headers.ContentLength = info.Content.Headers.ContentLength;

        return await httpClient.GetStreamAsync(url, cancellationToken);
    }
}
