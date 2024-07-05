
namespace Programas3716370;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}
	/// <summary>
	/// Evento clicked que retorna el dinero sobrante al comprar un producto dependiento el costo y dinero dado
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
		//condicionador que pide se ingrese datos en todos los entry
		if(!string.IsNullOrEmpty(entry1.Text)&& !string.IsNullOrEmpty(entry2.Text))
		{
			//variables que contendran el dinero y costo el cambio
			double cambio, dinero, costo;

			dinero=Convert.ToDouble(entry1.Text);
			costo=Convert.ToDouble(entry2.Text);
			cambio = dinero - costo;
			entry3.Text = "Su cambio es de "+ cambio.ToString() + "$";

			//condicionador que indica que el dinero dado debe ser igual o mayor al costo del producto de lo contrario enviara un mensaje
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