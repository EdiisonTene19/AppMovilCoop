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
	public partial class MovimientoCaja : ContentPage
	{
		public MovimientoCaja (string usuario)
		{
			InitializeComponent ();
            lblUsuario.Text = usuario;
            lblHora.Text = DateTime.Now.ToString("G");
        }
	}
}