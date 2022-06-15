namespace EFCoreLink.API.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> Delete(int id);
        Task<Product> AddProduct(Product product);
        Task<List<Product>> UpdateProduct(Product product);

    }
}
