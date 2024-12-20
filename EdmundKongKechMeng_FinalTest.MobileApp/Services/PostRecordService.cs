using EdmundKongKechMeng_FinalTest.MobileApp.Models;
using Newtonsoft.Json;

namespace EdmundKongKechMeng_FinalTest.MobileApp.Services;

public class PostRecordService 
{
    private readonly HttpClient _httpClient;


    public async Task<IEnumerable<PostRecord>> GetPostRecord()
    {
        HttpResponseMessage response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");

        if (response.IsSuccessStatusCode)
        {
            string reponsecontent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<PostRecord>>(reponsecontent);
        }
        else
        {
            Console.WriteLine($"API request failed with status code: {response.StatusCode}");
        }
        return null;

    }
}
