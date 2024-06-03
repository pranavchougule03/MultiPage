namespace MultiPage
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            List<Item> ItemList = new List<Item>
            {
                new Item { ID = "1", Name = "First", Description = "This is the first item", ImageSource = "dotnet_bot.png" },
                new Item { ID = "2", Name = "Second", Description = "This is the second item", ImageSource = "dotnet_bot.png" }
            };

            InitializeComponent();
            collectionView.ItemsSource = ItemList;

        }
        private async void OnFrameTapped(object sender, EventArgs e)
        {
            var frame = (Frame)sender;
            var frameContext = frame.BindingContext;
            if (frameContext != null)
            {
                await Navigation.PushAsync(new DetailsPage((Item)frameContext));
            }
        }
    }

}
