using MauiApp2.ViewModel;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
	int count = 0;

    public MainPage(MainPageViewModel viewmodel)
    {
        InitializeComponent();
        this.BindingContext = viewmodel;
    }

}

