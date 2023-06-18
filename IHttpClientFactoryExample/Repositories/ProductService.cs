using Newtonsoft.Json;

namespace IHttpClientFactoryExample.Repositories
{
    public class ProductService: IProductService
    {
        private IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "http://localhost:1810/";
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<object> GetAllProducts()
        {
            //_httpClient = _httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
            var uri = "/api/products";
            var result = await _httpClient.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<object>(result);
        }
    }
}
