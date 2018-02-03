using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KeepMyLogin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicio : ContentPage
	{
        private string nombreUsuario;
        public static string NombreUsuario;
        User model2 = new User(NombreUsuario);
        public Inicio ()
		{
            nombreUsuario = model2.PrubeaNombre();
            InitializeComponent ();
		}
        void btnLogoutClick(object sender, EventArgs e)
        {
            App.Current.Logout();
        }

    }
}