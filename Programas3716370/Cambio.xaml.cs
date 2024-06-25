
namespace Programas3716370;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(entry1.Text)&& !string.IsNullOrEmpty(entry2.Text))
		{
			double cambio, dinero, costo;

			dinero=Convert.ToDouble(entry1.Text);
			costo=Convert.ToDouble(entry2.Text);
			cambio = dinero - costo;
			entry3.Text = "Su cambio es de "+ cambio.ToString() + "$";

            if (dinero < costo)
            {
                DisplayAlert("ERROR", "El dinero dado es menor que el costo del articulo", "ok");
				entry3.Text = "Dinero insuficiente";

            }
        }
		
		else
		{
			DisplayAlert("ERROR", "Arregar los datos en cada entry", "ok");
		}
    }
}