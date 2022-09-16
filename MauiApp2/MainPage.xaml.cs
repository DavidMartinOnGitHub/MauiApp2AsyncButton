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

    private void OnClickedProperties(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine($"{this.T1.Text.PadRight(10)} {this.T1.BackgroundColor.ToRgbaHex(false)} {this.T1.IsPressed}");
        System.Diagnostics.Debug.WriteLine($"{this.T2.Text.PadRight(10)} {this.T2.BackgroundColor.ToRgbaHex(false)} {this.T2.IsPressed}");
        
    }
}

