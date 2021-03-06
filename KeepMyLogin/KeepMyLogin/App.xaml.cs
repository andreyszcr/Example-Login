using Xamarin.Forms;

namespace KeepMyLogin
{
	public partial class App : Application, ILoginManager
    {
        static ILoginManager loginManager;
        public static App Current;
        public static int val;
        public App ()
		{
			InitializeComponent();

            Current = this;
            var isLoggedIn = Properties.ContainsKey("IsLoggedIn") ? (bool)Properties["IsLoggedIn"] : false;
            if (isLoggedIn)


                MainPage = new Inicio();
            else
                MainPage = new LoginModalPage(this);

        }
        public void ShowMainPage()
        {
            MainPage = new Inicio();
        }

        public void Logout()
        {
            Properties["IsLoggedIn"] = false;
            MainPage = new LoginModalPage(this);
        }
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

    }
}
