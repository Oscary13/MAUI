namespace MAUI;

public partial class ContenPageDemo : ContentPage
{
	public ContenPageDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}