using MongoDB.Driver;

namespace WebApplication1.Contexts
{
    public class MongoDbContext
    {
        private readonly IMongoClient _mongoClient;
        private readonly IMongoDatabase _databaseService;

        public MongoDbContext(IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings"];
            var dbName = "Product";


            // Create Client MongoDb
            _mongoClient = new MongoClient(connectionString);

            // Get Database
            _databaseService = _mongoClient.GetDatabase(dbName);
        }

        public IMongoCollection<T> GetCollectionService<T>(string name)
        {
            return _databaseService.GetCollection<T>(name);
        }
    }
}
