namespace MauiBorderBackgroundIOS;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		Do().ConfigureAwait(false);
	}

	private async Task Do()
    {
		await Task.Delay(2000);
		third.StrokeThickness = 0;
    }
}

