using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovilCoop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Deposito : ContentPage
	{
		public Deposito (string usuario)
		{
			InitializeComponent ();
            lblUsuario.Text = usuario;
            lblHora.Text = DateTime.Now.ToString("G");
        }

        private void btnConsultar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCanvelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}