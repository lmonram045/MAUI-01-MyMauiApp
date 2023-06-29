namespace MyMauiApp;

/**
 * Este es el código subyacente de la página. En este archivo se define la lógica 
 * para los distintos controladores de eventos y otras acciones desencadenadas por 
 * los controles de la página. El código de ejemplo implementa un controlador para 
 * el evento Clicked para el botón en la página. El código simplemente incrementa 
 * una variable de recuento y muestra el resultado en una etiqueta en la página. 
 * El servicio semántico proporcionado como parte de la biblioteca MAUI Essentials 
 * admite la accesibilidad. El método estático Announce de la clase SemanticScreenReader 
 * especifica el texto anunciado por un lector de pantalla cuando el usuario selecciona el botón:
 */
public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

