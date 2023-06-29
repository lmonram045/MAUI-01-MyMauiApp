namespace MyMauiApp;

/**
 * Este archivo es el punto de entrada de la aplicación, es el primer archivo que se ejecuta cuando se inicia la aplicación.
 * Representa la aplicación en tiempo de ejecución. El constructor de esta clase crea una ventana inicial y le asigna la propiedad MainPage.
 * La propiedad MainPage determina que página se muestra cuando la aplicación comienza a ejecutarse.
 * Además, esta clase permite invalidar controladores comunes de eventos de ciclo de vida de aplicaciones neutros de plataforma.
 */
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    // Con los siguiente "override" puedo controlar el ciclo de vida de la aplicación e invalidar el comportamiento predeterminado
    // aunque por lo pronto solo hereda el comportamiento predeterminado de la clase base.
    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnResume()
    {
        base.OnResume();
    }

    protected override void OnSleep()
    {
        base.OnSleep();
    }
}
