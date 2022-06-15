using Inspecco_UI.Helpers;
using Inspecco_UI.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace Inspecco_UI.Api
{
    public class Request : IRequest
    {

        #region Fields
        private readonly BaseUrl _config;
        private System.Net.Http.HttpClient _httpClient;
        private readonly ISessionHelper _sessionHelper;
        #endregion

        #region Ctor
        public Request(BaseUrl config,
                       System.Net.Http.HttpClient client,
                       ISessionHelper sessionHelper)
        {
            _config = config;
            _httpClient = client;
            _httpClient.BaseAddress = new Uri(Tools.GetApiUrl);
            _httpClient.Timeout = TimeSpan.FromSeconds(200);
            _sessionHelper = sessionHelper;
        }
        #endregion

        #region CallApiAsync
        public async Task<T> GetPageAsync<T>(string PageKey, string token, string controllerAdress)
        {

            var adres = string.Concat(_httpClient.BaseAddress, "api/", controllerAdress);
            var response = await _httpClient.GetAsync(adres);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<T>().Result;
            }
            else
            {
                return default;
            }
        }
        public async Task<T> GetAsync<T>(string token, string controllerAdress)
        {

            var adres = string.Concat(_httpClient.BaseAddress, "api/", controllerAdress);
            var response = await _httpClient.GetAsync(adres);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<T>().Result;
            }
            else
            {
                return default;
            }
        }

        public async Task<bool> PostAsync<T>(string token, string controllerAdress, T model)
        {
            var adres = string.Concat(_httpClient.BaseAddress, "api/", controllerAdress);
            var response = await _httpClient.PostAsJsonAsync(adres, model);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<T> PostAndGetAsync<T>(string token, string controllerAdress, T model)
        {

            var adres = _httpClient.BaseAddress + "api/" + controllerAdress;
            var response = await _httpClient.PostAsJsonAsync(adres, model);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if (response.IsSuccessStatusCode)

                return response.Content.ReadAsAsync<T>().Result;
            else
                return default;
        }
        #endregion

    }
}
