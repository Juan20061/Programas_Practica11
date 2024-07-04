namespace Programas3716370;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}


    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(entry1.Text) &&
            !string.IsNullOrEmpty(entry2.Text) &&
            !string.IsNullOrEmpty(entry3.Text))
        {
            try
            {
                double pesoKg = Convert.ToDouble(entry2.Text);
                double alturaMts = Convert.ToDouble(entry3.Text);

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