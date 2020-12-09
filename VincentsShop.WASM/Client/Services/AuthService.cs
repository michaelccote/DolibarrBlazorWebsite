using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using VincentsShop.WASM.Shared.Models;

namespace VincentsShop.WASM.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        //public async Task<RegisterResult> Register(RegisterModel registerModel)
        //{
        //    var result = await _httpClient.PostJsonAsync<RegisterResult>("api/accounts", registerModel);

        //    return result;
        //}

        public async Task<LoginResponse> Login(LoginModel loginModel)
        {
            Usager usager = new Usager()
            {
                login = loginModel.User,
                password = loginModel.Password,
                confirmPassword = loginModel.Password
            };           
            var json = JsonSerializer.Serialize(usager);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            Console.WriteLine(await data.ReadAsStringAsync());
            var response = await _httpClient.PostAsync("api/Login", data);
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            LoginResponse loginResult = JsonSerializer.Deserialize<LoginResponse>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (!response.IsSuccessStatusCode)
            {
                return loginResult;
            }

            await _localStorage.SetItemAsync("authToken", loginResult.JwtToken);
            //if (loginModel.company != null) { await _localStorage.SetItemAsync("companyID", loginModel.company.Id)};
            //var name = await _localStorage.GetItemAsync<int>("companyID");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginModel.User);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.JwtToken);
            loginResult.Successful = true;
            return loginResult;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<string> GetLoggedUser()
        {
            return (await _authenticationStateProvider.GetAuthenticationStateAsync()).User.Identity.Name;
        }

    }

}
