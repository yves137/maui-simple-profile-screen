using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Console.WriteLine("ProfilePage OnAppearing");
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        Console.WriteLine("ProfilePage OnDisappearing");
    }
    
    private async void OnGoBackClicked(
        object sender,
        EventArgs e)
    {
        await Navigation.PopAsync();
    }
}