using Booklist.Settings;
using Booklist.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Booklist.Services;

public class BooklistService
{
  private readonly IMongoCollection<Book> _booklist; // Book collection instance

  public BooklistService(IOptions<MongoDBSettings> settings)
  {
    DotNetEnv.Env.Load(); // Load the environment variables from the .env file
    string? connectionString = Environment.GetEnvironmentVariable("MONGODB_CONNECTION_STRING");
    var client = new MongoClient(connectionString);
    var database = client.GetDatabase(settings.Value.DatabaseName);
    _booklist = database.GetCollection<Book>(settings.Value.CollectionName);
  }

  public List<Book> Get() => _booklist.Find(book => true).ToList();
}