using Xamarin.Forms;
namespace KeepMyLogin
{
    public class LoginModalPage : CarouselPage
    {
        ContentPage login;

        public LoginModalPage(ILoginManager ilm)
        {
            login = new LoginXamSharp(ilm);

            this.Children.Add(login);
            MessagingCenter.Subscribe<ContentPage>(this, "Login", (sender) =>
            {
                this.SelectedItem = login;
            });

        }
    }
}

