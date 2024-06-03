namespace MultiPage;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Item item)
	{
		InitializeComponent();
		BindingContext = item;
	}
}