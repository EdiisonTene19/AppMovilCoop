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
	public partial class Retiro : ContentPage
	{
		public Retiro (string usuario)
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

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}