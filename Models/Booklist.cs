using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace MongoBookAPI.Models;

public class Booklist
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]
  public string? Id { get; set; }

  public string bookname { get; set; } = null!;

  public string author { get; set; } = null!;

  public bool isread { get; set; } = false;
}
