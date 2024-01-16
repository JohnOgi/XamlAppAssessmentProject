using System.Text.Json;
using XamlAppAssessmentProject.Models;

namespace XamlAppAssessmentProject.Services
{
    public class VideoService : IVideoService
    {
        HttpClient client;
        JsonSerializerOptions serializerOptions;

        public VideoService()
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<List<Video>> GetVideos()
        {

            List<Video>? videos = null;
            var url = App.Current?.Resources["VideoServiceUrl"] as string;
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                videos = JsonSerializer.Deserialize<List<Video>>(content, serializerOptions);
            }

            await Task.Delay(3000);

            return videos ?? new List<Video>();
        }
    }
}
