using AvaliaApi.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AvaliaApi.Services
{
    public partial class AvaliaApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _acessor;

        public AvaliaApiClient(HttpClient httpClient,
            IHttpContextAccessor accessor)
        {
            _httpClient = httpClient;
            _acessor = accessor;
        }

        public AvaliaApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<OAuthResult> LoginAsync(OAuth model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/OAuth", model);

            var oAuthResult = await response.Content.ReadAsJsonAsync<OAuthResult>();
            oAuthResult.Succeeded = response.IsSuccessStatusCode;

            AddBearerToken(oAuthResult.Token);

            return oAuthResult;
        }

        private void AddBearerToken()
        {
            if (_acessor != null)
            {
                var token = _acessor.HttpContext.User.Claims.SingleOrDefault(c => c.Type == "Token").Value;

                if (token == null)
                {
                    throw new ArgumentException("Token não foi salvo");
                }

                _httpClient.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", token);
            }
        }

        private void AddBearerToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<TResult> GetAsync<TResult>(string url)
        {
            AddBearerToken();
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsJsonAsync<TResult>();
        }

        public async Task<TResult> PostAsync<TResult, TPost>(string url, TPost model)
        {
            AddBearerToken();
            var response = await _httpClient.PostAsJsonAsync(url, model);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsJsonAsync<TResult>();
        }

        public async Task<TResult> PutAsync<TResult, TPost>(string url, TPost model)
        {
            AddBearerToken();
            var response = await _httpClient.PutAsJsonAsync(url, model);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsJsonAsync<TResult>();
        }

        public async Task DeleteAsync(string url)
        {
            AddBearerToken();
            var response = await _httpClient.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
        }

    }
}
