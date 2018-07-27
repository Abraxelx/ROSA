using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace ROSA.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Hakkında";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xelcode.blogspot.com")));
        }

        public ICommand OpenWebCommand { get; }
    }
}