using CommunityToolkit.Maui.Views;
using XamlAppAssessmentProject.Models;

namespace XamlAppAssessmentProject.Views;

public partial class VideoDetails : Popup
{
    public VideoDetails()
    {
        InitializeComponent();
    }

    void OnOKButtonClicked(object? sender, EventArgs e) => Close();
}
