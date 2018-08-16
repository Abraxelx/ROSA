using ROSA.Models;
using ROSA.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ROSA.Manager
{
    public class TopicItemManager
    {
        ITopicRestService topicRestService;

        public TopicItemManager(ITopicRestService service)
        {
            topicRestService = service;
        }

        public Task<String> GetTasksAsync()
        {
            return topicRestService.RefreshDataAsync();
        }

        public Task SaveTaskAsync(Topic item, bool isNewItem = false)
        {
            return topicRestService.SaveTopicAsync(item, isNewItem);
        }

        public Task DeleteTaskAsync(Topic item)
        {
            return topicRestService.DeleteTopicAsync(item.Code);
        }
    }
}
