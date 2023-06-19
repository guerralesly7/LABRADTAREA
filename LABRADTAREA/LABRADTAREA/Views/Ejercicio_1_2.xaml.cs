using LABRADTAREA.Models;
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
	public partial class Ejercicio_1_2 : ContentPage
	{
		public Ejercicio_1_2 ()
		{
			InitializeComponent ();
		}

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            // Comprobar textos varios o continuar a resultado
            if (string.IsNullOrEmpty(txt_Nombre.Text) || string.IsNullOrEmpty(txt_Apellido.Text) || string.IsNullOrEmpty(txt_Edad.Text) || string.IsNullOrEmpty(txt_Correo.Text))
            {
                DisplayAlert("Error", "Completar todos los campos.", "Aceptar");
            }
            else
            {
                // Inicialización de clase persona para mandar al bindigcontext
                Persona persona = new Persona()
                {
                    Nombre = txt_Nombre.Text,
                    Apellido = txt_Apellido.Text,
                    Edad = int.Parse(txt_Edad.Text),
                    Correo = txt_Correo.Text
                };

                // Envio de datos a el BindingContext con la clase persona
                Navigation.PushAsync(new Ejercicio_1_2_resultado() { BindingContext = persona });
            }
        }
    }
}