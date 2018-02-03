using Xamarin.Forms;
namespace KeepMyLogin
{
    public class User
    {
        public static string nombre = "";

        public User(string nombreU)
        {

            if (Application.Current.Properties.ContainsKey("name"))
            {
                var val = Application.Current.Properties["name"];
                nombre = val.ToString();
            }
            //nombre = AD_Login.NombreUsuario;
        }
        public string PrubeaNombre()
        {
            return nombre;
        }
    }
}
