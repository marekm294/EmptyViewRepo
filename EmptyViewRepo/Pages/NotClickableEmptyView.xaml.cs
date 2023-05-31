namespace EmptyViewRepo.Pages;

using CommunityToolkit.Maui.Alerts;
using System.Threading.Tasks;

public partial class NotClickableEmptyView : ContentPage
{
    public NotClickableEmptyView()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Toast.Make("Button").Show();
    }
}