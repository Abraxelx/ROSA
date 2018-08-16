using System;
using Xamarin.Forms;
using ROSA.Views;
using Xamarin.Forms.Xaml;
using ROSA.Manager;
using ROSA.Services;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace ROSA
{
	public partial class App : Application
	{
        public static TopicItemManager TopicManager { get; private set; }
        public static CommentItemManager CommentItemManager { get; internal set; }

        public App ()
		{
			InitializeComponent();

            TopicManager = new TopicItemManager((new TopicRestService()));
            CommentItemManager = new CommentItemManager((new CommentRestService()));
            MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
