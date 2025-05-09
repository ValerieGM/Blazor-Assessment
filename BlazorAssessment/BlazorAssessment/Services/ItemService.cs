using BlazorAssessment.Models;

namespace BlazorAssessment.Services
{
    public class ItemService(HttpClient http)
    {
        private readonly HttpClient _http = http;

        public async Task<List<Item>> GetItemsAsync()
        {
            try
            {
                var response = await _http.GetFromJsonAsync<ApiResponse<List<Item>>>("http://172.172.166.174:5042/api/v1/jobs");
                return response?.Data ?? [];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Getting Data: ", ex);
                return [];
            }
        }
    }

    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public int Count { get; set; }
        public T? Data { get; set; }
    }

}