using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorLogin.Services;

public class SimpleAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly ClaimsPrincipal _anonymous = new(new ClaimsIdentity());
    private ClaimsPrincipal _currentPrincipal;

    public SimpleAuthenticationStateProvider()
    {
        _currentPrincipal = _anonymous;
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
        => CreateAuthenticationState();

    public Task<bool> LoginAsync(string username, string password)
    {
        if (username == "admin" && password == "admin")
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, username)
            }, authenticationType: "SimpleAuth");

            _currentPrincipal = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(CreateAuthenticationState());
            return Task.FromResult(true);
        }

        _currentPrincipal = _anonymous;
        NotifyAuthenticationStateChanged(CreateAuthenticationState());
        return Task.FromResult(false);
    }

    public Task LogoutAsync()
    {
        _currentPrincipal = _anonymous;
        NotifyAuthenticationStateChanged(CreateAuthenticationState());
        return Task.CompletedTask;
    }

    private Task<AuthenticationState> CreateAuthenticationState()
        => Task.FromResult(new AuthenticationState(_currentPrincipal));
}
