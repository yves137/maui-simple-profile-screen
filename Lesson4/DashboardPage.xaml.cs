using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
        
    }

    private async void OnOpenProfileClicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new ProfilePage());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    
}