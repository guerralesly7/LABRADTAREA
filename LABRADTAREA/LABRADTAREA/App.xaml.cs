using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LABRADTAREA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Inicializar el menu como primera pagina, para no que cambiar y compilar
            MainPage = new NavigationPage(new Views.Menu());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
