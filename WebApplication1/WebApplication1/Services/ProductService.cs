using MongoDB.Driver;
using WebApplication1.Contexts;
using WebApplication1.Model;

namespace WebApplication1.Services
{
    public class ProductService
    {
        readonly IMongoCollection<Product> _collection;

        public ProductService(MongoDbContext mongoDbContext)
        {
            _collection = mongoDbContext.GetCollectionService<Product>("Product");
        }

        public async Task<bool> CreateProduc(Product product)
        {
            await _collection.InsertOneAsync(product);

            return true;
        }
    }
}
