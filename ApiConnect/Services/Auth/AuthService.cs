using Models.Login;
using System.Net.Http.Json;

namespace ApiConnect.Services.Auth
{
    public class AuthService
    {
        private readonly HttpClient _http;

        public AuthService(HttpClient http)
        {
            _http = http;
        }
        public async Task<LoginResponse> Login(LoginViewModel model)
        {
            var response = await _http.PostAsJsonAsync("api/login/login", model);

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<LoginResponse>();
        }
    }
}
