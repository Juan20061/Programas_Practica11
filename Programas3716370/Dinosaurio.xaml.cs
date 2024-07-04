namespace Programas3716370;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}

    /// <summary>
    /// este evento clicked Convierte el peso de kilogramos a libras
    /// y la altura de metros a centímetros, luego muestra los resultados en los labels asignados
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {

        //condicionador que exige que los entry haya datos de lo contrario enviara un mensaje de advertencia
        if (!string.IsNullOrEmpty(entry1.Text) &&
            !string.IsNullOrEmpty(entry2.Text) &&
            !string.IsNullOrEmpty(entry3.Text))
        {
            try
            {
                //se les asigna a las variables una propiedad como en este caso cada variable pertenece a un entry
                double pesoKg = Convert.ToDouble(entry2.Text);
                double alturaMts = Convert.ToDouble(entry3.Text);

                //varialbes que contiene cada conversion
                double pesoLbs = pesoKg * 2.2046;
                double alturaCms = alturaMts * 100;

                labelResultadoPeso.Text = $"El peso en libras es: {pesoLbs} lbs";
                labelResultadoAltura.Text = $"La altura en centímetros es: {alturaCms} cm";
            }
            catch (FormatException)
            {
                DisplayAlert("ERROR", "Por favor, ingrese valores numéricos válidos para el peso y la altura.", "OK");
            }
        }
        else
        {
            DisplayAlert("ERROR", "Por favor, ingrese el nombre, peso y altura del dinosaurio.", "OK");
        }
    }
}