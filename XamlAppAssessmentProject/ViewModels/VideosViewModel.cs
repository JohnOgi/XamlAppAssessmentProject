using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using XamlAppAssessmentProject.Models;
using XamlAppAssessmentProject.Services;

namespace XamlAppAssessmentProject.ViewModels
{
    public class VideosViewModel : INotifyPropertyChanged
    {
        private readonly IVideoService videoService;
        public VideosViewModel(IVideoService videoService)
        {
            this.videoService = videoService;

            AppearingCommand = new Command(Appearing);
        }

        public async void Appearing()
        {
            try
            {
                IsLoading = true;
                Videos = await videoService.GetVideos();
                IsLoading = false;
            }
            catch (Exception)
            {
                var mainPage = Application.Current?.MainPage;
                if (mainPage != null)
                {
                    await mainPage.DisplayAlert("An Error Occured", "Couldn't contact the video service.", "OK");
                }
                IsLoading = false;
            }
        }
        private bool isLoading;
        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                if (isLoading != value)
                {
                    isLoading = value;
                    OnPropertyChanged();
                }
            }
        }
        private List<Video>? videos;
        public List<Video>? Videos
        {
            get { return videos; }
            private set
            {
                if (videos != value)
                {
                    videos = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand AppearingCommand { get; private set; }
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
