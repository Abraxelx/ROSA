using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ROSA.Models;
using ROSA.Util;

namespace ROSA.Services
{
    public class TopicRestService : ITopicRestService
    {
        HttpClient client;

        public List<Topic> Items { get; private set; }


        public TopicRestService()
        {
            var authData = string.Format("{0}:{1}", Constants.Username, Constants.Password);
            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

            client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000
            };
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
        }
        
        public Task DeleteTopicAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<String> RefreshDataAsync()
        {
            Items = new List<Topic>();
            // Create the factory

            var uri = new Uri(string.Format(Constants.RestTopicUrl, string.Empty));
            Debug.WriteLine(uri);
            Console.WriteLine(uri);
            var topicTitle = "";
            try
            {
               
               
            
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    topicTitle = JsonUtil.GetJsonObjectForCode(content, "_embedded", "topic", "title");
                    
                    
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }

            return topicTitle;
         
        }

        public async Task SaveTopicAsync(Topic item, bool isNewItem)
        {
            var uri = new Uri(string.Format(Constants.RestTopicUrl, string.Empty));

            try
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                {
                    response = await client.PostAsync(uri, content);
                }
                else
                {
                    response = await client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"				Comment successfully saved.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
        }
    }


}
