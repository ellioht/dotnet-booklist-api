using MongoBookAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoBookAPI.Services;

public class MongoDBService 
{
  private readonly IMongoCollection<Booklist> _booklistCollection; 

  public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings) 
  {
    MongoDBClient client = new MongoDBClient();
  }
 
}
