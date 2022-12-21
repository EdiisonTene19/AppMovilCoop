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
	public partial class Menu : ContentPage
	{
		public Menu (string usuario)
		{
			InitializeComponent ();
			lblUsuario.Text = usuario;
            lblHora.Text = DateTime.Now.ToString("G");
		}

        private void btnDeposito_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRetiros_Clicked(object sender, EventArgs e)
        {

        }

        private void btnPagoCuotasCreditos_Clicked(object sender, EventArgs e)
        {

        }

        private void btnMovimientos_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCerrarSession_Clicked(object sender, EventArgs e)
        {

        }
    }
}