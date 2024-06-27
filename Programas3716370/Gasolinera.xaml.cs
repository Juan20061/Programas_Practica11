namespace Programas3716370;

public partial class Gasolinera : ContentPage
{
    //Este es el precio de la gasolina por litro 
    private const double PrecioPorLitro = 1.11;
    // Este es el factor de conversión de galones a litros
    private const double GalonesALitros = 3.78541; 

    public Gasolinera()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double galones;
        double peso;

        if (double.TryParse(entry1.Text, out galones) && double.TryParse(entry2.Text, out peso))
        {
            //Convertimos los galones a litros
            double litros = galones * GalonesALitros;

            //Calculamos el precio total
            double precioTotal = litros * PrecioPorLitro;

            //Mostramos el resultado 
            entry3.Text = $"${precioTotal:F2}";
        }
        else
        {
            DisplayAlert("Hubo un error al ingresar datos", "Por favor ingresa los valores correspondientes.", "Continuar");
        }
    }
}