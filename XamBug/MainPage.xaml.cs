using System.Collections.ObjectModel;

namespace XamBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();
    }
}


