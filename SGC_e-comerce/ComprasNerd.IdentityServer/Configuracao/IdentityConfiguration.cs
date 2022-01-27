using Duende.IdentityServer.Models;

namespace ComprasNerd.IdentityServer.Configuracao
{
    public static class IdentityConfiguration
    {

        public const string Admin = "Admin";
        public const string Cliente = "Cliente";

         public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("ComprasNerd","Compras Nerd Server"),
                new ApiScope(name: "leitura","ler dados."),
                new ApiScope(name:"escrever","escrever dados."),
                new ApiScope(name: "exlcuir","excluir dados.")
            };

        public static IEnumerable<Client> Clients =>
        new List<Client> 
            { };
        
    }
}
