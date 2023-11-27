using Active_Directory_Toolbelt.utils;
using Newtonsoft.Json;
using Sentry.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Active_Directory_Toolbelt.handlers
{
    /// <summary>
    /// 
    /// Replace https://cyberark-instance/api/v1/accounts with the actual endpoint URL for creating user accounts in your CyberArk instance.
    /// Replace "your_api_token_here" with the API token generated in your CyberArk instance.
    /// Customize the requestBody JSON string based on the specific parameters required by the CyberArk API for creating user accounts.
    /// 
    /// </summary>
    internal class CyberArkHandler
    {   static async Task Main()
        {
            // Create HttpClient
            using (HttpClient client = new HttpClient())
            {

                // Prepare request body
                string requestBody = "{\"user\":\"newuser\",\"password\":\"P@ssw0rd\",\"additionalField\":\"value\"}"; // Edit to sute the scenario e.g delete or create account

                // Set authorization header
                client.DefaultRequestHeaders.Add("Authorization", value: $"Bearer {Reference.apiToken}");

                // Create HttpContent
                StringContent content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                try
                {
                    // Send POST request
                    HttpResponseMessage response = await client.PostAsync(Reference.apiUrl, content);

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("User account created successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
