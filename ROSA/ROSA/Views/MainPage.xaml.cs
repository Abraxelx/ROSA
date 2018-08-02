using System;
using System.Threading;
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
                if (result)
                {
#if __ANDROID__
                System.Diagnostics.Process.GetCurrentProcess().Kill();

#endif
#if __IOS__
                    Thread.CurrentThread.Abort();
#endif
                }
            });
           return true; 
           // return base.OnBackButtonPressed();    
        }
	}
}