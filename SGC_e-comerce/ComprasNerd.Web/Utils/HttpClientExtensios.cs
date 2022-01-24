using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace ComprasNerd.Web.Utils
{
    public static class HttpClientExtensios
    {
        private static MediaTypeHeaderValue contentType 
            = new MediaTypeHeaderValue("application/json");
        public static async Task<T> ReadContextAs<T>
            (this HttpResponseMessage responde)
        {
            if (!responde.IsSuccessStatusCode) throw 
                    new ApplicationException(
                        $"Algo deu errado na API: " + 
                        $"{responde.ReasonPhrase}");
            var dataString = await responde.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(dataString,
                new JsonSerializerOptions
                { PropertyNameCaseInsensitive = true });

        }
        public static Task<HttpResponseMessage> PostAsJson<T>(
           this HttpClient httpClient,
           string url,
           T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = contentType;
            return httpClient.PostAsync(url, content);
        }

        public static Task<HttpResponseMessage> PutAsJson<T>(
            this HttpClient httpClient,
            string url,
            T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = contentType;
            return httpClient.PutAsync(url, content);
        }
    }
}
