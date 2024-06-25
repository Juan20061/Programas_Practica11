namespace Programas3716370;

public partial class Triangulo : ContentPage
{
	public Triangulo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(entry1.Text) && !string.IsNullOrEmpty(entry2.Text))
        {            
                double baseTriangulo = Convert.ToDouble(entry1.Text);
                double alturaTriangulo = Convert.ToDouble(entry2.Text);

                double superficie = (baseTriangulo * alturaTriangulo) / 2;

                labelResultado.Text = $"La superficie del triángulo es: {superficie}";
        }
        else
        {
            DisplayAlert("ERROR", "Por favor, ingrese la base y la altura del triángulo.", "OK");
        }
    }
}