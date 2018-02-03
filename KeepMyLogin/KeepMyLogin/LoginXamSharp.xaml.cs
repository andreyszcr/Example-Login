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
	public partial class LoginXamSharp : ContentPage
	{
        public static string NombreUsuario = "";
        ILoginManager iml = null;
        public LoginXamSharp (ILoginManager ilm)
		{
			InitializeComponent ();
            iml = ilm;
        }
        void btnLoginClick(object sender, EventArgs e)
        {
            NombreUsuario = Username.Text;
             
            App.Current.Properties["name"] = NombreUsuario;            
            App.Current.Properties["IsLoggedIn"] = true;

            iml.ShowMainPage();
        }

    }
}