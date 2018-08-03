using ROSA.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ROSA.Services
{
    interface ICommentRestService
    {
         Task<List<Comment>> RefreshDataAsync();

        Task SaveCommentAsync(Comment item, bool isNewItem);

        Task DeleteCommentAsync(string id);
    }
}
