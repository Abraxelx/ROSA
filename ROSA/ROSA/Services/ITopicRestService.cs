using ROSA.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ROSA.Services
{
    public interface ITopicRestService
    {
        Task<String> RefreshDataAsync();

        Task SaveTopicAsync(Topic item, bool isNewItem);

        Task DeleteTopicAsync(string id);
    }
}
