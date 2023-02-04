namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext Context;

        public ProductService(DataContext context)
        {
            Context = context;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await Context.Products.ToListAsync()
            };

            return response;
        }
    }
}
