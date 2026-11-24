namespace MauiApp2;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnUpdateBtnClicked(object? sender, EventArgs e)
    {
        if (!UserNames.Text.IsWhiteSpace())
            ProfileName.Text = UserNames.Text;
    }
}