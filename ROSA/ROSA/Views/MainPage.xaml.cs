using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ROSA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}
        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async() => {
                var result = await this.DisplayAlert("Uyarı!", "ROSA'dan Çıkmak İstediğinize Emin Misiniz?", "Evet", "Hayır");
                if (result) await this.Navigation.PushAsync(new TabbedPage(),false);
                });
           return true;
           // return base.OnBackButtonPressed();    
        }
	}
}