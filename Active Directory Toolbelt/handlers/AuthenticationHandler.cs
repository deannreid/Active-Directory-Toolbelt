using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Microsoft.Identity.Client;

namespace Active_Directory_Toolbelt.handlers
{

    public partial class AuthenticationHandler
    {
      /*  private const string TokenFilePath = "token.txt";
        private const string ClientId = "your-client-id"; // Replace with your Azure AD application's client ID
        private const string Authority = "https://login.microsoftonline.com/common";

        static async Task Main(string[] args)
        {
            var (clientId, tenantId) = await GetClientIdAndTenantId();
            var token = await GetToken(clientId, tenantId);

            if (!string.IsNullOrEmpty(token))
            {
                Console.WriteLine($"Token: {token}");
                // Now you can use the token to call Azure functions or APIs

                // Example: CallAzureFunction(token);
            }

            Console.ReadLine();
        }

        static async Task<(string clientId, string tenantId)> GetClientIdAndTenantId()
        {
            var cca = ConfidentialClientApplicationBuilder
                .Create(ClientId)
                .WithAuthority(new Uri(Authority))
                .Build();

            var authResult = await cca.AcquireTokenInteractive(new[] { "user.read" }) // Replace with your desired scope
                .WithUseEmbeddedWebView(true)
                .ExecuteAsync();

            return (authResult.Account.HomeAccountId.ObjectId, authResult.TenantId);
        }

        static async Task<string> GetToken(string clientId, string tenantId)
        {
            string[] scopes = { "https://graph.microsoft.com/.default" }; // Replace with your desired scope

            var options = new TokenCredentialOptions
            {
                AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
            };

            var tokenCredential = new InteractiveBrowserCredential(options);

            try
            {
                var result = await tokenCredential.GetTokenAsync(new TokenRequestContext(scopes));
                SaveToken(result.Token);
                return result.Token;
            }
            catch (MsalServiceException ex)
            {
                Console.WriteLine($"Error acquiring token: {ex.Message}");
                return null;
            }
        }

        static void SaveToken(string token)
        {
            // Store the token securely, for example, in a file
            File.WriteAllText(TokenFilePath, token);
        }

        static void CallAzureFunction(string token)
        {
            // Implement your logic to call Azure functions using the token
        }*/
    }
}