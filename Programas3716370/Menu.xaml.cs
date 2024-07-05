namespace Programas3716370;



public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}
    //Evetno que te permite navegar al programa Cambio
    private async void Button_Clicked(object sender, EventArgs e)
    {
	await Navigation.PushAsync(new Cambio());
    }

    //Evetno que te permite navegar al programa Tiangulo
    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Triangulo());

    }
    //Evetno que te permite navegar al programa del Dinosaurio
    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Dinosaurio());

    }
    //Evetno que te permite navegar al programa Gasolinera
    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gasolinera());

    }
    //Evetno que te permite navegar a About
    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new About());
    }
}