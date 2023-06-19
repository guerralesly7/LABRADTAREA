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
	public partial class Ejercicio_1_1 : ContentPage
	{
        static Controllers.Calculadora calculadora = new Controllers.Calculadora();

        public Ejercicio_1_1 ()
		{
			InitializeComponent ();
		}

        private void btnSuma_Clicked(object sender, EventArgs e)
        {
            // Comprobar datos vacios
            if (string.IsNullOrEmpty(Numero1.Text) || string.IsNullOrEmpty(Numero2.Text))
            {
                DisplayAlert("Error", "Completar todos los campos.", "Aceptar");
            }
            else
            {
                // Pasar los datos a double para enviarlos a la clase calculadora en las funciones respectivas
                double n1 = double.Parse(Numero1.Text);
                double n2 = double.Parse(Numero2.Text);

                // Cambio de pagina y muestra de resultado en la segunda pagina
                Navigation.PushAsync(new Ejercicio_1_1_resultado(calculadora.Suma(n1, n2)));
            }
        }

        private void btnResta_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Numero1.Text) || string.IsNullOrEmpty(Numero2.Text))
            {
                DisplayAlert("Error", "Completar todos los campos.", "Aceptar");
            }
            else
            {
                double n1 = double.Parse(Numero1.Text);
                double n2 = double.Parse(Numero2.Text);

                Navigation.PushAsync(new Ejercicio_1_1_resultado(calculadora.Resta(n1, n2)));
            }
        }

        private void btnDivision_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Numero1.Text) || string.IsNullOrEmpty(Numero2.Text))
            {
                DisplayAlert("Error", "Completar todos los campos.", "Aceptar");
            }
            else
            {
                double n1 = double.Parse(Numero1.Text);
                double n2 = double.Parse(Numero2.Text);

                Navigation.PushAsync(new Ejercicio_1_1_resultado(calculadora.Divicion(n1, n2)));
            }
        }

        private void btnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Numero1.Text) || string.IsNullOrEmpty(Numero2.Text))
            {
                DisplayAlert("Error", "Completar todos los campos.", "Aceptar");
            }
            else
            {
                double n1 = double.Parse(Numero1.Text);
                double n2 = double.Parse(Numero2.Text);

                Navigation.PushAsync(new Ejercicio_1_1_resultado(calculadora.Multiplicacion(n1, n2)));
            }
        }
    }
}