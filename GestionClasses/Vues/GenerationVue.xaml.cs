using GestionClasses.VueModeles;

namespace GestionClasses.Vues;

public partial class GenerationVue : ContentPage
{
	GenerationVueModele vueModele;
	public GenerationVue()
	{
		BindingContext = vueModele = new GenerationVueModele();
		InitializeComponent();
	}
}