using Microsoft.AspNetCore.Identity;

namespace ComprasNerd.IdentityServer.Model.Context
{
    public class ApplicationUser : IdentityUser
    {

        private string FirstName { get; set;}

        private string LastName { get; set;}


    }
}
