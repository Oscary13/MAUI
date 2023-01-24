namespace MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//Pagina inicial de la aplicación
		//MainPage = new MainPage();
		var navPage = new NavigationPage(new MainPage());
		navPage.Background = Colors.Chocolate;
		navPage.BarTextColor= Colors.White;
		MainPage = new TabbedPageDemo();


		
	}
}
