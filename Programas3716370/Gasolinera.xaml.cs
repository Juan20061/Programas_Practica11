namespace Programas3716370;

public partial class Gasolinera : ContentPage
{
    public Gasolinera()
	{
		InitializeComponent();
	}   

    /// <summary>
    /// Al presionar este boton hara una conversion de galones a litros dependendiendo lo que haya digitado el usurio 
    /// para llevar esto acabo esto se hace uso de 3 variables la primera que tendra los litros que luego se pasana a galones
    /// para despues la segunda variable contenga el precio de cada galon para finalizar con la tercera variable que mostrara el resultado
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(entry1.Text, out double galones))
        {
            double litros = galones * 3.78541; 
            double precioPorGalon = 3.60; 
            double precioTotal = galones * precioPorGalon;

            entry2.Text = $"Litros: {litros:F2}, Precio a pagar: ${precioTotal:F2}";
        }
        else
        {
            entry2.Text = "Por favor, ingrese un valor válido en galones.";
        }
    }
}