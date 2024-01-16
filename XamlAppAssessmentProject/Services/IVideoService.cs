using XamlAppAssessmentProject.Models;

namespace XamlAppAssessmentProject.Services
{
    public interface IVideoService
    {
        public Task<List<Video>> GetVideos();
    }
}
