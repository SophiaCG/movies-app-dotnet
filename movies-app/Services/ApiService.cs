using System;
using System.Net.Http;
using System.Threading.Tasks;
using movies_app.Models;
using Microsoft.Extensions.Configuration;
namespace movies_app.Services // Replace YourNamespace.Services with your actual namespace
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            _client = new HttpClient();
        }

        public async Task<string> GetPopularMovies()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("secrets.json")
                .Build();

            var apiKey = configuration["ApiKey"];

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.themoviedb.org/3/movie/popular?language=en-US&page=1"),
                Headers =
                {
                    { "accept", "application/json" },
                    { "Authorization", $"Bearer {apiKey}" },
                },
            };

            try
            {
                using (var response = await _client.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {

                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        // Handle unsuccessful HTTP response
                        throw new HttpRequestException($"The HTTP request failed with status code: {response.StatusCode}");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                // Log the exception or perform any other error handling
                Console.WriteLine($"An HTTP request exception occurred: {ex.Message}");
                throw; // Rethrow the exception
            }
            catch (Exception ex)
            {
                // Handle any other exceptions that might occur
                Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
                throw; // Rethrow the exception
            }
        }
    }
}
