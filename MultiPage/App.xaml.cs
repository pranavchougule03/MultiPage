namespace MultiPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // adding a sample comment for testing pourpose.

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
