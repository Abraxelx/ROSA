using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using ROSA.Models;
using ROSA.Views;
using System.Collections.Generic;

namespace ROSA.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Topic> Items { get; set; }
        public List<Comment> ItemCommentList { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "BİRİNCİ SÖZ";
            Items = new ObservableCollection<Topic>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Topic>(this, "Item Ekle", async (obj, item) =>
            {
                var _item = item as Topic;
                Items.Add(_item);
                await App.TopicManager.SaveTaskAsync(_item,true);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
      
            try
            {

                ItemCommentList = await App.CommentItemManager.GetTasksAsync();

                foreach (var item in ItemCommentList)
                {
                    ItemCommentList.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}