namespace Lesson3Experiment_B;

public partial class MainPage : ContentPage
{
    private int _counter;
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnAddLabelClicked(object? sender, EventArgs e)
    {
       _counter++;
       var label = new Label
       {
           Text = $"Dynamic Label #{_counter}",
           FontSize = 18
       };
       MainLayout.Children.Add(label);
       MessageLabel.Text = $"Dynamic Label #{_counter} was added";
    }
}