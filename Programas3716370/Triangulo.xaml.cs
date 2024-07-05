namespace Programas3716370;

public partial class Triangulo : ContentPage
{
	public Triangulo()
	{
		InitializeComponent();
	}
    /// <summary>
    /// Evento clicked que muestra la superficie de un tringualo dependiendo 
    /// la base y altura  este resultado se muestra por medio de un label
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
        //condicionador que valida si los entry estan vacios o completos
        if (!string.IsNullOrEmpty(entry1.Text) && !string.IsNullOrEmpty(entry2.Text))
        {    
            //variables que contiene cada entry y el proceso que tiene almacenado
                double baseTriangulo = Convert.ToDouble(entry1.Text);
                double alturaTriangulo = Convert.ToDouble(entry2.Text);

                double superficie = (baseTriangulo * alturaTriangulo) / 2;
            //label que muestra el resultado
                labelResultado.Text = $"La superficie del triángulo es: {superficie}";
        }
        else
        {
            DisplayAlert("ERROR", "Por favor, ingrese la base y la altura del triángulo.", "OK");
        }
    }
}