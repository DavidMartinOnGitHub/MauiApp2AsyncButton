using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task TestSomethingAsync()
        {
            await Task.Delay(1);
            //await Task.Delay(1).ConfigureAwait(false);
            //await Task.Delay(1).ConfigureAwait(true);

            System.Diagnostics.Debug.WriteLine(nameof(TestSomethingAsync));
        }

        [RelayCommand]
        void TestMore()
        {
            System.Diagnostics.Debug.WriteLine(nameof(TestMore));
        }
    }
}
