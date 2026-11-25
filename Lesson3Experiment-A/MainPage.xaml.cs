namespace Lesson3Experiment_A;

public class MainPage : ContentPage
{
    
    public MainPage()
    {
        var label = new Label
        {
            Text = "Creating UI using C#, no XAML!",
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center
        };

        var button = new Button
        {
            Text = "Click Me",
        };
        
        button.Clicked += (_, _) =>
        {
            label.Text = "You clicked the button!";
        };

        var layout = new VerticalStackLayout
        {
            Padding = 30,
            Spacing = 20,
            Children =
            {
                label,
                button
            }
        };
        
        Content = layout;
    }

}