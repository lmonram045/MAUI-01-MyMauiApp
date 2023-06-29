using Microsoft.Extensions.Logging;

namespace MyMauiApp;

/**
 * Cada plataforma nativa tiene un punto de partida diferente que crea e inicializa la aplicación. 
 * Encontrará este código en la carpeta Plataformas del proyecto. Este código es específico de la 
 * plataforma, pero al final llama al método CreateMauiApp de la clase estática MauiProgram. Use 
 * el método CreateMauiApp para configurar la aplicación mediante la creación de un objeto generador 
 * de aplicaciones. Como mínimo, debe especificar qué clase describe la aplicación. Esto se hace con 
 * el método genérico UseMauiApp del objeto generador de aplicaciones; el parámetro tipo especifica 
 * la clase de aplicación. El generador de aplicaciones también proporciona métodos para tareas como 
 * el registro de fuentes, la configuración de servicios para la inserción de dependencias, el registro 
 * de controladores personalizados para los controles y mucho más. El código siguiente muestra un ejemplo 
 * de uso del generador de aplicaciones para registrar una fuente:
 */
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			// ConfigureFonts registrará las fuentes agregadas a la carpeta fuentes con el objeto generador de aplicaciones
			// cuando la aplicación empiece a ejecutarse.
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
