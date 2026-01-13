using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Proj_bazy.Models;
using System.Security.Claims;

public class MyUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser>
{
    public MyUserClaimsPrincipalFactory(UserManager<ApplicationUser> userManager, IOptions<IdentityOptions> optionsAccessor)
        : base(userManager, optionsAccessor)
    {
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
    {
        var identity = await base.GenerateClaimsAsync(user);
        // Pobieramy wartość z Twojej kolumny Role i dodajemy ją jako Claim
        if (!string.IsNullOrEmpty(user.Role))
        {
            identity.AddClaim(new Claim(ClaimTypes.Role, user.Role));
        }
        return identity;
    }
}