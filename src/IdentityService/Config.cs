using Duende.IdentityServer.Models;

namespace IdentityService;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new("auctionApp", "Auction app full access")
        };

    public static IEnumerable<Client> Clients(IConfiguration configuration) =>
        new Client[]
        {
            new()
            {
                ClientId = "nextApp",
                ClientName = "nextApp",
                ClientSecrets = {new Secret(configuration["ClientSecret"].Sha256())},
                AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                RequirePkce = false,
                RedirectUris = {$"{configuration["ClientApp"]}/api/auth/callback/id-server"},
                AllowOfflineAccess = true,
                AllowedScopes = {"openid", "profile", "auctionApp"},
                AccessTokenLifetime = 3600*24*30,
                AlwaysIncludeUserClaimsInIdToken = true
            }
        };
}