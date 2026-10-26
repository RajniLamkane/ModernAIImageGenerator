using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Imagegenerator1.Services
{
    public class OpenAiImageService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public OpenAiImageService(IConfiguration configuration,HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        public async Task<string?> GenerateImageAsync(string prompt)
        {
            string? apiKey = _configuration["OpenAI:ApiKey"];

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new Exception("OpenAI API key is missing.");
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            var requestBody = new
            {
                model = "gpt-image-1",
                prompt = prompt,
                size = "1024x1024"
            };

            string json = JsonSerializer.Serialize(requestBody);

            using var content = new StringContent(json,Encoding.UTF8,"application/json");

            HttpResponseMessage response = await _httpClient.PostAsync("https://api.openai.com/v1/images/generations",content);

            string responseText = await response.Content.ReadAsStringAsync();

            
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"OpenAI Error ({(int)response.StatusCode}): {responseText}");
            }

            using JsonDocument document = JsonDocument.Parse(responseText);

            JsonElement data = document.RootElement.GetProperty("data")[0];

           
            if (data.TryGetProperty("b64_json",out JsonElement base64Element))
            {
                string? base64 = base64Element.GetString();

                if (!string.IsNullOrWhiteSpace(base64))
                {
                    return "data:image/png;base64," + base64;
                }
            }


            if (data.TryGetProperty("url",out JsonElement urlElement))
            {
                return urlElement.GetString();
            }

            throw new Exception("OpenAI returned a response, but no image data was found.");
        }
    }
}
