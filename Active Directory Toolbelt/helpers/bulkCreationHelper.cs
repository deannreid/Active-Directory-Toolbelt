using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Active_Directory_Toolbelt.helpers
{
    using System;
    using System.Collections.Generic;
    using System.DirectoryServices.AccountManagement;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main()
        {
            // Replace these values with your Azure AD, CyberArk, and Active Directory details
            string azureApiUrl = "https://graph.microsoft.com/v1.0/users";
            string azureToken = "your_azure_api_token_here";

            string cyberArkApiUrl = "https://cyberark-instance/api/v1/accounts";
            string cyberArkToken = "your_cyberark_api_token_here";

            string adDomain = "yourdomain.local";
            string adAdminUsername = "administrator";
            string adAdminPassword = "admin_password";

            // Read user information from CSV file
            List<UserInfo> users = ReadUsersFromCsv("user_accounts.csv");

            // Process each user
            foreach (var user in users)
            {
                // Create user in Azure AD
                await CreateUserInAzureAD(azureApiUrl, azureToken, user);

                // Create user in CyberArk
                await CreateUserInCyberArk(cyberArkApiUrl, cyberArkToken, user);

                // Create user in Active Directory
                CreateUserInActiveDirectory(adDomain, adAdminUsername, adAdminPassword, user);
            }

            Console.WriteLine("User accounts created successfully.");
        }

        static List<UserInfo> ReadUsersFromCsv(string filePath)
        {
            // Implement CSV reading logic and return a list of UserInfo objects
            // Example: Read CSV using a library like CsvHelper or parse manually

            // For simplicity, assuming CSV format is: Username,Password,Group
            // Adapt this based on the actual CSV structure
            List<UserInfo> users = new List<UserInfo>();

            // Example CSV data
            // Username,Password,Group
            // user1,P@ssw0rd1,Group1
            // user2,P@ssw0rd2,Group2

            // Read CSV and populate the users list
            // ...

            return users;
        }

        static async Task CreateUserInAzureAD(string apiUrl, string token, UserInfo user)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                // Create user object for Azure AD
                var newUser = new
                {
                    accountEnabled = true,
                    displayName = user.Username,
                    userPrincipalName = $"{user.Username}@yourdomain.onmicrosoft.com",
                    passwordProfile = new
                    {
                        password = user.Password,
                        forceChangePasswordNextSignIn = false
                    }
                };

                // Convert to JSON
                string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(newUser);

                // Send POST request to create user
                HttpResponseMessage response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

                // Check if the request was successful
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error creating user in Azure AD: {response.ReasonPhrase}");
                }
            }
        }

        static async Task CreateUserInCyberArk(string apiUrl, string token, UserInfo user)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                // Create user object for CyberArk
                var newUser = new
                {
                    user = user.Username,
                    password = user.Password,
                    additionalField = user.Group
                };

                // Convert to JSON
                string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(newUser);

                // Send POST request to create user
                HttpResponseMessage response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

                // Check if the request was successful
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error creating user in CyberArk: {response.ReasonPhrase}");
                }
            }
        }

        static void CreateUserInActiveDirectory(string domain, string adminUsername, string adminPassword, UserInfo user)
        {
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, domain, adminUsername, adminPassword))
                {
                    // Create a new user principal object
                    UserPrincipal userPrincipal = new UserPrincipal(context)
                    {
                        SamAccountName = user.Username,
                        UserPrincipalName = $"{user.Username}@{domain}",
                        DisplayName = user.Username,
                        Enabled = true
                    };

                    // Set the user's password
                    userPrincipal.SetPassword(user.Password);

                    // Save the user to Active Directory
                    userPrincipal.Save();

                    Console.WriteLine($"User '{user.Username}' created in Active Directory.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating user in Active Directory: {ex.Message}");
            }
        }

        // Define a class to hold user information
        class UserInfo
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Group { get; set; }
        }
    }
}
