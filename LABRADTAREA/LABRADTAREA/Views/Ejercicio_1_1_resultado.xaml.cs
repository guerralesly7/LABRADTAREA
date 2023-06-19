using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LABRADTAREA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Ejercicio_1_1_resultado : ContentPage
	{
		// Agregar un paramaetro al inicializador de la clase para que acepte resultados
		public Ejercicio_1_1_resultado (double Resultado)
		{
			InitializeComponent ();

            // Mandar a la variable del xaml el resultado obtenido de la clase Calculadora desde el constructor
            ResultadoFinal.Text = $"Resultado: {Resultado}";
        }
    }
}