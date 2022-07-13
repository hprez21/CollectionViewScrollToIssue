namespace CollectionViewScrollToIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		  BindingContext = new MainPageViewModel();
	}

	 private void Button_Clicked(object sender, EventArgs e)
	 {
          collectionView.ScrollTo(0, groupIndex:9);
     }

	 private void collectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
	 {

	 }
}

