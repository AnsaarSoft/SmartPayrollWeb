using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using SharedLibrary.ViewModels;

namespace Client.Services
{
    public class AccountService
    {
        #region Variable

        private const string AccessToken = nameof(AccessToken);
        private const string RefreshToken = nameof(RefreshToken);

        private readonly ProtectedLocalStorage oStorage;
        private readonly NavigationManager oNavigation;
        private readonly IConfiguration oConfiguration;
        private readonly HttpClient oClient;

        public AccountService(ProtectedLocalStorage storage, NavigationManager navigation, IConfiguration config, HttpClient client)
        {
            oStorage = storage;
            oNavigation = navigation;
            oConfiguration = config;
            oClient = client;
        }

        public async Task<bool> LoginAsync(MstUser model)
        {
            var response = await oClient.PostAsJsonAsync<string>(oConfiguration.GetValue<string>("ApiService") + "validateuser", JsonConvert.SerializeObject(model));
            ApiResponse? apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse>();    
            if(apiResponse is null) { return false; }
            vmLogin? login = apiResponse.Data as vmLogin;
            await oStorage.SetAsync(AccessToken, login.JwtToken);
            await oStorage.SetAsync(RefreshToken, login.JwtToken);
            return true;
        }


        #endregion
    }
}
