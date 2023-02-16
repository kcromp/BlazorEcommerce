namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext Context;

        public ProductService(DataContext context)
        {
            Context = context;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await Context.Products.FindAsync(productId);
            if (product != null)
            {
                response.Data = product;
            }
            else
            {
                response.Success = false;
                response.Message = "This product does not exist.";
            }

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await Context.Products.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await Context.Products.Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower())).ToListAsync()
            };

            return response;
        }
    }
}
