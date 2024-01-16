using System.ComponentModel;

namespace XamlAppAssessmentProject.Models
{
    public class Video
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? BulletText { get; set; }
        public string? Description { get; set; }
        public int? RunningTime { get; set; }

        public string? ArtUrl { get; set; }
    }
}
