using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Pokedex
{
    public class ApiPokemon
    {
        private static ApiPokemon _service;
        private readonly HttpClient _httpClient;

        public ApiPokemon()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://pokeapi.co/api/v2/") };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static ApiPokemon Instace()
        {
            if (_service == null)
                _service = new ApiPokemon();

            return _service;
        }

        public async Task<string> GetRequest(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }
    }
}
