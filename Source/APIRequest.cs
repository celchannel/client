using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Celeste.Mod.CelesteChannel;

public abstract class APIRequest
{
    private static readonly HttpClient client = new HttpClient();

    [JsonIgnore]
    protected abstract string Target { get; }

    // TODO: catch exceptions
    public void Perform()
    {
        Uri baseUri = new Uri(CelesteChannelModule.Settings.ServerURL);

        HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, new Uri(baseUri, Target));
        req.Headers.Authorization = new AuthenticationHeaderValue("Bearer", CelesteChannelModule.Settings.Token);

        req.Content = new StringContent(JsonSerializer.Serialize<object>(this));

        client.SendAsync(req);
    }
}