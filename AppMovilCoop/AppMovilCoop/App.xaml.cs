using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovilCoop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Activacion de navegacion
            MainPage = new NavigationPage(new Login());
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
