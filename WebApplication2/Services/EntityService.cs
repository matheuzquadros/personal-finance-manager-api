using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using PersonalFinanceManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFinanceManager.Services
{
    public abstract class EntityService <T> where T : Entity
    {
        const string DataBaseName = "PersonalFinanceManagerDB";
        private readonly IMongoCollection<T> entities;

        public EntityService(IConfiguration config, string entityName)
        {
            MongoClient client = new MongoClient(config.GetConnectionString(DataBaseName));
            IMongoDatabase database = client.GetDatabase(DataBaseName);
            entities = database.GetCollection<T>(entityName);
        }

        public List<T> Get()
        {
            return entities.Find(user => true).ToList();
        }

        public T Get(string id)
        {
            return entities.Find(user => user.Id == id).FirstOrDefault();
        }

        public T Create(T user)
        {
            entities.InsertOne(user);
            return user;
        }

        public void Update(string id, T userIn)
        {
            entities.ReplaceOne(user => user.Id == id, userIn);
        }

        public void Remove(T userIn)
        {
            entities.DeleteOne(user => user.Id == userIn.Id);
        }

        public void Remove(string id)
        {
            entities.DeleteOne(user => user.Id == id);
        }
    }
}
