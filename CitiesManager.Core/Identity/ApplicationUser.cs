using System;
using Microsoft.AspNetCore.Identity;

namespace CitiesManager.Core.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? PersonName { get; set; }

        public string? Refresh { get; set; }

        public DateTime? RefreshTokenExpriationDatetime { get; set; }
    }
}
