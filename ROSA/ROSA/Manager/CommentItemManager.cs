using ROSA.Models;
using ROSA.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ROSA.Manager
{
    public class CommentItemManager
    {
        ICommentRestService commentRestService;


        public CommentItemManager(ICommentRestService service)
        {
            commentRestService = service;
        }

        public Task<List<Comment>> GetTasksAsync()
        {
            return commentRestService.RefreshDataAsync();
        }

        public Task SaveTaskAsync(Comment item, bool isNewItem = false)
        {
            return commentRestService.SaveCommentAsync(item, isNewItem);
        }

        public Task DeleteTaskAsync(Comment item)
        {
            return commentRestService.DeleteCommentAsync(item.Code);
        }
    }
}
