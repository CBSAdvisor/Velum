using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Velum.Web.Models;
using Velum.Web.NbrbApi.Models;

namespace Velum.Web.NbrbApi
{
    public class NbrbApiClient : INbrbApiClient
    {
        public const string MEDIA_TYPE_APPLICATION_JSON = "application/json";

        public const string BASE_URL = "https://www.nbrb.by/";
        public const string EP_GET_EXRATES_CURRENCIES = "/api/exrates/currencies";

        private readonly JsonSerializerSettings _jsonSettings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore
        };

        public Task<ApiCurrencyDto[]> GetCurrencies()
        {
            return SendGetRequest<ApiCurrencyDto[]>(EP_GET_EXRATES_CURRENCIES);
        }

        private async Task<T> SendGetRequest<T>(string url) where T : class
        {
            using (var http = new HttpClient { BaseAddress = new Uri(BASE_URL) })
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, url))
                {
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(MEDIA_TYPE_APPLICATION_JSON));

                    var response = await http.SendAsync(request).ConfigureAwait(false);
                    if (!response.IsSuccessStatusCode)
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        throw new HttpException((int)response.StatusCode, errorContent);
                    }

                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(content, _jsonSettings);
                }
            }
        }
    }
}