using CitiesManager.Core.DTO;
using CitiesManager.Core.Identity;
using System;
using System.Security.Claims;


namespace CitiesManager.Core.ServiceContracts
{
    public interface IJwtService
    {
      public  AuthenticationResponse CreateJwtToken(ApplicationUser user);

      ClaimsPrincipal? GetPrincipalFromJwtToken(string? Token);
    }
}
