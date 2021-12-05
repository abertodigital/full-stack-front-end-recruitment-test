using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace FullStackSolution.API.Infra.ApiConfigurations
{
    public static class MongoConfiguration
    {
        private static readonly object thislock = new object();
        private static IMongoDatabase mongoDatabase = null;

        public static void RegisterConfigurations()
        {
            var pack = new ConventionPack()
            {
                new IgnoreExtraElementsConvention(true),
                new CamelCaseElementNameConvention(),
                new EnumRepresentationConvention(MongoDB.Bson.BsonType.String)
            };

            ConventionRegistry.Register("My Solution Conventions", pack, t => true);
        }

        public static void RegisterMongoDB(this IServiceCollection services, string mongoConnectionStringKey = "MongoDBConnectionString",
            string mongoDBKey = "MongoDatabase")
        {
            services.AddSingleton(m =>
            {
                var configuration = m.GetService<IConfiguration>();
                var mongoClient = new MongoClient(configuration[mongoConnectionStringKey]);
                var mongoDatabase = mongoClient.GetDatabase(configuration[mongoDBKey]);

                return mongoDatabase;
            });
        }
    }
}