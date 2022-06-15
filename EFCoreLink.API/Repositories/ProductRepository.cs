using EFCoreLink.API.Interfaces;

namespace EFCoreLink.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
            private readonly EFCoreLinkDBContext _context;

            public ProductRepository(EFCoreLinkDBContext context)
            {
                this._context = context;
            }
        public async Task<Product> AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<List<Product>> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            
            _context.Remove(product);
            await _context.SaveChangesAsync();

            return await _context.Products.ToListAsync();
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {

            return await _context.Products.FindAsync(id);
        }

        public async Task<List<Product>> UpdateProduct(Product UpdateProduct)
        {
            var product = await _context.Products.FindAsync(UpdateProduct.ProductId);
            if (product == null)
            product.ProductName = UpdateProduct.ProductName;
            await _context.SaveChangesAsync();

            return await _context.Products.ToListAsync();
        }
    }
}
