using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Booklist.Models;

public class Book
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]
  public string? Id { get; set; }

  [BsonElement("bookname")]
  public string bookname { get; set; } = null!;

  [BsonElement("author")]
  public string author { get; set; } = null!;

  [BsonElement("isread")]
  public bool isread { get; set; } = false;
}
