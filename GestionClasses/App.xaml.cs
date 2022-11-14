using GestionClasses.Vues;

namespace GestionClasses;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new GenerationVue();
	}
}
