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
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        // Lista de ventanas que se pueden abrir desde el menu, agregar mas en el Menu.xaml

        private void BTNEjercicio_1_1_Clicked(object sender, EventArgs e)
        {
            // Cambio de pagina hacia ejercicio_1_1
            Navigation.PushAsync(new Views.Ejercicio_1_1());
        }

        private void BTNEjercicio_1_2_Clicked(object sender, EventArgs e)
        {
            // Cambio de pagina hacia ejercicio_1_2
            Navigation.PushAsync(new Views.Ejercicio_1_2());
        }
    }
}