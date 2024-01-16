using XamlAppAssessmentProject.Views;

namespace XamlAppAssessmentProject
{
    public partial class App : Application
    {
        public App(VideosView videosView)
        {
            InitializeComponent(); 
            MainPage = videosView;
        }
    }
}
