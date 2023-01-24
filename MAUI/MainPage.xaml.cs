namespace MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//Agregar una pagina a la pila de navegacion
		Navigation.PushAsync(new ContenPageDemo());
	}
}

