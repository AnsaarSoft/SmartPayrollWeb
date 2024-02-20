using Client.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Client.CustomAuth
{
    public class AppAuthorization : AuthenticationStateProvider
    {
        private readonly AccountService oService;

        public AppAuthorization(AccountService service)
        {
            oService = service;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //var claims = await oService.GetLoginInfoAsync();
            //var claimsIdentity = claims.Count != 0
            //    ? new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme, "name", "role")
            //    : new ClaimsIdentity();
            await Task.Delay(1000);
            var claimsIdentity = new ClaimsIdentity();
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            return new AuthenticationState(claimsPrincipal);
        }
    }
}
