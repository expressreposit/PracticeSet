namespace IHttpClientFactoryExample.Repositories
{
    public interface IProductService
    {
        Task<object> GetAllProducts();
    }
}
