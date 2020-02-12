using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Models;

namespace PersonalFinanceManager.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> users;


        public UserService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("PersonalFinanceManagerDB"));
            IMongoDatabase database = client.GetDatabase("PersonalFinanceManagerDB");
            users = database.GetCollection<User>("Users");
        }

        public List<User> Get()
        {
            return users.Find(user => true).ToList();
        }

        public User Get(string id)
        {
            return users.Find(user => user.Id == id).FirstOrDefault();
        }

        public User Create(User user)
        {
            users.InsertOne(user);
            return user;
        }

        public void Update(string id, User userIn)
        {
            users.ReplaceOne(user => user.Id == id, userIn);
        }

        public void Remove(User userIn)
        {
            users.DeleteOne(user => user.Id == userIn.Id);
        }

        public void Remove(string id)
        {
            users.DeleteOne(user => user.Id == id);
        }
    }
}
