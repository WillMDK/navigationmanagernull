namespace navigationmanagernull;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private void OnNavigateClicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new NavigationPage(new MainPage()),false);
    }
}

