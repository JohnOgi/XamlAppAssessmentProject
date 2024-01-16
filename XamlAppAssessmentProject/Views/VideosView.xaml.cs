using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using System.Runtime.CompilerServices;
using XamlAppAssessmentProject.ViewModels;

namespace XamlAppAssessmentProject.Views
{
    public partial class VideosView : ContentPage
    {
        private readonly IPopupService popupService;
        public VideosView(VideosViewModel viewModel, IPopupService popupService)
        {
            this.popupService = popupService;
            BindingContext = viewModel;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            var popup = new VideoDetails { BindingContext = button.BindingContext };
            this.ShowPopup(popup);
        }
    }
}
