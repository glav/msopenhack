using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MinecraftWeb.Infrastructure
{
    public class MineKubeApiClient : IDisposable
    {
        private readonly HttpClient _client;
        private readonly HttpClientHandler _handler;
        private readonly string _token;

        public MineKubeApiClient(string baseUrl, string token)
        {
            _token = token;
            _handler = new HttpClientHandler();
            _handler.ServerCertificateCustomValidationCallback += (sender, cert, chain, ssl) => true;

            _client = new HttpClient(_handler)
            {
                BaseAddress = new Uri(baseUrl)
            };

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<dynamic> GetServicesAync()
        {
            return await GetAsync<JToken>("api/v1/services");
        }

        public async Task<JToken> CreateServiceAsync()
        {
            return await PostAsync<JToken>("/api/v1/namespaces/{namespace}/services");
        }

        private async Task<T> PostAsync<T>(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var @object = JsonConvert.DeserializeObject<T>(content);

            return @object;
        }

        private async Task<T> GetAsync<T>(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var @object = JsonConvert.DeserializeObject<T>(content);

            return @object;
        }

        public void Dispose()
        {
            _client.Dispose();
            _handler.Dispose();
        }
    }
}
