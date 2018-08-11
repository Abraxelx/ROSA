using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ROSA.Models;
using ROSA.Views;
using ROSA.ViewModels;

namespace ROSA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemsPage : ContentPage
	{
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();

        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }




        //Butonun Click ve Press Eventi 
        private void Btn_Clicked(object sender, EventArgs e)
        {
           (sender as Button).Text = "You Clicked";
            TestLabel.Text = "YouClick"; //TESTLABEL Ögesi Kontrol
            
        }
        private void Btn_Pressed(object sender, EventArgs e)
        {
            (sender as Button).Text = "You Pressed";
            TestLabel.Text = "YouPress";
        }
    }

}